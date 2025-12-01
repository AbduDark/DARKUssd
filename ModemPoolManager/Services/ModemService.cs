using System.Collections.Concurrent;
using System.IO.Ports;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class ModemService : IDisposable
{
    private readonly ConcurrentDictionary<string, SemaphoreSlim> _portLocks = new();
    private readonly ConcurrentDictionary<string, SerialPort> _persistentPorts = new();
    private readonly int _baudRate = 115200;

    private SemaphoreSlim GetPortLock(string portName)
    {
        return _portLocks.GetOrAdd(portName, _ => new SemaphoreSlim(1, 1));
    }

    private SerialPort GetOrCreatePort(string portName)
    {
        return _persistentPorts.GetOrAdd(portName, name =>
        {
            var port = new SerialPort(name, _baudRate, Parity.None, 8, StopBits.One)
            {
                ReadTimeout = 30000,
                WriteTimeout = 3000,
                Encoding = Encoding.ASCII
            };
            return port;
        });
    }

    private void EnsurePortOpen(SerialPort port)
    {
        if (!port.IsOpen)
        {
            port.Open();
            Thread.Sleep(100);
        }
    }

    public List<string> GetAllComDevices()
    {
        var devices = new List<string>();
        
        try
        {
            using var searcher = new ManagementObjectSearcher(
                "SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%COM%'");
            
            foreach (ManagementObject obj in searcher.Get())
            {
                var caption = obj["Caption"]?.ToString() ?? "";
                if (!string.IsNullOrEmpty(caption))
                {
                    devices.Add(caption);
                }
            }
        }
        catch { }

        return devices;
    }

    public List<string> GetZTEDiagnosticsPorts()
    {
        var ports = new List<string>();
        
        try
        {
            using var searcher = new ManagementObjectSearcher(
                "SELECT * FROM Win32_PnPEntity WHERE Caption LIKE '%COM%'");
            
            foreach (ManagementObject obj in searcher.Get())
            {
                var caption = obj["Caption"]?.ToString() ?? "";
                
                bool isValidModemPort = false;
                
                if (caption.Contains("ZTE", StringComparison.OrdinalIgnoreCase) &&
                    caption.Contains("Diagnostics", StringComparison.OrdinalIgnoreCase))
                {
                    isValidModemPort = true;
                }
                
                if (caption.Contains("ZTE", StringComparison.OrdinalIgnoreCase) &&
                    !caption.Contains("NVME", StringComparison.OrdinalIgnoreCase) &&
                    !caption.Contains("NMEA", StringComparison.OrdinalIgnoreCase) &&
                    !caption.Contains("GPS", StringComparison.OrdinalIgnoreCase))
                {
                    isValidModemPort = true;
                }
                
                if (caption.Contains("Diagnostics", StringComparison.OrdinalIgnoreCase))
                {
                    isValidModemPort = true;
                }
                
                if (caption.Contains("Modem", StringComparison.OrdinalIgnoreCase) &&
                    !caption.Contains("NVME", StringComparison.OrdinalIgnoreCase))
                {
                    isValidModemPort = true;
                }
                
                if (caption.Contains("Mobile", StringComparison.OrdinalIgnoreCase) &&
                    caption.Contains("Broadband", StringComparison.OrdinalIgnoreCase))
                {
                    isValidModemPort = true;
                }

                if (caption.Contains("USB", StringComparison.OrdinalIgnoreCase) &&
                    caption.Contains("Serial", StringComparison.OrdinalIgnoreCase) &&
                    !caption.Contains("NVME", StringComparison.OrdinalIgnoreCase))
                {
                    isValidModemPort = true;
                }
                
                if (isValidModemPort)
                {
                    var match = Regex.Match(caption, @"\(COM(\d+)\)");
                    if (match.Success)
                    {
                        ports.Add($"COM{match.Groups[1].Value}");
                    }
                }
            }
        }
        catch
        {
            var availablePorts = SerialPort.GetPortNames();
            ports.AddRange(availablePorts);
        }

        return ports.Distinct().OrderBy(p => int.Parse(p.Replace("COM", ""))).ToList();
    }

    public async Task<List<Modem>> DetectModemsAsync(int maxModems = 12)
    {
        var modems = new List<Modem>();
        var ports = GetZTEDiagnosticsPorts();
        
        var tasks = ports.Take(maxModems).Select(async (port, index) =>
        {
            var modem = new Modem
            {
                Index = index + 1,
                PortName = port
            };

            try
            {
                var isConnected = await TestPortConnectionAsync(port);
                modem.IsConnected = isConnected;
                modem.Status = isConnected ? "متصل" : "غير متصل";
                
                if (isConnected)
                {
                    var serialPort = GetOrCreatePort(port);
                    EnsurePortOpen(serialPort);
                }
            }
            catch
            {
                modem.IsConnected = false;
                modem.Status = "خطأ في الاتصال";
            }

            return modem;
        });

        var results = await Task.WhenAll(tasks);
        modems.AddRange(results.Where(m => m.IsConnected));

        return modems;
    }

    private async Task<bool> TestPortConnectionAsync(string portName)
    {
        var portLock = GetPortLock(portName);
        await portLock.WaitAsync();
        
        try
        {
            var port = GetOrCreatePort(portName);
            EnsurePortOpen(port);
            
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
            
            await Task.Run(() => port.Write("AT\r"));
            await Task.Delay(500);
            
            var response = await Task.Run(() => port.ReadExisting());
            
            return response.Contains("OK");
        }
        catch
        {
            _persistentPorts.TryRemove(portName, out _);
            return false;
        }
        finally
        {
            portLock.Release();
        }
    }

    public async Task<string> GetPhoneNumberAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+CNUM", 3000);
            
            var match = Regex.Match(response, @"\+CNUM:.*?""([^""]+)"".*?""(\+?\d+)""");
            if (match.Success)
            {
                return match.Groups[2].Value;
            }

            response = await SendATCommandAsync(portName, "AT+CUSD=1,\"*100#\",15", 10000);
            match = Regex.Match(response, @"(\+?\d{10,15})");
            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return "غير معروف";
        }
        catch (Exception ex)
        {
            return $"خطأ: {ex.Message}";
        }
    }

    public async Task<List<Modem>> GetAllPhoneNumbersAsync(List<Modem> modems)
    {
        var tasks = modems.Select(async modem =>
        {
            if (modem.IsConnected)
            {
                modem.PhoneNumber = await GetPhoneNumberAsync(modem.PortName);
                modem.Status = "جاهز";
            }
            return modem;
        });

        var results = await Task.WhenAll(tasks);
        return results.ToList();
    }

    public async Task<UssdResult> ExecuteUssdAsync(Modem modem, string ussdCode)
    {
        var result = new UssdResult
        {
            ModemIndex = modem.Index,
            PortName = modem.PortName,
            PhoneNumber = modem.PhoneNumber,
            UssdCode = ussdCode
        };

        try
        {
            var encodedUssd = EncodeUssd(ussdCode);
            var command = $"AT+CUSD=1,\"{encodedUssd}\",15";
            
            var response = await SendATCommandAsync(modem.PortName, command, 30000);
            
            result.Response = DecodeUssdResponse(response);
            result.IsSuccess = response.Contains("+CUSD:") || response.Contains("OK");
            
            if (!result.IsSuccess)
            {
                result.ErrorMessage = "لا توجد استجابة من الشبكة";
            }
        }
        catch (Exception ex)
        {
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
            result.Response = $"خطأ: {ex.Message}";
        }

        return result;
    }

    public async Task<List<UssdResult>> ExecuteUssdOnAllAsync(List<Modem> modems, string ussdCode)
    {
        var selectedModems = modems.Where(m => m.IsConnected && m.IsSelected).ToList();
        
        var tasks = selectedModems.Select(modem => ExecuteUssdAsync(modem, ussdCode));
        
        var results = await Task.WhenAll(tasks);
        return results.ToList();
    }

    private async Task<string> SendATCommandAsync(string portName, string command, int timeout = 5000)
    {
        var portLock = GetPortLock(portName);
        await portLock.WaitAsync();
        
        try
        {
            var port = GetOrCreatePort(portName);
            port.ReadTimeout = timeout;
            EnsurePortOpen(port);

            var response = new StringBuilder();
            
            port.DiscardInBuffer();
            port.DiscardOutBuffer();

            await Task.Run(() => port.Write(command + "\r"));

            var startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalMilliseconds < timeout)
            {
                await Task.Delay(100);
                
                if (port.BytesToRead > 0)
                {
                    var data = await Task.Run(() => port.ReadExisting());
                    response.Append(data);
                    
                    var currentResponse = response.ToString();
                    if (currentResponse.Contains("OK") || 
                        currentResponse.Contains("ERROR") ||
                        currentResponse.Contains("+CUSD:"))
                    {
                        await Task.Delay(300);
                        if (port.BytesToRead > 0)
                        {
                            response.Append(await Task.Run(() => port.ReadExisting()));
                        }
                        break;
                    }
                }
            }

            return response.ToString();
        }
        finally
        {
            portLock.Release();
        }
    }

    private string EncodeUssd(string ussdCode)
    {
        if (ussdCode.All(c => char.IsDigit(c) || c == '*' || c == '#' || c == '+'))
        {
            return ussdCode;
        }

        var bytes = Encoding.BigEndianUnicode.GetBytes(ussdCode);
        return BitConverter.ToString(bytes).Replace("-", "");
    }

    private string DecodeUssdResponse(string response)
    {
        try
        {
            var match = Regex.Match(response, @"\+CUSD:\s*\d+,\s*""([^""]+)""", RegexOptions.Singleline);
            if (match.Success)
            {
                var content = match.Groups[1].Value;

                if (Regex.IsMatch(content, @"^[0-9A-Fa-f]+$") && content.Length % 4 == 0)
                {
                    var bytes = new byte[content.Length / 2];
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        bytes[i] = Convert.ToByte(content.Substring(i * 2, 2), 16);
                    }
                    return Encoding.BigEndianUnicode.GetString(bytes);
                }

                return content;
            }

            return response;
        }
        catch
        {
            return response;
        }
    }

    public async Task<string> GetSignalStrengthAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+CSQ", 3000);
            var match = Regex.Match(response, @"\+CSQ:\s*(\d+),");
            if (match.Success)
            {
                var rssi = int.Parse(match.Groups[1].Value);
                var percent = Math.Min(100, rssi * 100 / 31);
                return $"{percent}%";
            }
            return "N/A";
        }
        catch
        {
            return "N/A";
        }
    }

    public async Task<string> GetOperatorAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+COPS?", 3000);
            var match = Regex.Match(response, @"\+COPS:\s*\d+,\d+,""([^""]+)""");
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            return "N/A";
        }
        catch
        {
            return "N/A";
        }
    }

    public void CloseAllPorts()
    {
        foreach (var kvp in _persistentPorts)
        {
            try
            {
                if (kvp.Value.IsOpen)
                    kvp.Value.Close();
            }
            catch { }
        }
    }

    public void Dispose()
    {
        foreach (var port in _persistentPorts.Values)
        {
            try
            {
                if (port.IsOpen)
                    port.Close();
                port.Dispose();
            }
            catch { }
        }
        _persistentPorts.Clear();

        foreach (var semaphore in _portLocks.Values)
        {
            semaphore.Dispose();
        }
        _portLocks.Clear();
    }
}
