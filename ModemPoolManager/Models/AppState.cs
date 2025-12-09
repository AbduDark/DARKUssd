using System.IO;
using System.Text.Json;

namespace ModemPoolManager.Models;

public class AppState
{
    private static readonly string AppStateFilePath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "ModemPoolManager",
        "appstate.json");

    public string UssdCode { get; set; } = "*100#";
    public string CustomUssd1 { get; set; } = "*100#";
    public string CustomUssd2 { get; set; } = "*101#";
    public string CustomUssd3 { get; set; } = "*102#";
    public string SmsPhoneNumber { get; set; } = "";
    public string SmsMessage { get; set; } = "";
    public string OrangeCashPassword { get; set; } = "";
    public string PrimarySenderPhone { get; set; } = "";
    public int TransferAmount { get; set; } = 100;
    public string OcSeriesTargetPhone { get; set; } = "";
    public int OcSeriesAmount { get; set; } = 100;
    public int OcSeriesDelay { get; set; } = 12;
    public int RemainingPerModem { get; set; } = 80;
    public int FixedTransferAmount { get; set; } = 100;
    public bool UseFixedAmount { get; set; } = true;
    public int CustomTransferDelay { get; set; } = 12;
    public int SequentialDelayMs { get; set; } = 500;
    public string NewSequentialCommand { get; set; } = "";
    public bool NewCommandIsReply { get; set; } = false;
    public List<SequentialUssdCommandState> SequentialCommands { get; set; } = new();
    public decimal SenderCashBalance { get; set; } = 0;

    public static AppState Load()
    {
        try
        {
            if (File.Exists(AppStateFilePath))
            {
                var json = File.ReadAllText(AppStateFilePath);
                var state = JsonSerializer.Deserialize<AppState>(json);
                return state ?? new AppState();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading app state: {ex.Message}");
        }
        return new AppState();
    }

    public void Save()
    {
        try
        {
            var directory = Path.GetDirectoryName(AppStateFilePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var options = new JsonSerializerOptions 
            { 
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            };
            var json = JsonSerializer.Serialize(this, options);
            File.WriteAllText(AppStateFilePath, json);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving app state: {ex.Message}");
        }
    }
}

public class SequentialUssdCommandState
{
    public int Order { get; set; }
    public string Command { get; set; } = "";
    public bool IsReply { get; set; }
}
