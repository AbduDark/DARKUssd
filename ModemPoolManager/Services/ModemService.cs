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
                "SELECT * FROM Win32_PnPEntity WHERE ClassGuid = '{4D36E978-E325-11CE-BFC1-08002BE10318}'");
            
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
                "SELECT * FROM Win32_PnPEntity WHERE ClassGuid = '{4D36E978-E325-11CE-BFC1-08002BE10318}'");
            
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
                
                if (caption.Contains("COM", StringComparison.OrdinalIgnoreCase))
                {
                    var match = Regex.Match(caption, @"\(COM(\d+)\)");
                    if (match.Success)
                    {
                        if (isValidModemPort)
                        {
                            ports.Add($"COM{match.Groups[1].Value}");
                        }
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

    public async Task<string> SendATCommandPublicAsync(string portName, string command, int timeout = 5000)
    {
        return await SendATCommandAsync(portName, command, timeout);
    }

    public async Task<ModemInfo> GetModemInfoAsync(string portName)
    {
        var info = new ModemInfo { LastUpdated = DateTime.Now };

        try
        {
            var imeiResponse = await SendATCommandAsync(portName, "AT+CGSN", 3000);
            var imeiMatch = Regex.Match(imeiResponse, @"(\d{15})");
            if (imeiMatch.Success) info.Imei = imeiMatch.Groups[1].Value;

            var imsiResponse = await SendATCommandAsync(portName, "AT+CIMI", 3000);
            var imsiMatch = Regex.Match(imsiResponse, @"(\d{15})");
            if (imsiMatch.Success) info.Imsi = imsiMatch.Groups[1].Value;

            var iccidResponse = await SendATCommandAsync(portName, "AT+CCID", 3000);
            var iccidMatch = Regex.Match(iccidResponse, @"(\d{19,20})");
            if (iccidMatch.Success) info.Iccid = iccidMatch.Groups[1].Value;

            var manufacturerResponse = await SendATCommandAsync(portName, "AT+CGMI", 3000);
            if (!manufacturerResponse.Contains("ERROR"))
            {
                info.Manufacturer = manufacturerResponse.Replace("OK", "").Replace("AT+CGMI", "").Trim();
            }

            var modelResponse = await SendATCommandAsync(portName, "AT+CGMM", 3000);
            if (!modelResponse.Contains("ERROR"))
            {
                info.Model = modelResponse.Replace("OK", "").Replace("AT+CGMM", "").Trim();
            }

            var firmwareResponse = await SendATCommandAsync(portName, "AT+CGMR", 3000);
            if (!firmwareResponse.Contains("ERROR"))
            {
                info.FirmwareVersion = firmwareResponse.Replace("OK", "").Replace("AT+CGMR", "").Trim();
            }

            var simResponse = await SendATCommandAsync(portName, "AT+CPIN?", 3000);
            var simMatch = Regex.Match(simResponse, @"\+CPIN:\s*(.+?)[\r\n]");
            if (simMatch.Success) info.SimStatus = simMatch.Groups[1].Value.Trim();

            var regResponse = await SendATCommandAsync(portName, "AT+CREG?", 3000);
            var regMatch = Regex.Match(regResponse, @"\+CREG:\s*\d+,(\d+)");
            if (regMatch.Success)
            {
                var regStatus = regMatch.Groups[1].Value;
                info.NetworkStatus = regStatus switch
                {
                    "0" => "غير مسجل",
                    "1" => "مسجل (محلي)",
                    "2" => "جاري البحث",
                    "3" => "مرفوض",
                    "4" => "غير معروف",
                    "5" => "مسجل (تجوال)",
                    _ => regStatus
                };
                info.IsRoaming = regStatus == "5";
            }

            var signalResponse = await SendATCommandAsync(portName, "AT+CSQ", 3000);
            var signalMatch = Regex.Match(signalResponse, @"\+CSQ:\s*(\d+),(\d+)");
            if (signalMatch.Success)
            {
                var rssi = int.Parse(signalMatch.Groups[1].Value);
                if (rssi <= 31)
                {
                    info.SignalDbm = -113 + (rssi * 2);
                    info.SignalPercent = Math.Min(100, rssi * 100.0 / 31);
                    info.SignalBars = rssi switch
                    {
                        <= 5 => 1,
                        <= 10 => 2,
                        <= 15 => 3,
                        <= 20 => 4,
                        _ => 5
                    };
                }
            }

            var operatorResponse = await SendATCommandAsync(portName, "AT+COPS?", 3000);
            var operatorMatch = Regex.Match(operatorResponse, @"\+COPS:\s*(\d+),(\d+),""([^""]+)""(?:,(\d+))?");
            if (operatorMatch.Success)
            {
                info.OperatorName = operatorMatch.Groups[3].Value;
                if (operatorMatch.Groups[4].Success)
                {
                    var accessTech = operatorMatch.Groups[4].Value;
                    info.NetworkType = accessTech switch
                    {
                        "0" => "GSM",
                        "1" => "GSM Compact",
                        "2" => "UTRAN (3G)",
                        "3" => "EDGE",
                        "4" => "HSDPA",
                        "5" => "HSUPA",
                        "6" => "HSPA",
                        "7" => "LTE",
                        _ => accessTech
                    };
                }
            }
        }
        catch { }

        return info;
    }

    public async Task<(bool Success, string Error)> ResetModemAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+CFUN=1,1", 10000);
            return (response.Contains("OK"), response.Contains("ERROR") ? "فشل في إعادة التشغيل" : string.Empty);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public async Task<(bool Success, string Error)> SetAirplaneModeAsync(string portName, bool enable)
    {
        try
        {
            var command = enable ? "AT+CFUN=0" : "AT+CFUN=1";
            var response = await SendATCommandAsync(portName, command, 5000);
            return (response.Contains("OK"), response.Contains("ERROR") ? "فشل في تغيير الوضع" : string.Empty);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public async Task<string> ExecuteRawCommandAsync(string portName, string command, int timeout = 5000)
    {
        return await SendATCommandAsync(portName, command, timeout);
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
