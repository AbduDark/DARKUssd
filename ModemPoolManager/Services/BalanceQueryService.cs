using System.Text.RegularExpressions;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class BalanceQueryService
{
    private readonly ModemService _modemService;

    private static readonly Dictionary<string, string> OperatorBalanceCodes = new()
    {
        { "vodafone", "*868#" },
        { "فودافون", "*868#" },
        { "orange", "*100#" },
        { "اورنج", "*100#" },
        { "موبينيل", "*100#" },
        { "etisalat", "*102#" },
        { "اتصالات", "*102#" },
        { "we", "*550#" },
        { "وي", "*550#" },
        { "المصرية", "*550#" }
    };

    public BalanceQueryService(ModemService modemService)
    {
        _modemService = modemService;
    }

    public string GetBalanceCode(string? operatorName)
    {
        if (string.IsNullOrEmpty(operatorName))
            return "*868#";

        var opLower = operatorName.ToLowerInvariant();
        foreach (var kvp in OperatorBalanceCodes)
        {
            if (opLower.Contains(kvp.Key))
                return kvp.Value;
        }
        return "*868#";
    }

    public async Task<BalanceResult> QueryBalanceAsync(Modem modem)
    {
        var result = new BalanceResult
        {
            PortName = modem.PortName,
            PhoneNumber = modem.PhoneNumber,
            Operator = modem.Operator ?? "غير معروف"
        };

        try
        {
            var balanceCode = GetBalanceCode(modem.Operator);
            var ussdResult = await _modemService.ExecuteUssdAsync(modem, balanceCode);
            
            result.RawResponse = ussdResult.Response;
            result.IsSuccess = ussdResult.IsSuccess;

            if (ussdResult.IsSuccess)
            {
                result.MainBalance = ExtractMainBalance(ussdResult.Response, modem.Operator);
                result.BonusBalance = ExtractBonusBalance(ussdResult.Response);
                result.DataBalance = ExtractDataBalance(ussdResult.Response);
                result.ExpiryDate = ExtractExpiryDate(ussdResult.Response);
            }
            else
            {
                result.ErrorMessage = ussdResult.ErrorMessage ?? "فشل في استعلام الرصيد";
            }
        }
        catch (Exception ex)
        {
            result.IsSuccess = false;
            result.ErrorMessage = ex.Message;
        }

        return result;
    }

    public async Task<List<BalanceResult>> QueryAllBalancesAsync(List<Modem> modems, Action<Modem, string>? onStatusUpdate = null)
    {
        var selectedModems = modems.Where(m => m.IsConnected && m.IsSelected).ToList();
        
        var tasks = selectedModems.Select(async modem =>
        {
            try
            {
                modem.IsBusy = true;
                onStatusUpdate?.Invoke(modem, "جاري الاستعلام...");
                
                var result = await QueryBalanceAsync(modem);
                
                modem.Balance = result.IsSuccess ? result.MainBalance : "خطأ";
                modem.Status = result.IsSuccess ? "تم الاستعلام" : "فشل";
                onStatusUpdate?.Invoke(modem, modem.Status);
                
                return result;
            }
            catch (Exception ex)
            {
                return new BalanceResult
                {
                    PortName = modem.PortName,
                    PhoneNumber = modem.PhoneNumber,
                    IsSuccess = false,
                    ErrorMessage = ex.Message
                };
            }
            finally
            {
                modem.IsBusy = false;
            }
        });

        var results = await Task.WhenAll(tasks);
        return results.ToList();
    }

    public async Task<GroupBalanceResult> QueryGroupBalancesAsync(List<Modem> modems, string operatorFilter = "all")
    {
        var result = new GroupBalanceResult();
        
        var filteredModems = modems.Where(m => m.IsConnected && m.IsSelected);
        
        if (operatorFilter != "all")
        {
            filteredModems = filteredModems.Where(m => 
                m.Operator?.ToLowerInvariant().Contains(operatorFilter.ToLowerInvariant()) == true);
        }
        
        var balances = await QueryAllBalancesAsync(filteredModems.ToList());
        
        result.BalanceResults = balances;
        result.TotalModems = balances.Count;
        result.SuccessfulQueries = balances.Count(b => b.IsSuccess);
        result.FailedQueries = balances.Count(b => !b.IsSuccess);
        
        foreach (var balance in balances.Where(b => b.IsSuccess))
        {
            if (decimal.TryParse(Regex.Replace(balance.MainBalance, @"[^\d.]", ""), out var amount))
            {
                result.TotalBalance += amount;
            }
        }
        
        result.AverageBalance = result.SuccessfulQueries > 0 
            ? result.TotalBalance / result.SuccessfulQueries 
            : 0;

        return result;
    }

    private string ExtractMainBalance(string response, string? operatorName)
    {
        var patterns = new[]
        {
            @"(\d+(?:\.\d+)?)\s*(?:جنيه|EGP|ج\.م|LE|جنية)",
            @"رصيدك[:\s]*(\d+(?:\.\d+)?)",
            @"balance[:\s]*(\d+(?:\.\d+)?)",
            @"Main[:\s]*(\d+(?:\.\d+)?)",
            @"Credit[:\s]*(\d+(?:\.\d+)?)",
            @"(\d+(?:\.\d+)?)\s*ج"
        };

        foreach (var pattern in patterns)
        {
            var match = Regex.Match(response, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value + " ج.م";
            }
        }

        return "غير متاح";
    }

    private string ExtractBonusBalance(string response)
    {
        var patterns = new[]
        {
            @"بونص[:\s]*(\d+(?:\.\d+)?)",
            @"Bonus[:\s]*(\d+(?:\.\d+)?)",
            @"فلكسات[:\s]*(\d+)",
            @"Flex[:\s]*(\d+)"
        };

        foreach (var pattern in patterns)
        {
            var match = Regex.Match(response, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
        }

        return "";
    }

    private string ExtractDataBalance(string response)
    {
        var patterns = new[]
        {
            @"(\d+(?:\.\d+)?)\s*(?:GB|MB|جيجا|ميجا)",
            @"Data[:\s]*(\d+(?:\.\d+)?)\s*(?:GB|MB)",
            @"نت[:\s]*(\d+(?:\.\d+)?)"
        };

        foreach (var pattern in patterns)
        {
            var match = Regex.Match(response, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Value;
            }
        }

        return "";
    }

    private string ExtractExpiryDate(string response)
    {
        var patterns = new[]
        {
            @"(\d{1,2}/\d{1,2}/\d{2,4})",
            @"(\d{1,2}-\d{1,2}-\d{2,4})",
            @"تنتهي[:\s]*(.+?)(?:\n|$)",
            @"expires?[:\s]*(.+?)(?:\n|$)"
        };

        foreach (var pattern in patterns)
        {
            var match = Regex.Match(response, pattern, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                return match.Groups[1].Value.Trim();
            }
        }

        return "";
    }
}

public class BalanceResult
{
    public string PortName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string Operator { get; set; } = "";
    public string MainBalance { get; set; } = "";
    public string BonusBalance { get; set; } = "";
    public string DataBalance { get; set; } = "";
    public string ExpiryDate { get; set; } = "";
    public string RawResponse { get; set; } = "";
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
}

public class GroupBalanceResult
{
    public List<BalanceResult> BalanceResults { get; set; } = new();
    public int TotalModems { get; set; }
    public int SuccessfulQueries { get; set; }
    public int FailedQueries { get; set; }
    public decimal TotalBalance { get; set; }
    public decimal AverageBalance { get; set; }
}
