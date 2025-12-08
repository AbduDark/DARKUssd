using System.Text;
using System.Text.RegularExpressions;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class SmsService
{
    private readonly ModemService _modemService;

    public SmsService(ModemService modemService)
    {
        _modemService = modemService;
    }

    public async Task<bool> SetTextModeAsync(string portName)
    {
        var response = await _modemService.SendATCommandPublicAsync(portName, "AT+CMGF=1", 3000);
        return response.Contains("OK");
    }

    public async Task<bool> SetPduModeAsync(string portName)
    {
        var response = await _modemService.SendATCommandPublicAsync(portName, "AT+CMGF=0", 3000);
        return response.Contains("OK");
    }

    public async Task<bool> SetCharacterSetAsync(string portName, string charset = "GSM")
    {
        var response = await _modemService.SendATCommandPublicAsync(portName, $"AT+CSCS=\"{charset}\"", 3000);
        return response.Contains("OK");
    }

    public async Task<List<SmsMessage>> GetAllMessagesAsync(string portName, int modemIndex)
    {
        var messages = new List<SmsMessage>();

        try
        {
            await SetTextModeAsync(portName);
            await SetCharacterSetAsync(portName, "UCS2");

            var response = await _modemService.SendATCommandPublicAsync(portName, "AT+CMGL=\"ALL\"", 10000);

            var patterns = new[]
            {
                @"\+CMGL:\s*(\d+),""([^""]*)"",""([^""]*)"",""([^""]*)"",""([^""]*)""[\r\n]+(.+?)(?=\+CMGL:|OK|$)",
                @"\+CMGL:\s*(\d+),""([^""]*)"",""([^""]*)"","""",""([^""]*)""[\r\n]+(.+?)(?=\+CMGL:|OK|$)",
                @"\+CMGL:\s*(\d+),""([^""]*)"",""([^""]*)""[^\r\n]*[\r\n]+(.+?)(?=\+CMGL:|OK|$)"
            };

            foreach (var pattern in patterns)
            {
                var matches = Regex.Matches(response, pattern, RegexOptions.Singleline);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        try
                        {
                            var sms = new SmsMessage
                            {
                                Index = int.Parse(match.Groups[1].Value),
                                ModemPort = portName,
                                ModemIndex = modemIndex,
                                Direction = SmsDirection.Incoming
                            };

                            var statusStr = match.Groups[2].Value;
                            sms.Status = statusStr switch
                            {
                                "REC UNREAD" => SmsStatus.Unread,
                                "REC READ" => SmsStatus.Read,
                                "STO UNSENT" => SmsStatus.Unsent,
                                "STO SENT" => SmsStatus.Sent,
                                _ => SmsStatus.Read
                            };

                            sms.PhoneNumber = DecodeIfUcs2(match.Groups[3].Value);
                            
                            if (match.Groups.Count >= 7)
                            {
                                sms.Timestamp = ParseSmsTimestamp(match.Groups[5].Value);
                                sms.Message = DecodeIfUcs2(match.Groups[6].Value.Trim());
                            }
                            else if (match.Groups.Count >= 6)
                            {
                                sms.Timestamp = ParseSmsTimestamp(match.Groups[4].Value);
                                sms.Message = DecodeIfUcs2(match.Groups[5].Value.Trim());
                            }
                            else
                            {
                                sms.Timestamp = DateTime.Now;
                                sms.Message = DecodeIfUcs2(match.Groups[match.Groups.Count - 1].Value.Trim());
                            }

                            messages.Add(sms);
                        }
                        catch { }
                    }
                    break;
                }
            }
        }
        catch { }

        return messages;
    }

    private string DecodeIfUcs2(string text)
    {
        if (string.IsNullOrEmpty(text)) return text;
        
        if (Regex.IsMatch(text, @"^[0-9A-Fa-f]+$") && text.Length >= 4 && text.Length % 4 == 0)
        {
            try
            {
                var bytes = new byte[text.Length / 2];
                for (int i = 0; i < text.Length; i += 2)
                {
                    bytes[i / 2] = Convert.ToByte(text.Substring(i, 2), 16);
                }
                return Encoding.BigEndianUnicode.GetString(bytes);
            }
            catch { }
        }
        return text;
    }

    public async Task<List<SmsMessage>> GetUnreadMessagesAsync(string portName, int modemIndex)
    {
        var messages = new List<SmsMessage>();

        try
        {
            await SetTextModeAsync(portName);
            await SetCharacterSetAsync(portName);

            var response = await _modemService.SendATCommandPublicAsync(portName, "AT+CMGL=\"REC UNREAD\"", 10000);

            var pattern = @"\+CMGL:\s*(\d+),""REC UNREAD"",""([^""]*)"","""",""([^""]*)""[\r\n]+(.+?)(?=\+CMGL:|OK|$)";
            var matches = Regex.Matches(response, pattern, RegexOptions.Singleline);

            foreach (Match match in matches)
            {
                var sms = new SmsMessage
                {
                    Index = int.Parse(match.Groups[1].Value),
                    PhoneNumber = match.Groups[2].Value,
                    Message = match.Groups[4].Value.Trim(),
                    ModemPort = portName,
                    ModemIndex = modemIndex,
                    Timestamp = ParseSmsTimestamp(match.Groups[3].Value),
                    Status = SmsStatus.Unread,
                    Direction = SmsDirection.Incoming
                };

                messages.Add(sms);
            }
        }
        catch { }

        return messages;
    }

    public async Task<int> GetUnreadCountAsync(string portName)
    {
        try
        {
            await SetTextModeAsync(portName);
            var response = await _modemService.SendATCommandPublicAsync(portName, "AT+CMGL=\"REC UNREAD\"", 10000);
            return Regex.Matches(response, @"\+CMGL:").Count;
        }
        catch
        {
            return 0;
        }
    }

    public async Task<(bool Success, string Error)> SendSmsAsync(string portName, string phoneNumber, string message)
    {
        try
        {
            await SetTextModeAsync(portName);
            await SetCharacterSetAsync(portName);

            var response = await _modemService.SendATCommandPublicAsync(portName, $"AT+CMGS=\"{phoneNumber}\"", 5000);
            
            if (response.Contains(">"))
            {
                response = await _modemService.SendATCommandPublicAsync(portName, message + "\x1A", 30000);
                
                if (response.Contains("+CMGS:") || response.Contains("OK"))
                {
                    return (true, string.Empty);
                }
                else if (response.Contains("ERROR"))
                {
                    return (false, "فشل في إرسال الرسالة");
                }
            }

            return (false, "لم يستجب المودم");
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public async Task<(bool Success, string Error)> DeleteSmsAsync(string portName, int index)
    {
        try
        {
            var response = await _modemService.SendATCommandPublicAsync(portName, $"AT+CMGD={index}", 5000);
            return (response.Contains("OK"), response.Contains("ERROR") ? "فشل في حذف الرسالة" : string.Empty);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public async Task<(bool Success, string Error)> DeleteAllSmsAsync(string portName)
    {
        try
        {
            var response = await _modemService.SendATCommandPublicAsync(portName, "AT+CMGD=1,4", 10000);
            return (response.Contains("OK"), response.Contains("ERROR") ? "فشل في حذف الرسائل" : string.Empty);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    public async Task<SmsMessage?> ReadSmsAsync(string portName, int index, int modemIndex)
    {
        try
        {
            await SetTextModeAsync(portName);
            await SetCharacterSetAsync(portName);

            var response = await _modemService.SendATCommandPublicAsync(portName, $"AT+CMGR={index}", 5000);

            var pattern = @"\+CMGR:\s*""([^""]*)"",""([^""]*)"","""",""([^""]*)""[\r\n]+(.+?)(?=OK|ERROR|$)";
            var match = Regex.Match(response, pattern, RegexOptions.Singleline);

            if (match.Success)
            {
                return new SmsMessage
                {
                    Index = index,
                    PhoneNumber = match.Groups[2].Value,
                    Message = match.Groups[4].Value.Trim(),
                    ModemPort = portName,
                    ModemIndex = modemIndex,
                    Timestamp = ParseSmsTimestamp(match.Groups[3].Value),
                    Status = match.Groups[1].Value == "REC UNREAD" ? SmsStatus.Unread : SmsStatus.Read,
                    Direction = SmsDirection.Incoming
                };
            }
        }
        catch { }

        return null;
    }

    public async Task<string> GetSmscAsync(string portName)
    {
        try
        {
            var response = await _modemService.SendATCommandPublicAsync(portName, "AT+CSCA?", 3000);
            var match = Regex.Match(response, @"\+CSCA:\s*""([^""]+)""");
            return match.Success ? match.Groups[1].Value : string.Empty;
        }
        catch
        {
            return string.Empty;
        }
    }

    public async Task<(bool Success, string Error)> SetSmscAsync(string portName, string smsc)
    {
        try
        {
            var response = await _modemService.SendATCommandPublicAsync(portName, $"AT+CSCA=\"{smsc}\"", 3000);
            return (response.Contains("OK"), response.Contains("ERROR") ? "فشل في تعيين مركز الرسائل" : string.Empty);
        }
        catch (Exception ex)
        {
            return (false, ex.Message);
        }
    }

    private DateTime ParseSmsTimestamp(string timestamp)
    {
        try
        {
            var pattern = @"(\d{2})/(\d{2})/(\d{2}),(\d{2}):(\d{2}):(\d{2})";
            var match = Regex.Match(timestamp, pattern);
            
            if (match.Success)
            {
                int year = 2000 + int.Parse(match.Groups[1].Value);
                int month = int.Parse(match.Groups[2].Value);
                int day = int.Parse(match.Groups[3].Value);
                int hour = int.Parse(match.Groups[4].Value);
                int minute = int.Parse(match.Groups[5].Value);
                int second = int.Parse(match.Groups[6].Value);

                return new DateTime(year, month, day, hour, minute, second);
            }
        }
        catch { }

        return DateTime.Now;
    }
}
