using System.Collections.Concurrent;
using System.IO.Ports;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class ModemService : IDisposable
{
    private readonly ConcurrentDictionary<string, SemaphoreSlim> _portLocks = new();
    private readonly ConcurrentDictionary<string, SerialPort> _persistentPorts = new();
    private readonly ConcurrentDictionary<string, Modem> _activeModems = new();
    private readonly int _baudRate = 115200;
    
    private ManagementEventWatcher? _insertWatcher;
    private ManagementEventWatcher? _removeWatcher;
    private System.Timers.Timer? _statusTimer;
    private bool _isMonitoring;
    
    public event EventHandler<Modem>? ModemConnected;
    public event EventHandler<Modem>? ModemDisconnected;
    public event EventHandler<Modem>? ModemUpdated;
    public event EventHandler<string>? MonitoringStatusChanged;

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
                "root\\CIMV2", "SELECT * FROM Win32_PnPEntity");
            
            foreach (ManagementObject obj in searcher.Get())
            {
                var name = obj["Name"]?.ToString() ?? "";
                
                if (string.IsNullOrEmpty(name))
                    continue;
                
                if (name.Contains("ZTE NMEA Device", StringComparison.OrdinalIgnoreCase))
                {
                    var portName = ExtractPortFromName(name, "ZTE NMEA Device");
                    if (!string.IsNullOrEmpty(portName))
                        ports.Add(portName);
                }
                else if (name.Contains("ZTE Diagnostics Interface", StringComparison.OrdinalIgnoreCase))
                {
                    var portName = ExtractPortFromName(name, "ZTE Diagnostics Interface");
                    if (!string.IsNullOrEmpty(portName))
                        ports.Add(portName);
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
    
    private string ExtractPortFromName(string deviceName, string deviceType)
    {
        var cleaned = deviceName.Replace(deviceType, "")
                                .Replace("(", "")
                                .Replace(")", "")
                                .Replace(" ", "")
                                .Trim();
        
        if (cleaned.StartsWith("COM", StringComparison.OrdinalIgnoreCase) && 
            int.TryParse(cleaned.Substring(3), out _))
        {
            return cleaned.ToUpper();
        }
        
        return string.Empty;
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
            if (_persistentPorts.TryGetValue(portName, out var existingPort))
            {
                try
                {
                    if (!existingPort.IsOpen)
                    {
                        existingPort.Open();
                        await Task.Delay(100);
                    }
                }
                catch
                {
                    _persistentPorts.TryRemove(portName, out _);
                    try { existingPort.Dispose(); } catch { }
                }
            }
            
            var port = GetOrCreatePort(portName);
            EnsurePortOpen(port);
            
            port.DiscardInBuffer();
            port.DiscardOutBuffer();
            
            await Task.Run(() => port.Write("AT\r"));
            
            var response = new StringBuilder();
            var timeout = 3000;
            var startTime = DateTime.Now;
            
            while ((DateTime.Now - startTime).TotalMilliseconds < timeout)
            {
                await Task.Delay(100);
                
                if (port.BytesToRead > 0)
                {
                    var data = await Task.Run(() => port.ReadExisting());
                    response.Append(data);
                    
                    if (response.ToString().Contains("OK"))
                    {
                        return true;
                    }
                }
            }
            
            return response.ToString().Contains("OK");
        }
        catch
        {
            CleanupPort(portName);
            return false;
        }
        finally
        {
            portLock.Release();
        }
    }

    private bool IsValidEgyptianNumber(string number)
    {
        if (string.IsNullOrEmpty(number)) return false;
        
        var normalized = NormalizeEgyptianNumber(number);
        if (string.IsNullOrEmpty(normalized)) return false;
        
        return Regex.IsMatch(normalized, @"^01[0125]\d{8}$");
    }

    private string? NormalizeEgyptianNumber(string number)
    {
        if (string.IsNullOrEmpty(number)) return null;
        
        var cleaned = Regex.Replace(number, @"[^\d+]", "");
        
        if (cleaned.StartsWith("+20") && cleaned.Length == 13)
        {
            return "0" + cleaned.Substring(3);
        }
        
        if (cleaned.StartsWith("20") && cleaned.Length == 12)
        {
            return "0" + cleaned.Substring(2);
        }
        
        if (cleaned.StartsWith("01") && cleaned.Length == 11)
        {
            return cleaned;
        }
        
        return null;
    }

    public async Task<string> GetPhoneNumberAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+CNUM", 1500);
            Console.WriteLine($"[{portName}] AT+CNUM response: {response}");
            
            if (!response.Contains("ERROR"))
            {
                var patterns = new[]
                {
                    @"\+CNUM:\s*""[^""]*""\s*,\s*""(\+?\d{10,15})""",
                    @"\+CNUM:\s*,\s*""(\+?\d{10,15})""",
                    @"\+CNUM:\s*""(\+?\d{10,15})""",
                    @"""(\+?\d{10,15})"""
                };
                
                foreach (var pattern in patterns)
                {
                    var match = Regex.Match(response, pattern);
                    if (match.Success)
                    {
                        var rawNumber = match.Groups[1].Value;
                        var normalized = NormalizeEgyptianNumber(rawNumber);
                        
                        if (normalized != null && IsValidEgyptianNumber(normalized))
                        {
                            Console.WriteLine($"[{portName}] Valid Egyptian number: {normalized}");
                            return normalized;
                        }
                        else
                        {
                            Console.WriteLine($"[{portName}] Invalid number from AT+CNUM: {rawNumber}");
                        }
                    }
                }
            }

            return "غير معروف";
        }
        catch
        {
            return "غير معروف";
        }
    }

    public async Task<string> GetPhoneNumberWithUssdFallbackAsync(string portName, string? operatorName = null)
    {
        try
        {
            var number = await GetPhoneNumberFastAsync(portName);
            if (number != "غير معروف" && !number.StartsWith("خطأ"))
            {
                return number;
            }

            if (string.IsNullOrEmpty(operatorName))
            {
                operatorName = await GetOperatorAsync(portName);
            }

            string ussdCode = GetPhoneNumberUssdCode(operatorName);
            if (string.IsNullOrEmpty(ussdCode))
            {
                return "غير معروف";
            }

            Console.WriteLine($"[{portName}] جاري جلب الرقم باستخدام USSD: {ussdCode}");
            var ussdResponse = await SendUssdCommandAsync(portName, $"AT+CUSD=1,\"{ussdCode}\",15", 5);
            
            var extractedNumber = ExtractPhoneNumberFromUssd(ussdResponse);
            if (!string.IsNullOrEmpty(extractedNumber))
            {
                return extractedNumber;
            }

            return "غير معروف";
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{portName}] خطأ في جلب الرقم: {ex.Message}");
            return "غير معروف";
        }
    }

    private string GetPhoneNumberUssdCode(string? operatorName)
    {
        if (string.IsNullOrEmpty(operatorName))
            return "*878#";

        var opLower = operatorName.ToLowerInvariant();
        
        if (opLower.Contains("vodafone") || opLower.Contains("فودافون"))
            return "*878#";
        
        if (opLower.Contains("orange") || opLower.Contains("اورنج") || opLower.Contains("موبينيل"))
            return "*100*6*1*2#";
        
        if (opLower.Contains("etisalat") || opLower.Contains("اتصالات"))
            return "*947#";
        
        if (opLower.Contains("we") || opLower.Contains("وي") || opLower.Contains("المصرية"))
            return "*999#";
        
        if (opLower.Contains("stc") || opLower.Contains("اس تي سي"))
            return "*166*2#";
        
        if (opLower.Contains("mobily") || opLower.Contains("موبايلي"))
            return "*1100#";
        
        if (opLower.Contains("zain") || opLower.Contains("زين"))
            return "*142*3#";
        
        return "*878#";
    }

    private string? ExtractPhoneNumberFromUssd(string ussdResponse)
    {
        Console.WriteLine($"Extracting phone from USSD: {ussdResponse}");
        
        var patterns = new[]
        {
            @"(\+?20\d{10})",
            @"(01[0125]\d{8})",
            @"رقمك[:\s]*(\d{10,11})",
            @"Your number[:\s]*(\d{10,15})",
            @"(\d{11})"
        };

        foreach (var pattern in patterns)
        {
            var matches = Regex.Matches(ussdResponse, pattern);
            foreach (Match match in matches)
            {
                var rawNumber = match.Groups[1].Value;
                var normalized = NormalizeEgyptianNumber(rawNumber);
                
                if (normalized != null && IsValidEgyptianNumber(normalized))
                {
                    Console.WriteLine($"Valid Egyptian number from USSD: {normalized}");
                    return normalized;
                }
            }
        }

        Console.WriteLine("No valid Egyptian number found in USSD response");
        return null;
    }

    public async Task<bool> RefreshModemSignalAsync(Modem modem)
    {
        if (modem.IsBusy) return false;
        
        try
        {
            modem.IsBusy = true;
            var (strength, level) = await GetSignalStrengthWithLevelAsync(modem.PortName);
            modem.SignalStrength = strength;
            modem.SignalLevel = level;
            modem.LastActivity = DateTime.Now;
            ModemUpdated?.Invoke(this, modem);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{modem.PortName}] خطأ في تحديث الإشارة: {ex.Message}");
            return false;
        }
        finally
        {
            modem.IsBusy = false;
        }
    }

    public async Task<bool> RefreshModemPhoneNumberAsync(Modem modem)
    {
        if (modem.IsBusy) return false;
        
        try
        {
            modem.IsBusy = true;
            
            if (string.IsNullOrEmpty(modem.Operator))
            {
                modem.Operator = await GetOperatorAsync(modem.PortName);
            }
            
            var number = await GetPhoneNumberViaUssdDirectAsync(modem.PortName, modem.Operator);
            
            modem.PhoneNumber = number;
            modem.LastActivity = DateTime.Now;
            ModemUpdated?.Invoke(this, modem);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{modem.PortName}] خطأ في جلب الرقم: {ex.Message}");
            modem.PhoneNumber = "غير معروف";
            return false;
        }
        finally
        {
            modem.IsBusy = false;
        }
    }

    public async Task<string> GetPhoneNumberViaUssdAsync(string portName, string ussdCode = "*100#")
    {
        try
        {
            var response = await SendUssdCommandAsync(portName, $"AT+CUSD=1,\"{ussdCode}\",15", 10);
            
            var match = Regex.Match(response, @"(\+?\d{10,15})");
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

    public async Task<string> GetPhoneNumberSmartAsync(string portName)
    {
        try
        {
            var number = await GetPhoneNumberAsync(portName);
            if (number != "غير معروف" && !number.StartsWith("خطأ"))
            {
                return number;
            }

            number = await GetPhoneNumberViaUssdAsync(portName);
            return number;
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

    public async Task<UssdResult> ExecuteUssdAsync(Modem modem, string ussdCode, int ussdWaitTimeSeconds = 10)
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
            
            var response = await SendUssdCommandAsync(modem.PortName, command, ussdWaitTimeSeconds);
            
            result.Response = DecodeUssdResponse(response);
            result.IsSuccess = response.Contains("+CUSD:");
            
            if (!result.IsSuccess)
            {
                if (response.Contains("No USSD response received"))
                {
                    result.ErrorMessage = "No USSD response received";
                    result.Response = "لم يتم استلام رد USSD خلال فترة الانتظار";
                }
                else if (response.Contains("ERROR"))
                {
                    result.ErrorMessage = "خطأ من المودم";
                }
                else
                {
                    result.ErrorMessage = "لا توجد استجابة من الشبكة";
                }
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
                await Task.Delay(50);
                
                if (port.BytesToRead > 0)
                {
                    var data = await Task.Run(() => port.ReadExisting());
                    response.Append(data);
                    
                    var currentResponse = response.ToString();
                    if (currentResponse.Contains("OK") || currentResponse.Contains("ERROR"))
                    {
                        await Task.Delay(100);
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

    private async Task<string> SendUssdCommandAsync(string portName, string command, int ussdWaitTimeSeconds = 10)
    {
        var portLock = GetPortLock(portName);
        await portLock.WaitAsync();
        
        try
        {
            var port = GetOrCreatePort(portName);
            port.ReadTimeout = 60000;
            EnsurePortOpen(port);

            var response = new StringBuilder();
            var ussdLines = new List<string>();
            bool receivedOk = false;
            bool receivedError = false;
            
            port.DiscardInBuffer();
            port.DiscardOutBuffer();

            Console.WriteLine($"[{portName}] إرسال: {command}");
            await Task.Run(() => port.Write(command + "\r"));

            var commandStartTime = DateTime.Now;
            var totalTimeout = ussdWaitTimeSeconds * 1000;
            
            Console.WriteLine($"[{portName}] بدء الاستماع لمدة {ussdWaitTimeSeconds} ثانية...");
            
            while ((DateTime.Now - commandStartTime).TotalMilliseconds < totalTimeout)
            {
                await Task.Delay(100);
                
                if (port.BytesToRead > 0)
                {
                    var data = await Task.Run(() => port.ReadExisting());
                    response.Append(data);
                    
                    var lines = data.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var line in lines)
                    {
                        var trimmedLine = line.Trim();
                        
                        if (trimmedLine.Contains("+CUSD:"))
                        {
                            Console.WriteLine($"[{portName}] +CUSD: {trimmedLine}");
                            if (!ussdLines.Contains(trimmedLine))
                            {
                                ussdLines.Add(trimmedLine);
                            }
                        }
                        else if (trimmedLine == "OK" && !receivedOk)
                        {
                            receivedOk = true;
                            var elapsed = (DateTime.Now - commandStartTime).TotalSeconds;
                            var remaining = ussdWaitTimeSeconds - elapsed;
                            Console.WriteLine($"[{portName}] OK استلم بعد {elapsed:F1} ثانية - الاستمرار في الاستماع لمدة {remaining:F1} ثانية إضافية...");
                        }
                        else if (trimmedLine.Contains("ERROR"))
                        {
                            receivedError = true;
                            Console.WriteLine($"[{portName}] خطأ: {trimmedLine}");
                        }
                    }
                }
                
                if (receivedError)
                {
                    Console.WriteLine($"[{portName}] توقف بسبب خطأ من المودم");
                    break;
                }
            }
            
            var totalElapsed = (DateTime.Now - commandStartTime).TotalSeconds;
            Console.WriteLine($"[{portName}] انتهت فترة الاستماع بعد {totalElapsed:F1} ثانية");
            
            if (ussdLines.Count > 0)
            {
                Console.WriteLine($"[{portName}] تم استلام {ussdLines.Count} رد(ود) USSD:");
                foreach (var ussdLine in ussdLines)
                {
                    Console.WriteLine($"  → {ussdLine}");
                }
            }
            else if (!receivedError)
            {
                Console.WriteLine($"[{portName}] No USSD response received");
                response.AppendLine("No USSD response received");
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

    public async Task<(string Strength, int Level)> GetSignalStrengthWithLevelAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+CSQ", 2000);
            var match = Regex.Match(response, @"\+CSQ:\s*(\d+),");
            if (match.Success)
            {
                var rssi = int.Parse(match.Groups[1].Value);
                if (rssi == 99)
                {
                    return ("N/A", 0);
                }
                var percent = Math.Min(100, rssi * 100 / 31);
                return ($"{percent}%", rssi);
            }
            return ("N/A", 0);
        }
        catch
        {
            return ("N/A", 0);
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

    public async Task<bool> SetNetworkModeAsync(string portName, string operatorName)
    {
        try
        {
            bool is2GOnly = false;
            
            if (!string.IsNullOrEmpty(operatorName))
            {
                var opLower = operatorName.ToLowerInvariant();
                is2GOnly = opLower.Contains("vodafone") || opLower.Contains("فودافون");
            }
            
            string command;
            string targetMode = is2GOnly ? "2G" : "3G";
            
            if (is2GOnly)
            {
                command = "AT+ZSNT=0,0,1";
                Console.WriteLine($"[{portName}] ضبط الشبكة على 2G فقط (Vodafone)");
            }
            else
            {
                command = "AT+ZSNT=0,0,2";
                Console.WriteLine($"[{portName}] ضبط الشبكة على 3G فقط");
            }
            
            var response = await SendATCommandAsync(portName, command, 5000);
            
            if (response.Contains("ERROR"))
            {
                Console.WriteLine($"[{portName}] AT+ZSNT غير مدعوم، جاري تجربة AT^SYSCFG...");
                if (is2GOnly)
                {
                    command = "AT^SYSCFG=2,0,3FFFFFFF,0,0";
                }
                else
                {
                    command = "AT^SYSCFG=2,2,3FFFFFFF,0,2";
                }
                response = await SendATCommandAsync(portName, command, 5000);
            }
            
            var success = response.Contains("OK");
            Console.WriteLine($"[{portName}] نتيجة ضبط الشبكة ({targetMode}): {(success ? "نجح" : "فشل")}");
            return success;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{portName}] خطأ في ضبط الشبكة: {ex.Message}");
            return false;
        }
    }

    public async Task<string> GetNetworkModeAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+ZSNT?", 3000);
            var match = Regex.Match(response, @"\+ZSNT:\s*(\d+),(\d+),(\d+)");
            if (match.Success)
            {
                var mode = match.Groups[3].Value;
                return mode switch
                {
                    "0" => "تلقائي",
                    "1" => "2G فقط",
                    "2" => "3G فقط",
                    _ => mode
                };
            }
            return "غير معروف";
        }
        catch
        {
            return "غير معروف";
        }
    }

    public async Task<string> SendUssdCommandPublicAsync(string portName, string ussdCode, int ussdWaitTimeSeconds = 10)
    {
        var encodedUssd = EncodeUssd(ussdCode);
        var command = $"AT+CUSD=1,\"{encodedUssd}\",15";
        return await SendUssdCommandAsync(portName, command, ussdWaitTimeSeconds);
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

    public void StartMonitoring(int updateIntervalMs = 5000)
    {
        if (_isMonitoring) return;
        _isMonitoring = true;
        
        try
        {
            var insertQuery = new WqlEventQuery(
                "SELECT * FROM __InstanceCreationEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_PnPEntity' AND TargetInstance.ClassGuid = '{4D36E978-E325-11CE-BFC1-08002BE10318}'");
            _insertWatcher = new ManagementEventWatcher(insertQuery);
            _insertWatcher.EventArrived += OnDeviceInserted;
            _insertWatcher.Start();
            
            var removeQuery = new WqlEventQuery(
                "SELECT * FROM __InstanceDeletionEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_PnPEntity' AND TargetInstance.ClassGuid = '{4D36E978-E325-11CE-BFC1-08002BE10318}'");
            _removeWatcher = new ManagementEventWatcher(removeQuery);
            _removeWatcher.EventArrived += OnDeviceRemoved;
            _removeWatcher.Start();
        }
        catch { }
        
        _statusTimer = new System.Timers.Timer(updateIntervalMs);
        _statusTimer.Elapsed += async (s, e) => await UpdateAllModemsStatusAsync();
        _statusTimer.AutoReset = true;
        _statusTimer.Start();
        
        MonitoringStatusChanged?.Invoke(this, "بدء المراقبة التلقائية");
        
        Task.Run(async () => await ScanForModemsAsync());
    }

    public void StopMonitoring()
    {
        if (!_isMonitoring) return;
        _isMonitoring = false;
        
        try
        {
            _insertWatcher?.Stop();
            _insertWatcher?.Dispose();
            _insertWatcher = null;
            
            _removeWatcher?.Stop();
            _removeWatcher?.Dispose();
            _removeWatcher = null;
        }
        catch { }
        
        _statusTimer?.Stop();
        _statusTimer?.Dispose();
        _statusTimer = null;
        
        MonitoringStatusChanged?.Invoke(this, "توقف المراقبة");
    }

    private void OnDeviceInserted(object sender, EventArrivedEventArgs e)
    {
        Task.Run(async () =>
        {
            Console.WriteLine("[WMI] تم اكتشاف جهاز جديد...");
            await Task.Delay(2000);
            
            var ports = GetZTEDiagnosticsPorts();
            Console.WriteLine($"[WMI] المنافذ المتاحة: {string.Join(", ", ports)}");
            
            foreach (var portName in ports)
            {
                if (!_activeModems.ContainsKey(portName))
                {
                    if (_persistentPorts.TryRemove(portName, out var oldPort))
                    {
                        try { if (oldPort.IsOpen) oldPort.Close(); oldPort.Dispose(); } catch { }
                    }
                    if (_portLocks.TryRemove(portName, out var oldLock))
                    {
                        try { oldLock.Dispose(); } catch { }
                    }
                }
            }
            
            await ScanForModemsAsync();
        });
    }

    private void OnDeviceRemoved(object sender, EventArrivedEventArgs e)
    {
        Task.Run(async () =>
        {
            Console.WriteLine("[WMI] تم فصل جهاز...");
            await Task.Delay(500);
            await CheckForDisconnectedModemsAsync();
        });
    }

    private async Task ScanForModemsAsync()
    {
        try
        {
            var ports = GetZTEDiagnosticsPorts();
            Console.WriteLine($"[Scan] المنافذ المكتشفة: {string.Join(", ", ports)}");
            Console.WriteLine($"[Scan] المودمات النشطة حالياً: {string.Join(", ", _activeModems.Keys)}");
            
            int index = _activeModems.Count + 1;
            
            foreach (var portName in ports)
            {
                if (!_activeModems.ContainsKey(portName))
                {
                    Console.WriteLine($"[Scan] جاري اختبار المنفذ: {portName}");
                    
                    if (_persistentPorts.TryRemove(portName, out var oldPort))
                    {
                        try { if (oldPort.IsOpen) oldPort.Close(); oldPort.Dispose(); } catch { }
                    }
                    if (_portLocks.TryRemove(portName, out var oldLock))
                    {
                        try { oldLock.Dispose(); } catch { }
                    }
                    
                    await Task.Delay(300);
                    
                    var isConnected = await TestPortConnectionAsync(portName);
                    Console.WriteLine($"[Scan] نتيجة اختبار {portName}: {(isConnected ? "متصل" : "غير متصل")}");
                    
                    if (isConnected)
                    {
                        var modem = new Modem
                        {
                            Index = index++,
                            PortName = portName,
                            IsConnected = true,
                            Status = "جاري التحميل..."
                        };
                        
                        _activeModems[portName] = modem;
                        Console.WriteLine($"[Scan] تم إضافة مودم جديد: {portName}");
                        ModemConnected?.Invoke(this, modem);
                        
                        _ = LoadModemInfoAsync(modem);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Scan] خطأ: {ex.Message}");
        }
    }

    private async Task CheckForDisconnectedModemsAsync()
    {
        try
        {
            var currentPorts = GetZTEDiagnosticsPorts();
            var disconnectedPorts = _activeModems.Keys.Where(p => !currentPorts.Contains(p)).ToList();
            
            foreach (var portName in disconnectedPorts)
            {
                if (_activeModems.TryRemove(portName, out var modem))
                {
                    modem.IsConnected = false;
                    modem.Status = "تم الفصل ❌";
                    modem.SignalStrength = "N/A";
                    
                    CleanupPort(portName);
                    
                    ModemDisconnected?.Invoke(this, modem);
                }
            }
        }
        catch { }
    }
    
    private void CleanupPort(string portName)
    {
        if (_persistentPorts.TryRemove(portName, out var port))
        {
            try 
            { 
                if (port.IsOpen) port.Close(); 
                port.Dispose(); 
            } 
            catch { }
        }
        
        if (_portLocks.TryRemove(portName, out var lockObj))
        {
            try { lockObj.Dispose(); } catch { }
        }
    }

    private async Task LoadModemInfoAsync(Modem modem)
    {
        try
        {
            modem.Status = "جاري جلب الرقم...";
            ModemUpdated?.Invoke(this, modem);
            
            var operatorTask = GetOperatorAsync(modem.PortName);
            var signalTask = GetSignalStrengthWithLevelAsync(modem.PortName);
            
            await Task.WhenAll(operatorTask, signalTask);
            
            modem.Operator = await operatorTask;
            var (strength, level) = await signalTask;
            modem.SignalStrength = strength;
            modem.SignalLevel = level;
            
            ModemUpdated?.Invoke(this, modem);
            
            modem.PhoneNumber = await GetPhoneNumberViaUssdDirectAsync(modem.PortName, modem.Operator);
            
            _ = Task.Run(async () =>
            {
                try
                {
                    await SetNetworkModeAsync(modem.PortName, modem.Operator);
                    modem.NetworkMode = await GetNetworkModeAsync(modem.PortName);
                    if (modem.NetworkMode == "غير معروف")
                    {
                        var opLower = modem.Operator?.ToLowerInvariant() ?? "";
                        modem.NetworkMode = (opLower.Contains("vodafone") || opLower.Contains("فودافون")) ? "2G" : "3G";
                    }
                    ModemUpdated?.Invoke(this, modem);
                }
                catch { }
            });
            
            modem.Status = "متصل ✓";
            modem.LastActivity = DateTime.Now;
            
            ModemUpdated?.Invoke(this, modem);
        }
        catch
        {
            modem.Status = "خطأ في التحميل";
            ModemUpdated?.Invoke(this, modem);
        }
    }
    
    public async Task<string> GetPhoneNumberViaUssdDirectAsync(string portName, string? operatorName = null)
    {
        try
        {
            if (string.IsNullOrEmpty(operatorName))
            {
                operatorName = await GetOperatorAsync(portName);
            }
            
            string ussdCode = GetPhoneNumberUssdCodeDirect(operatorName);
            if (string.IsNullOrEmpty(ussdCode))
            {
                return "غير معروف";
            }
            
            Console.WriteLine($"[{portName}] جاري جلب الرقم مباشرة عبر USSD: {ussdCode}");
            
            var portLock = GetPortLock(portName);
            await portLock.WaitAsync();
            
            try
            {
                var port = GetOrCreatePort(portName);
                port.ReadTimeout = 10000;
                EnsurePortOpen(port);
                
                port.DiscardInBuffer();
                port.DiscardOutBuffer();
                
                var encodedUssd = EncodeUssd(ussdCode);
                var command = $"AT+CUSD=1,\"{encodedUssd}\",15";
                
                await Task.Run(() => port.Write(command + "\r"));
                
                var response = new StringBuilder();
                var startTime = DateTime.Now;
                var timeout = 6000;
                
                while ((DateTime.Now - startTime).TotalMilliseconds < timeout)
                {
                    await Task.Delay(300);
                    
                    if (port.BytesToRead > 0)
                    {
                        var data = await Task.Run(() => port.ReadExisting());
                        response.Append(data);
                        
                        if (response.ToString().Contains("+CUSD:"))
                        {
                            await Task.Delay(500);
                            if (port.BytesToRead > 0)
                            {
                                response.Append(await Task.Run(() => port.ReadExisting()));
                            }
                            break;
                        }
                    }
                }
                
                var fullResponse = response.ToString();
                Console.WriteLine($"[{portName}] USSD Response: {fullResponse}");
                
                var decodedResponse = DecodeUssdResponse(fullResponse);
                var extractedNumber = ExtractPhoneNumberFromUssd(decodedResponse);
                
                if (!string.IsNullOrEmpty(extractedNumber))
                {
                    Console.WriteLine($"[{portName}] تم جلب الرقم: {extractedNumber}");
                    return extractedNumber;
                }
                
                return "غير معروف";
            }
            finally
            {
                portLock.Release();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{portName}] خطأ في جلب الرقم عبر USSD: {ex.Message}");
            return "غير معروف";
        }
    }
    
    private string GetPhoneNumberUssdCodeDirect(string? operatorName)
    {
        if (string.IsNullOrEmpty(operatorName))
            return "*878#";

        var opLower = operatorName.ToLowerInvariant();
        
        if (opLower.Contains("vodafone") || opLower.Contains("فودافون"))
            return "*878#";
        
        if (opLower.Contains("orange") || opLower.Contains("اورنج") || opLower.Contains("موبينيل"))
            return "*100*6*1*2#";
        
        if (opLower.Contains("etisalat") || opLower.Contains("اتصالات"))
            return "*947#";
        
        if (opLower.Contains("we") || opLower.Contains("وي") || opLower.Contains("المصرية"))
            return "*999#";
        
        return "*878#";
    }
    
    public async Task<string> GetPhoneNumberFastAsync(string portName)
    {
        try
        {
            var response = await SendATCommandAsync(portName, "AT+CNUM", 1500);
            
            if (!response.Contains("ERROR"))
            {
                var patterns = new[]
                {
                    @"\+CNUM:\s*""[^""]*""\s*,\s*""(\+?\d{10,15})""",
                    @"\+CNUM:\s*,\s*""(\+?\d{10,15})""",
                    @"\+CNUM:\s*""(\+?\d{10,15})""",
                    @"""(\+?\d{10,15})"""
                };
                
                foreach (var pattern in patterns)
                {
                    var match = Regex.Match(response, pattern);
                    if (match.Success)
                    {
                        var rawNumber = match.Groups[1].Value;
                        var normalized = NormalizeEgyptianNumber(rawNumber);
                        
                        if (normalized != null && IsValidEgyptianNumber(normalized))
                        {
                            Console.WriteLine($"[{portName}] Fast: Valid Egyptian number: {normalized}");
                            return normalized;
                        }
                    }
                }
            }

            return "غير معروف";
        }
        catch
        {
            return "غير معروف";
        }
    }

    private async Task UpdateAllModemsStatusAsync()
    {
        if (!_isMonitoring) return;
        
        await CheckForDisconnectedModemsAsync();
        await ScanForModemsAsync();
        
        foreach (var modem in _activeModems.Values.ToList())
        {
            if (modem.IsConnected && !modem.IsBusy)
            {
                try
                {
                    var isStillConnected = await TestPortConnectionAsync(modem.PortName);
                    if (isStillConnected)
                    {
                        var (newSignal, newLevel) = await GetSignalStrengthWithLevelAsync(modem.PortName);
                        if (modem.SignalStrength != newSignal || modem.SignalLevel != newLevel)
                        {
                            modem.SignalStrength = newSignal;
                            modem.SignalLevel = newLevel;
                            modem.LastActivity = DateTime.Now;
                            ModemUpdated?.Invoke(this, modem);
                        }
                    }
                    else
                    {
                        modem.IsConnected = false;
                        modem.Status = "تم الفصل ❌";
                        _activeModems.TryRemove(modem.PortName, out _);
                        CleanupPort(modem.PortName);
                        ModemDisconnected?.Invoke(this, modem);
                    }
                }
                catch { }
            }
        }
    }
    
    public async Task ForceRescanAsync()
    {
        Console.WriteLine("[ForceRescan] بدء إعادة الفحص الشامل...");
        
        foreach (var portName in _activeModems.Keys.ToList())
        {
            CleanupPort(portName);
        }
        _activeModems.Clear();
        
        foreach (var portName in _persistentPorts.Keys.ToList())
        {
            if (_persistentPorts.TryRemove(portName, out var port))
            {
                try 
                { 
                    if (port.IsOpen) port.Close(); 
                    port.Dispose(); 
                } 
                catch { }
            }
        }
        _persistentPorts.Clear();
        
        foreach (var lockObj in _portLocks.Values)
        {
            try { lockObj.Dispose(); } catch { }
        }
        _portLocks.Clear();
        
        await Task.Delay(500);
        
        Console.WriteLine("[ForceRescan] جاري البحث عن المودمات...");
        await ScanForModemsAsync();
        Console.WriteLine($"[ForceRescan] تم العثور على {_activeModems.Count} مودم");
    }

    public IEnumerable<Modem> GetActiveModems() => _activeModems.Values;

    #region Orange Cash Methods

    public async Task<string> GetOrangeCashBalanceAsync(string portName, string password)
    {
        try
        {
            var ussdCode = $"#7115*81*{password}#";
            var command = $"AT+CUSD=1,\"{EncodeUssd(ussdCode)}\",15";
            
            var response = await SendUssdCommandAsync(portName, command, 10);
            var decoded = DecodeUssdResponse(response);
            
            var match = Regex.Match(decoded, @"(\d+(?:\.\d+)?)\s*(?:جنيه|EGP|ج\.م|LE)", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value + " ج.م";
            }
            
            match = Regex.Match(decoded, @"رصيد[^:]*:\s*(\d+(?:\.\d+)?)", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value + " ج.م";
            }
            
            match = Regex.Match(decoded, @"balance[^:]*:\s*(\d+(?:\.\d+)?)", RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value + " ج.م";
            }
            
            if (decoded.Contains("رقم سري خاطئ") || decoded.Contains("Wrong"))
            {
                return "كلمة سر خاطئة";
            }
            
            if (decoded.Contains("not subscribed"))
            {
                return "غير مشترك";
            }
            
            return decoded.Length > 50 ? decoded.Substring(0, 50) + "..." : decoded;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{portName}] خطأ في استعلام رصيد أورانج كاش: {ex.Message}");
            return $"خطأ: {ex.Message}";
        }
    }

    public async Task<(bool Success, string Message)> ExecuteOrangeCashTransferAsync(
        string portName, 
        string password, 
        string recipientNumber, 
        int amount)
    {
        try
        {
            var normalizedNumber = recipientNumber.Replace(" ", "").Trim();
            if (normalizedNumber.StartsWith("+20"))
            {
                normalizedNumber = "0" + normalizedNumber.Substring(3);
            }
            else if (normalizedNumber.StartsWith("20"))
            {
                normalizedNumber = "0" + normalizedNumber.Substring(2);
            }
            
            var ussdCode = $"#7115*31*{password}*2*{normalizedNumber}*{amount}*1*1#";
            var command = $"AT+CUSD=1,\"{EncodeUssd(ussdCode)}\",15";
            
            Console.WriteLine($"[{portName}] تحويل أورانج كاش: {amount} ج.م إلى {normalizedNumber}");
            
            var response = await SendUssdCommandAsync(portName, command, 15);
            var decoded = DecodeUssdResponse(response);
            
            Console.WriteLine($"[{portName}] الرد: {decoded}");
            
            if (decoded.Contains("تم شحن") || decoded.Contains("تم التحويل") || 
                decoded.Contains("successfully") || decoded.Contains("Success"))
            {
                return (true, "تم التحويل بنجاح ✓");
            }
            
            if (decoded.Contains("رقم سري خاطئ") || decoded.Contains("Wrong"))
            {
                return (false, "كلمة سر خاطئة");
            }
            
            if (decoded.Contains("غير كاف") || decoded.Contains("insufficient"))
            {
                return (false, "الرصيد غير كافي");
            }
            
            if (decoded.Contains("not subscribed"))
            {
                return (false, "غير مشترك في أورانج كاش");
            }
            
            if (decoded.Contains("suspended") || decoded.Contains("محظور"))
            {
                return (false, "الخط محظور");
            }
            
            if (decoded.Contains("5 دقائق") || decoded.Contains("wait"))
            {
                return (false, "انتظر 5 دقائق");
            }
            
            return (false, decoded.Length > 100 ? decoded.Substring(0, 100) : decoded);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{portName}] خطأ في تحويل أورانج كاش: {ex.Message}");
            return (false, $"خطأ: {ex.Message}");
        }
    }

    public async Task<List<(Modem Sender, Modem Receiver, bool Success, string Message)>> ExecuteParallelOrangeCashTransfersAsync(
        List<(Modem Sender, Modem Receiver)> transferPairs,
        string password,
        int amount,
        Action<Modem, string>? onSenderStatusUpdate = null,
        Action<Modem, string>? onReceiverStatusUpdate = null)
    {
        var results = new List<(Modem Sender, Modem Receiver, bool Success, string Message)>();
        
        var tasks = transferPairs.Select(async pair =>
        {
            try
            {
                pair.Sender.IsBusy = true;
                pair.Sender.TransferStatus = "جاري التحويل...";
                onSenderStatusUpdate?.Invoke(pair.Sender, "جاري التحويل...");
                
                pair.Receiver.TransferStatus = "في انتظار الاستلام...";
                onReceiverStatusUpdate?.Invoke(pair.Receiver, "في انتظار الاستلام...");
                
                var (success, message) = await ExecuteOrangeCashTransferAsync(
                    pair.Sender.PortName,
                    password,
                    pair.Receiver.PhoneNumber,
                    amount);
                
                pair.Sender.TransferStatus = success ? "تم التحويل ✓" : $"فشل: {message}";
                onSenderStatusUpdate?.Invoke(pair.Sender, pair.Sender.TransferStatus);
                
                if (success)
                {
                    pair.Receiver.TransferStatus = "تم الاستلام ✓";
                    pair.Receiver.ConfirmationMessage = $"تم استلام {amount} ج.م";
                    onReceiverStatusUpdate?.Invoke(pair.Receiver, pair.Receiver.TransferStatus);
                }
                else
                {
                    pair.Receiver.TransferStatus = "لم يتم الاستلام";
                    onReceiverStatusUpdate?.Invoke(pair.Receiver, pair.Receiver.TransferStatus);
                }
                
                return (pair.Sender, pair.Receiver, success, message);
            }
            catch (Exception ex)
            {
                pair.Sender.TransferStatus = $"خطأ: {ex.Message}";
                onSenderStatusUpdate?.Invoke(pair.Sender, pair.Sender.TransferStatus);
                return (pair.Sender, pair.Receiver, false, ex.Message);
            }
            finally
            {
                pair.Sender.IsBusy = false;
            }
        });
        
        var taskResults = await Task.WhenAll(tasks);
        results.AddRange(taskResults);
        
        return results;
    }

    public async Task<string> ReadIncomingSmsAsync(string portName, int timeoutSeconds = 10)
    {
        try
        {
            await SendATCommandAsync(portName, "AT+CMGF=1", 2000);
            await Task.Delay(100);
            
            await SendATCommandAsync(portName, "AT+CNMI=2,1,0,0,0", 2000);
            await Task.Delay(100);
            
            var response = await SendATCommandAsync(portName, "AT+CMGL=\"ALL\"", timeoutSeconds * 1000);
            
            var decoded = DecodeUssdResponse(response);
            
            if (decoded.Contains("تم استلام") || decoded.Contains("received"))
            {
                var match = Regex.Match(decoded, @"(\d+(?:\.\d+)?)\s*(?:جنيه|EGP|ج\.م|LE)");
                if (match.Success)
                {
                    return $"تم استلام {match.Groups[1].Value} ج.م ✓";
                }
            }
            
            return decoded;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{portName}] خطأ في قراءة الرسائل: {ex.Message}");
            return $"خطأ: {ex.Message}";
        }
    }

    public async Task RestartModemAsync(string portName)
    {
        try
        {
            Console.WriteLine($"[{portName}] جاري إعادة تشغيل المودم...");
            
            await SendATCommandAsync(portName, "AT+CFUN=0", 3000);
            await Task.Delay(2000);
            
            await SendATCommandAsync(portName, "AT+CFUN=1", 3000);
            await Task.Delay(3000);
            
            Console.WriteLine($"[{portName}] تم إعادة تشغيل المودم");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[{portName}] خطأ في إعادة تشغيل المودم: {ex.Message}");
            throw;
        }
    }

    public async Task<List<string>> QueryAllOrangeCashBalancesAsync(List<Modem> modems, string password)
    {
        var results = new List<string>();
        
        var tasks = modems.Where(m => m.IsConnected && m.IsSelected).Select(async modem =>
        {
            try
            {
                modem.IsBusy = true;
                modem.CashBalance = "جاري...";
                
                var balance = await GetOrangeCashBalanceAsync(modem.PortName, password);
                modem.CashBalance = balance;
                
                ModemUpdated?.Invoke(this, modem);
                
                return $"{modem.PhoneNumber}: {balance}";
            }
            catch (Exception ex)
            {
                modem.CashBalance = "خطأ";
                return $"{modem.PhoneNumber}: خطأ - {ex.Message}";
            }
            finally
            {
                modem.IsBusy = false;
            }
        });
        
        var taskResults = await Task.WhenAll(tasks);
        results.AddRange(taskResults);
        
        return results;
    }

    #endregion

    public void Dispose()
    {
        StopMonitoring();
        
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
