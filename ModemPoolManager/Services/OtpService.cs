using System.Text.RegularExpressions;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class OtpService
{
    private readonly ModemService _modemService;
    private readonly SmsService _smsService;

    public OtpService(ModemService modemService, SmsService smsService)
    {
        _modemService = modemService;
        _smsService = smsService;
    }

    public async Task<OtpResult> GenerateVodafoneOtpAsync(string portName, int modemIndex, string phoneNumber, int amount, string pin)
    {
        var result = new OtpResult
        {
            PortName = portName,
            ModemIndex = modemIndex,
            PhoneNumber = phoneNumber,
            Amount = amount,
            OperatorName = "Vodafone"
        };

        try
        {
            var ussdResult = await _modemService.SendUssdAndGetFullResponseAsync(portName, "*9*22#", 30000);
            if (!ussdResult.isSuccess)
            {
                result.ErrorMessage = $"فشل في تنفيذ الأمر الأول: {ussdResult.response}";
                return result;
            }

            await Task.Delay(1000);
            var replyResult1 = await _modemService.SendUssdReplyAsync(portName, amount.ToString());
            if (!replyResult1.isSuccess)
            {
                result.ErrorMessage = $"فشل في إدخال المبلغ: {replyResult1.response}";
                return result;
            }

            await Task.Delay(1000);
            var replyResult2 = await _modemService.SendUssdReplyAsync(portName, pin);
            if (!replyResult2.isSuccess)
            {
                result.ErrorMessage = $"فشل في إدخال الرقم السري: {replyResult2.response}";
                return result;
            }

            var otpMatch = Regex.Match(replyResult2.response, @"الرقم السري المتغير هو[:\s]*(\d{4,8})", RegexOptions.RightToLeft);
            if (!otpMatch.Success)
            {
                otpMatch = Regex.Match(replyResult2.response, @"OTP[:\s]*(\d{4,8})", RegexOptions.IgnoreCase);
            }
            if (!otpMatch.Success)
            {
                otpMatch = Regex.Match(replyResult2.response, @"(\d{6})", RegexOptions.IgnoreCase);
            }

            if (otpMatch.Success)
            {
                result.OtpCode = otpMatch.Groups[1].Value;
                result.IsSuccess = true;
                result.RawResponse = replyResult2.response;
                result.StartCountdown();
            }
            else
            {
                result.ErrorMessage = "لم يتم العثور على OTP في الرد";
                result.RawResponse = replyResult2.response;
            }
        }
        catch (Exception ex)
        {
            result.ErrorMessage = ex.Message;
        }

        return result;
    }

    public async Task<OtpResult> GenerateOrangeOtpAsync(string portName, int modemIndex, string phoneNumber, int amount, string pin)
    {
        var result = new OtpResult
        {
            PortName = portName,
            ModemIndex = modemIndex,
            PhoneNumber = phoneNumber,
            Amount = amount,
            OperatorName = "Orange"
        };

        try
        {
            var ussdResult = await _modemService.SendUssdAndGetFullResponseAsync(portName, "#7115#", 30000);
            if (!ussdResult.isSuccess)
            {
                result.ErrorMessage = $"فشل في تنفيذ الأمر الأول: {ussdResult.response}";
                return result;
            }

            await Task.Delay(1000);
            var pinReply = $"121{pin}";
            var replyResult1 = await _modemService.SendUssdReplyAsync(portName, pinReply);
            if (!replyResult1.isSuccess)
            {
                result.ErrorMessage = $"فشل في إدخال الرقم السري: {replyResult1.response}";
                return result;
            }

            await Task.Delay(1000);
            var replyResult2 = await _modemService.SendUssdReplyAsync(portName, amount.ToString());
            if (!replyResult2.isSuccess)
            {
                result.ErrorMessage = $"فشل في إدخال المبلغ: {replyResult2.response}";
                return result;
            }

            await Task.Delay(1000);
            var replyResult3 = await _modemService.SendUssdReplyAsync(portName, "1");
            if (!replyResult3.isSuccess)
            {
                result.ErrorMessage = $"فشل في التأكيد: {replyResult3.response}";
                return result;
            }

            result.RawResponse = replyResult3.response;

            await Task.Delay(3000);
            var messages = await _smsService.GetUnreadMessagesAsync(portName, modemIndex);
            
            foreach (var msg in messages.OrderByDescending(m => m.Timestamp))
            {
                var otpMatch = Regex.Match(msg.Message, @"(\d{6})", RegexOptions.IgnoreCase);
                if (otpMatch.Success)
                {
                    result.OtpCode = otpMatch.Groups[1].Value;
                    result.IsSuccess = true;
                    result.RawResponse = msg.Message;
                    result.StartCountdown();
                    break;
                }
            }

            if (!result.IsSuccess)
            {
                result.ErrorMessage = "لم يتم استلام OTP في الرسائل";
            }
        }
        catch (Exception ex)
        {
            result.ErrorMessage = ex.Message;
        }

        return result;
    }

    public async Task<OtpResult> GenerateEtisalatOtpAsync(string portName, int modemIndex, string phoneNumber, int amount, string pin)
    {
        var result = new OtpResult
        {
            PortName = portName,
            ModemIndex = modemIndex,
            PhoneNumber = phoneNumber,
            Amount = amount,
            OperatorName = "Etisalat"
        };

        try
        {
            var ussdCode = $"*777*3*2*{pin}*{amount}#";
            var ussdResult = await _modemService.SendUssdAndGetFullResponseAsync(portName, ussdCode, 30000);
            
            result.RawResponse = ussdResult.response;

            await Task.Delay(3000);
            var messages = await _smsService.GetUnreadMessagesAsync(portName, modemIndex);
            
            foreach (var msg in messages.OrderByDescending(m => m.Timestamp))
            {
                var otpMatch = Regex.Match(msg.Message, @"(\d{6})", RegexOptions.IgnoreCase);
                if (otpMatch.Success)
                {
                    result.OtpCode = otpMatch.Groups[1].Value;
                    result.IsSuccess = true;
                    result.RawResponse = msg.Message;
                    result.StartCountdown();
                    break;
                }
            }

            if (!result.IsSuccess)
            {
                result.ErrorMessage = "لم يتم استلام OTP في الرسائل";
            }
        }
        catch (Exception ex)
        {
            result.ErrorMessage = ex.Message;
        }

        return result;
    }

    public async Task<OtpResult> GenerateOtpAsync(Modem modem, int amount, string pin)
    {
        var operatorName = modem.Operator?.ToLower() ?? "";

        if (operatorName.Contains("vodafone") || operatorName.Contains("فودافون"))
        {
            return await GenerateVodafoneOtpAsync(modem.PortName, modem.Index, modem.PhoneNumber ?? "", amount, pin);
        }
        else if (operatorName.Contains("orange") || operatorName.Contains("أورانج") || operatorName.Contains("اورانج"))
        {
            return await GenerateOrangeOtpAsync(modem.PortName, modem.Index, modem.PhoneNumber ?? "", amount, pin);
        }
        else if (operatorName.Contains("etisalat") || operatorName.Contains("اتصالات"))
        {
            return await GenerateEtisalatOtpAsync(modem.PortName, modem.Index, modem.PhoneNumber ?? "", amount, pin);
        }
        else
        {
            return new OtpResult
            {
                PortName = modem.PortName,
                ModemIndex = modem.Index,
                PhoneNumber = modem.PhoneNumber ?? "",
                Amount = amount,
                OperatorName = modem.Operator ?? "Unknown",
                ErrorMessage = $"شبكة غير مدعومة: {modem.Operator}"
            };
        }
    }
}
