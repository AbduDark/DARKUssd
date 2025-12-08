using System.Text.RegularExpressions;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ModemPoolManager.Models;

public partial class SmsMessage : ObservableObject
{
    [ObservableProperty]
    private int _index;

    [ObservableProperty]
    private string _phoneNumber = string.Empty;

    [ObservableProperty]
    private string _message = string.Empty;

    [ObservableProperty]
    private DateTime _timestamp;

    [ObservableProperty]
    private SmsStatus _status;

    [ObservableProperty]
    private SmsDirection _direction;

    [ObservableProperty]
    private string _modemPort = string.Empty;

    [ObservableProperty]
    private int _modemIndex;

    [ObservableProperty]
    private string _modemPhoneNumber = "رقم غير محدد";

    public string ExtractedOtp => ExtractOtp(Message);

    public bool HasOtp => !string.IsNullOrEmpty(ExtractedOtp);

    public string MessageWithoutOtp => HasOtp ? RemoveOtpFromMessage(Message, ExtractedOtp) : Message;

    private static string ExtractOtp(string message)
    {
        if (string.IsNullOrEmpty(message)) return string.Empty;

        var patterns = new[]
        {
            @"\b(\d{4,8})\b(?=\s*(?:is\s+your|هو\s+رمز|كود|code|otp|رمز|pin|password|verification|التحقق|التأكيد))",
            @"(?:otp|code|رمز|كود|pin|verification|التحقق|password|الرمز|التأكيد)[:\s]*(\d{4,8})\b",
            @"(?:is|هو|:)\s*(\d{4,8})\b",
            @"\b(\d{4,6})\b(?=.*(?:verify|confirm|تأكيد|تحقق|activation|تفعيل))",
            @"(?:verify|confirm|تأكيد|تحقق|activation|تفعيل).*\b(\d{4,6})\b",
            @"(?:your\s+)?(?:otp|code|pin|رمز|كود)\s*(?:is|:)?\s*(\d{4,8})",
            @"(\d{4,8})\s*(?:otp|code|pin|رمز|كود)",
            @"(?:send|enter|use|أدخل|استخدم)\s*(\d{4,6})\b",
            @"\b(\d{6})\b",
            @"\b(\d{4})\b(?![\d])"
        };

        foreach (var pattern in patterns)
        {
            var match = Regex.Match(message, pattern, RegexOptions.IgnoreCase);
            if (match.Success && match.Groups.Count > 1)
            {
                var otp = match.Groups[1].Value;
                if (otp.Length >= 4 && otp.Length <= 8)
                {
                    if (!IsExcludedNumber(otp, message))
                    {
                        return otp;
                    }
                }
            }
        }

        return string.Empty;
    }

    private static bool IsExcludedNumber(string number, string message)
    {
        if (number.StartsWith("20") && (number.Length == 11 || number.Length == 12))
            return true;

        if (number.StartsWith("01") && number.Length >= 10)
            return true;

        if (message.Contains(number) && (message.Contains("رقم الهاتف") || message.Contains("phone")))
            return true;

        var yearPatterns = new[] { "2024", "2025", "2023" };
        if (yearPatterns.Contains(number))
            return true;

        return false;
    }

    private static string RemoveOtpFromMessage(string message, string otp)
    {
        if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(otp))
            return message;

        return message.Replace(otp, "").Trim();
    }

    partial void OnMessageChanged(string value)
    {
        OnPropertyChanged(nameof(ExtractedOtp));
        OnPropertyChanged(nameof(HasOtp));
        OnPropertyChanged(nameof(MessageWithoutOtp));
    }
}

public enum SmsStatus
{
    Unread,
    Read,
    Sent,
    Unsent,
    Failed
}

public enum SmsDirection
{
    Incoming,
    Outgoing
}
