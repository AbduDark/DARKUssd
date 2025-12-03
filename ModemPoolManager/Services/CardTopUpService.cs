using System.Collections.Concurrent;
using System.Text.RegularExpressions;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class CardTopUpService
{
    private readonly ModemService _modemService;

    private static readonly Dictionary<string, string> OperatorTopUpFormats = new()
    {
        { "vodafone", "*858*{card}#" },
        { "فودافون", "*858*{card}#" },
        { "orange", "*110*{card}#" },
        { "اورنج", "*110*{card}#" },
        { "موبينيل", "*110*{card}#" },
        { "etisalat", "*556*{card}#" },
        { "اتصالات", "*556*{card}#" },
        { "we", "*555*{card}#" },
        { "وي", "*555*{card}#" }
    };

    private static readonly Dictionary<string, string> OperatorTransferFormats = new()
    {
        { "vodafone", "*868*{amount}*{number}#" },
        { "فودافون", "*868*{amount}*{number}#" },
        { "orange", "*100*1*{number}*{amount}#" },
        { "اورنج", "*100*1*{number}*{amount}#" },
        { "etisalat", "*557*{number}*{amount}#" },
        { "اتصالات", "*557*{number}*{amount}#" }
    };

    public CardTopUpService(ModemService modemService)
    {
        _modemService = modemService;
    }

    public string GetTopUpCode(string? operatorName, string cardNumber)
    {
        if (string.IsNullOrEmpty(operatorName))
            return $"*858*{cardNumber}#";

        var opLower = operatorName.ToLowerInvariant();
        foreach (var kvp in OperatorTopUpFormats)
        {
            if (opLower.Contains(kvp.Key))
                return kvp.Value.Replace("{card}", cardNumber);
        }
        return $"*858*{cardNumber}#";
    }

    public string GetTransferCode(string? operatorName, string targetNumber, int amount)
    {
        if (string.IsNullOrEmpty(operatorName))
            return $"*868*{amount}*{targetNumber}#";

        var opLower = operatorName.ToLowerInvariant();
        foreach (var kvp in OperatorTransferFormats)
        {
            if (opLower.Contains(kvp.Key))
                return kvp.Value
                    .Replace("{amount}", amount.ToString())
                    .Replace("{number}", targetNumber);
        }
        return $"*868*{amount}*{targetNumber}#";
    }

    public async Task<CardTopUpResult> TopUpCardAsync(Modem modem, string cardNumber)
    {
        var result = new CardTopUpResult
        {
            PortName = modem.PortName,
            PhoneNumber = modem.PhoneNumber,
            CardNumber = cardNumber
        };

        try
        {
            if (_modemService.IsModemBusy(modem.PortName))
            {
                result.IsSuccess = false;
                result.ErrorMessage = "المودم مشغول - حاول لاحقاً";
                return result;
            }
            
            var topUpCode = GetTopUpCode(modem.Operator, cardNumber);
            var ussdResult = await _modemService.ExecuteUssdAsync(modem, topUpCode);
            
            result.RawResponse = ussdResult.Response;
            result.IsSuccess = IsTopUpSuccessful(ussdResult.Response);
            
            if (result.IsSuccess)
            {
                result.NewBalance = ExtractNewBalance(ussdResult.Response);
                result.ChargedAmount = ExtractChargedAmount(ussdResult.Response);
            }
            else
            {
                result.ErrorMessage = GetTopUpErrorMessage(ussdResult.Response);
            }
        }
        catch (Exception ex)
        {
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
        }

        return result;
    }

    public async Task<List<CardTopUpResult>> TopUpAllCardsAsync(
        List<Modem> modems, 
        List<string> cardNumbers,
        Action<Modem, string>? onStatusUpdate = null,
        Action<Modem, bool>? onBusyStateChanged = null)
    {
        var selectedModems = modems.Where(m => m.IsConnected && m.IsSelected && !m.IsBusy).ToList();
        var results = new ConcurrentBag<CardTopUpResult>();
        
        if (selectedModems.Count == 0 || cardNumbers.Count == 0)
        {
            return new List<CardTopUpResult>();
        }
        
        var cardQueue = new ConcurrentQueue<string>(cardNumbers);
        
        var tasks = selectedModems.Select(async modem =>
        {
            while (cardQueue.TryDequeue(out var cardNumber))
            {
                try
                {
                    onBusyStateChanged?.Invoke(modem, true);
                    onStatusUpdate?.Invoke(modem, $"جاري شحن الكارت: {cardNumber.Substring(0, Math.Min(4, cardNumber.Length))}...");
                    
                    var result = await TopUpCardAsync(modem, cardNumber);
                    
                    var status = result.IsSuccess ? "تم الشحن ✓" : $"فشل: {result.ErrorMessage}";
                    onStatusUpdate?.Invoke(modem, status);
                    
                    results.Add(result);
                    
                    if (!cardQueue.IsEmpty)
                    {
                        await Task.Delay(500);
                    }
                }
                catch (Exception ex)
                {
                    var errorResult = new CardTopUpResult
                    {
                        PortName = modem.PortName,
                        PhoneNumber = modem.PhoneNumber,
                        CardNumber = cardNumber,
                        IsSuccess = false,
                        ErrorMessage = $"خطأ: {ex.Message}"
                    };
                    results.Add(errorResult);
                    onStatusUpdate?.Invoke(modem, $"خطأ: {ex.Message}");
                }
                finally
                {
                    onBusyStateChanged?.Invoke(modem, false);
                }
            }
        });

        await Task.WhenAll(tasks);
        
        return results.ToList();
    }

    public async Task<TransferResult> TransferBalanceAsync(Modem sourceModem, string targetNumber, int amount)
    {
        var result = new TransferResult
        {
            SourcePort = sourceModem.PortName,
            SourceNumber = sourceModem.PhoneNumber,
            TargetNumber = targetNumber,
            Amount = amount
        };

        try
        {
            var transferCode = GetTransferCode(sourceModem.Operator, targetNumber, amount);
            var ussdResult = await _modemService.ExecuteUssdAsync(sourceModem, transferCode);
            
            result.RawResponse = ussdResult.Response;
            result.IsSuccess = IsTransferSuccessful(ussdResult.Response);
            
            if (!result.IsSuccess)
            {
                result.ErrorMessage = GetTransferErrorMessage(ussdResult.Response);
            }
        }
        catch (Exception ex)
        {
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
        }

        return result;
    }

    private bool IsTopUpSuccessful(string response)
    {
        var successPatterns = new[]
        {
            "تم الشحن",
            "تم شحن",
            "Successfully",
            "Recharged",
            "رصيدك الجديد",
            "New balance",
            "مبروك"
        };

        return successPatterns.Any(p => response.Contains(p, StringComparison.OrdinalIgnoreCase));
    }

    private bool IsTransferSuccessful(string response)
    {
        var successPatterns = new[]
        {
            "تم التحويل",
            "Successfully",
            "Transfer completed",
            "تم شحن",
            "تم ارسال"
        };

        return successPatterns.Any(p => response.Contains(p, StringComparison.OrdinalIgnoreCase));
    }

    private string ExtractNewBalance(string response)
    {
        var match = Regex.Match(response, @"رصيد[^:]*[:\s]*(\d+(?:\.\d+)?)", RegexOptions.IgnoreCase);
        if (match.Success)
            return match.Groups[1].Value + " ج.م";
            
        match = Regex.Match(response, @"balance[^:]*[:\s]*(\d+(?:\.\d+)?)", RegexOptions.IgnoreCase);
        if (match.Success)
            return match.Groups[1].Value + " ج.م";

        return "";
    }

    private string ExtractChargedAmount(string response)
    {
        var match = Regex.Match(response, @"(\d+)\s*(?:جنيه|EGP|ج\.م)", RegexOptions.IgnoreCase);
        return match.Success ? match.Groups[1].Value + " ج.م" : "";
    }

    private string GetTopUpErrorMessage(string response)
    {
        if (response.Contains("خاطئ") || response.Contains("invalid") || response.Contains("wrong"))
            return "رقم الكارت خاطئ";
        if (response.Contains("مستخدم") || response.Contains("used") || response.Contains("already"))
            return "الكارت مستخدم مسبقاً";
        if (response.Contains("منتهي") || response.Contains("expired"))
            return "الكارت منتهي الصلاحية";
        if (response.Contains("غير صالح") || response.Contains("not valid"))
            return "الكارت غير صالح";
            
        return "فشل في الشحن";
    }

    private string GetTransferErrorMessage(string response)
    {
        if (response.Contains("غير كاف") || response.Contains("insufficient"))
            return "الرصيد غير كافي";
        if (response.Contains("خاطئ") || response.Contains("invalid"))
            return "رقم خاطئ";
        if (response.Contains("محظور") || response.Contains("blocked"))
            return "الخط محظور";
            
        return "فشل في التحويل";
    }
}

public class CardTopUpResult
{
    public string PortName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string CardNumber { get; set; } = "";
    public string NewBalance { get; set; } = "";
    public string ChargedAmount { get; set; } = "";
    public string RawResponse { get; set; } = "";
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
}

public class TransferResult
{
    public string SourcePort { get; set; } = "";
    public string SourceNumber { get; set; } = "";
    public string TargetNumber { get; set; } = "";
    public int Amount { get; set; }
    public string RawResponse { get; set; } = "";
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
}
