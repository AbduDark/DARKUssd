using System.Text.RegularExpressions;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class OperatorServicesManager
{
    private readonly ModemService _modemService;

    public OperatorServicesManager(ModemService modemService)
    {
        _modemService = modemService;
    }

    #region Vodafone Services

    public static class VodafoneCodes
    {
        public const string Balance = "*868#";
        public const string PhoneNumber = "*878#";
        public const string InternetBundle = "*2828#";
        public const string CallBundle = "*858#";
        public const string FlexBalance = "*9000#";
        public const string VodafoneCash = "*9*0#";
        public const string DataRemaining = "*460#";
        public const string SubscribeData = "*880*{mb}#";
        public const string UnsubscribeData = "*880*0#";
        public const string TransferBalance = "*868*{amount}*{number}#";
        public const string VodafonePower = "*225#";
        public const string VodafoneMaster = "*6868#";
        public const string MyNumber = "*878#";
        public const string StopPromo = "*800*0#";
        public const string ActivateLine = "*123#";
        public const string DeactivateLine = "*124#";
    }

    public async Task<UssdResult> GetVodafoneFlexBalanceAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, VodafoneCodes.FlexBalance);
    }

    public async Task<UssdResult> GetVodafoneDataRemainingAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, VodafoneCodes.DataRemaining);
    }

    public async Task<UssdResult> SubscribeVodafoneDataAsync(Modem modem, int megabytes)
    {
        var code = VodafoneCodes.SubscribeData.Replace("{mb}", megabytes.ToString());
        return await _modemService.ExecuteUssdAsync(modem, code);
    }

    public async Task<UssdResult> StopVodafonePromoAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, VodafoneCodes.StopPromo);
    }

    public async Task<UssdResult> TransferVodafoneBalanceAsync(Modem modem, string targetNumber, int amount)
    {
        var code = VodafoneCodes.TransferBalance
            .Replace("{amount}", amount.ToString())
            .Replace("{number}", targetNumber);
        return await _modemService.ExecuteUssdAsync(modem, code);
    }

    public async Task<UssdResult> GetVodafonePowerMenuAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, VodafoneCodes.VodafonePower);
    }

    public async Task<UssdResult> GetVodafoneMasterMenuAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, VodafoneCodes.VodafoneMaster);
    }

    #endregion

    #region Orange Services

    public static class OrangeCodes
    {
        public const string Balance = "*100#";
        public const string PhoneNumber = "#119*1#";
        public const string InternetBundle = "*111#";
        public const string OrangeCash = "#7115#";
        public const string OrangeCashBalance = "#7115*81*{pin}#";
        public const string OrangeCashTransfer = "#7115*1*1*{number}*{amount}*{pin}#";
        public const string TransferBalance = "*100*1*{number}*{amount}#";
        public const string DataRemaining = "*100*1*2#";
        public const string StopPromo = "*100*5*0#";
        public const string BuyBundle = "*100*1*1*{bundle}#";
    }

    public async Task<UssdResult> GetOrangeInternetMenuAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, OrangeCodes.InternetBundle);
    }

    public async Task<UssdResult> GetOrangeDataRemainingAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, OrangeCodes.DataRemaining);
    }

    public async Task<UssdResult> TransferOrangeBalanceAsync(Modem modem, string targetNumber, int amount)
    {
        var code = OrangeCodes.TransferBalance
            .Replace("{amount}", amount.ToString())
            .Replace("{number}", targetNumber);
        return await _modemService.ExecuteUssdAsync(modem, code);
    }

    public async Task<UssdResult> GetOrangeCashMenuAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, OrangeCodes.OrangeCash);
    }

    public async Task<string> GetOrangeCashBalanceAsync(Modem modem, string pin)
    {
        return await _modemService.GetOrangeCashBalanceAsync(modem.PortName, pin);
    }

    public async Task<(bool Success, string Message, string RawResponse)> TransferOrangeCashAsync(
        Modem modem, string pin, string targetNumber, int amount)
    {
        return await _modemService.ExecuteOrangeCashTransferAsync(modem.PortName, pin, targetNumber, amount);
    }

    #endregion

    #region Etisalat Services

    public static class EtisalatCodes
    {
        public const string Balance = "*102#";
        public const string PhoneNumber = "*947#";
        public const string InternetBundle = "*566#";
        public const string CallBundle = "*515#";
        public const string DataRemaining = "*102*1#";
        public const string TransferBalance = "*557*{number}*{amount}#";
        public const string StopPromo = "*505*0#";
        public const string TopUp = "*556*{card}#";
    }

    public async Task<UssdResult> GetEtisalatInternetMenuAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, EtisalatCodes.InternetBundle);
    }

    public async Task<UssdResult> GetEtisalatCallBundleMenuAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, EtisalatCodes.CallBundle);
    }

    public async Task<UssdResult> GetEtisalatDataRemainingAsync(Modem modem)
    {
        return await _modemService.ExecuteUssdAsync(modem, EtisalatCodes.DataRemaining);
    }

    public async Task<UssdResult> TransferEtisalatBalanceAsync(Modem modem, string targetNumber, int amount)
    {
        var code = EtisalatCodes.TransferBalance
            .Replace("{amount}", amount.ToString())
            .Replace("{number}", targetNumber);
        return await _modemService.ExecuteUssdAsync(modem, code);
    }

    #endregion

    #region Common Operations

    public async Task<List<UssdResult>> ExecuteOnAllAsync(List<Modem> modems, string ussdCode)
    {
        var selectedModems = modems.Where(m => m.IsConnected && m.IsSelected).ToList();
        return await _modemService.ExecuteUssdOnAllAsync(selectedModems, ussdCode);
    }

    public async Task<List<UssdResult>> StopAllPromosAsync(List<Modem> modems)
    {
        var results = new List<UssdResult>();
        var selectedModems = modems.Where(m => m.IsConnected && m.IsSelected).ToList();

        var tasks = selectedModems.Select(async modem =>
        {
            var code = GetStopPromoCode(modem.Operator);
            return await _modemService.ExecuteUssdAsync(modem, code);
        });

        var taskResults = await Task.WhenAll(tasks);
        results.AddRange(taskResults);
        
        return results;
    }

    private string GetStopPromoCode(string? operatorName)
    {
        if (string.IsNullOrEmpty(operatorName))
            return "*800*0#";

        var opLower = operatorName.ToLowerInvariant();
        
        if (opLower.Contains("vodafone") || opLower.Contains("فودافون"))
            return VodafoneCodes.StopPromo;
        if (opLower.Contains("orange") || opLower.Contains("اورنج"))
            return OrangeCodes.StopPromo;
        if (opLower.Contains("etisalat") || opLower.Contains("اتصالات"))
            return EtisalatCodes.StopPromo;

        return "*800*0#";
    }

    public async Task<List<UssdResult>> GetAllDataRemainingAsync(List<Modem> modems)
    {
        var results = new List<UssdResult>();
        var selectedModems = modems.Where(m => m.IsConnected && m.IsSelected).ToList();

        var tasks = selectedModems.Select(async modem =>
        {
            var code = GetDataRemainingCode(modem.Operator);
            return await _modemService.ExecuteUssdAsync(modem, code);
        });

        var taskResults = await Task.WhenAll(tasks);
        results.AddRange(taskResults);
        
        return results;
    }

    private string GetDataRemainingCode(string? operatorName)
    {
        if (string.IsNullOrEmpty(operatorName))
            return "*460#";

        var opLower = operatorName.ToLowerInvariant();
        
        if (opLower.Contains("vodafone") || opLower.Contains("فودافون"))
            return VodafoneCodes.DataRemaining;
        if (opLower.Contains("orange") || opLower.Contains("اورنج"))
            return OrangeCodes.DataRemaining;
        if (opLower.Contains("etisalat") || opLower.Contains("اتصالات"))
            return EtisalatCodes.DataRemaining;

        return "*460#";
    }

    #endregion

    #region Saved Services Management

    private List<SavedService> _savedServices = new();

    public void AddSavedService(SavedService service)
    {
        _savedServices.Add(service);
    }

    public void RemoveSavedService(string name)
    {
        _savedServices.RemoveAll(s => s.Name == name);
    }

    public List<SavedService> GetSavedServices() => _savedServices;

    public List<SavedService> GetSavedServicesByOperator(string operatorName)
    {
        return _savedServices.Where(s => 
            s.Operator.Equals(operatorName, StringComparison.OrdinalIgnoreCase) ||
            s.Operator == "all").ToList();
    }

    public async Task<UssdResult> ExecuteSavedServiceAsync(Modem modem, SavedService service)
    {
        return await _modemService.ExecuteUssdAsync(modem, service.UssdCode);
    }

    #endregion
}

public class SavedService
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string UssdCode { get; set; } = "";
    public string Operator { get; set; } = "all";
    public string Category { get; set; } = "عام";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
