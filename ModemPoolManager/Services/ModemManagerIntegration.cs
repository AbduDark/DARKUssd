using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

/// <summary>
/// Example integration showing how to use the new ModemManager architecture
/// This demonstrates how to refactor MainViewModel to use ModemManager
/// </summary>
public class ModemManagerIntegration
{
    private readonly ModemManager _modemManager;
    private readonly ModemService _legacyService;

    public ModemManagerIntegration(ModemService legacyService)
    {
        _legacyService = legacyService;
        _modemManager = new ModemManager();
        _modemManager.LogMessage += (s, msg) => Console.WriteLine(msg);
    }

    /// <summary>
    /// USAGE EXAMPLE 1: Initialize modems
    /// Called when user clicks "Detect Modems" or in MainViewModel.InitializeAsync()
    /// </summary>
    public async Task InitializeAllModemsAsync(List<string> portNames)
    {
        foreach (var portName in portNames)
        {
            await _modemManager.AddModemAsync(portName);
        }
    }

    /// <summary>
    /// USAGE EXAMPLE 2: Execute USSD on a single modem
    /// Replaces: await _legacyService.SendUssdAndGetFullResponseAsync(portName, ussdCode);
    /// </summary>
    public async Task<bool> ExecuteUssdOnModemAsync(string portName, string ussdCode)
    {
        return await _modemManager.ExecuteOnModemAsync(portName, ussdCode);
    }

    /// <summary>
    /// USAGE EXAMPLE 3: Execute USSD on ALL modems (main use case)
    /// Replaces: Loop calling SendUssdAndGetFullResponseAsync for each modem
    /// 
    /// Automatically:
    /// - Runs in parallel across all modems
    /// - Runs sequential per modem (no race conditions)
    /// - Cancels previous USSD commands (AT+CUSD=2)
    /// - Drops old commands if new ones arrive while queue is busy
    /// </summary>
    public async Task BroadcastUssdToAllModemsAsync(string ussdCode)
    {
        await _modemManager.ExecuteOnAllAsync(ussdCode);
    }

    /// <summary>
    /// USAGE EXAMPLE 4: Integration with MainViewModel
    /// In MainViewModel.cs, replace the "Execute on All" button handler:
    /// 
    /// OLD CODE:
    ///     var tasks = Modems
    ///         .Where(m => m.IsSelected && m.IsConnected)
    ///         .Select(m => _modemService.SendUssdAndGetFullResponseAsync(m.PortName, UssdCode))
    ///         .ToList();
    ///     var results = await Task.WhenAll(tasks);
    /// 
    /// NEW CODE:
    ///     await _modemManager.ExecuteOnAllAsync(UssdCode);
    /// </summary>
    public void ShowIntegrationExample()
    {
        var example = @"
// In MainViewModel.cs constructor:
private readonly ModemManager _modemManager = new ModemManager();

// In InitializeAsync():
foreach (var modem in connectedModems)
{
    await _modemManager.AddModemAsync(modem.PortName);
}

// In ExecuteOnAllCommand:
[RelayCommand]
public async Task ExecuteOnAll()
{
    IsProcessing = true;
    try
    {
        await _modemManager.ExecuteOnAllAsync(UssdCode);
    }
    finally
    {
        IsProcessing = false;
    }
}

// Handle modem disconnect:
ModemDisconnected += async (s, modem) =>
{
    await _modemManager.RemoveModemAsync(modem.PortName);
};
";
        Console.WriteLine(example);
    }
}
