using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ModemPoolManager.Models;

public class AppSettings
{
    public const int CurrentVersion = 3;
    
    public int SettingsVersion { get; set; } = CurrentVersion;
    public ModemSettings Modem { get; set; } = new();
    public UiSettings Ui { get; set; } = new();
    public AiSettings Ai { get; set; } = new();
    public GeneralSettings General { get; set; } = new();
    public FeatureFlags Features { get; set; } = new();
    public CashPasswordSettings CashPasswords { get; set; } = new();

    private static readonly string SettingsPath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "ModemPoolManager",
        "settings.json");

    public static AppSettings Load()
    {
        try
        {
            if (File.Exists(SettingsPath))
            {
                var json = File.ReadAllText(SettingsPath);
                var settings = JsonSerializer.Deserialize<AppSettings>(json);
                
                if (settings != null)
                {
                    if (settings.SettingsVersion < CurrentVersion)
                    {
                        settings = MigrateSettings(settings);
                        settings.Save();
                    }
                    return settings;
                }
            }
        }
        catch { }

        var newSettings = new AppSettings();
        newSettings.Save();
        return newSettings;
    }
    
    private static AppSettings MigrateSettings(AppSettings settings)
    {
        var previousVersion = settings.SettingsVersion;
        
        settings.Modem ??= new ModemSettings();
        settings.Ui ??= new UiSettings();
        settings.Ai ??= new AiSettings();
        settings.General ??= new GeneralSettings();
        settings.CashPasswords ??= new CashPasswordSettings();
        
        if (settings.Features == null)
        {
            settings.Features = new FeatureFlags();
        }
        else
        {
            var defaultFeatures = new FeatureFlags();
            settings.Features.EnableOrangeCash = settings.Features.EnableOrangeCash || defaultFeatures.EnableOrangeCash;
            settings.Features.EnableSmsListener = settings.Features.EnableSmsListener || defaultFeatures.EnableSmsListener;
            settings.Features.EnableBalanceQuery = settings.Features.EnableBalanceQuery || defaultFeatures.EnableBalanceQuery;
            settings.Features.EnableCardTopUp = settings.Features.EnableCardTopUp || defaultFeatures.EnableCardTopUp;
            settings.Features.EnableOperatorServices = settings.Features.EnableOperatorServices || defaultFeatures.EnableOperatorServices;
            settings.Features.EnableVodafoneServices = settings.Features.EnableVodafoneServices || defaultFeatures.EnableVodafoneServices;
            settings.Features.EnableOrangeServices = settings.Features.EnableOrangeServices || defaultFeatures.EnableOrangeServices;
            settings.Features.EnableEtisalatServices = settings.Features.EnableEtisalatServices || defaultFeatures.EnableEtisalatServices;
            settings.Features.EnableAiAssistant = settings.Features.EnableAiAssistant || defaultFeatures.EnableAiAssistant;
            settings.Features.EnableContextMenu = settings.Features.EnableContextMenu || defaultFeatures.EnableContextMenu;
            settings.Features.EnableModemRestart = settings.Features.EnableModemRestart || defaultFeatures.EnableModemRestart;
            settings.Features.EnableParallelTransfers = settings.Features.EnableParallelTransfers || defaultFeatures.EnableParallelTransfers;
        }
        
        settings.SettingsVersion = CurrentVersion;
        
        Console.WriteLine($"[Settings] تم ترقية الإعدادات من الإصدار {previousVersion} إلى {CurrentVersion}");
        
        return settings;
    }

    public void Save()
    {
        try
        {
            var directory = Path.GetDirectoryName(SettingsPath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(SettingsPath, json);
        }
        catch { }
    }
}

public class ModemSettings
{
    public int BaudRate { get; set; } = 115200;
    public int ReadTimeout { get; set; } = 10000;
    public int CommandTimeout { get; set; } = 30000;
    public int UssdTimeout { get; set; } = 60000;
    public int SmsTimeout { get; set; } = 30000;
    public int RetryCount { get; set; } = 3;
    public int RetryDelayMs { get; set; } = 1000;
    public int RetryMaxDelayMs { get; set; } = 10000;
    public bool RetryUseExponentialBackoff { get; set; } = true;
    public bool RetryAddJitter { get; set; } = true;
    public bool AutoRefreshPorts { get; set; } = true;
    public int AutoRefreshIntervalSeconds { get; set; } = 60;
    public int MaxModems { get; set; } = 12;
    public List<string> PortFilters { get; set; } = new() { "ZTE", "Diagnostics", "Modem", "USB Serial" };
    public List<string> PortExclusions { get; set; } = new() { "NVME", "NMEA", "GPS" };
    public string CharacterSet { get; set; } = "GSM";
}

public class UiSettings
{
    public string Theme { get; set; } = "Dark";
    public string AccentColor { get; set; } = "#4C6EF5";
    public string Language { get; set; } = "ar";
    public bool IsRtl { get; set; } = true;
    public bool ShowStatusBar { get; set; } = true;
    public bool ShowCommandHistory { get; set; } = true;
    public int MaxHistoryItems { get; set; } = 1000;
    public bool AnimationsEnabled { get; set; } = true;
    public double FontSize { get; set; } = 14;
}

public class AiSettings
{
    public bool Enabled { get; set; } = false;
    public string Provider { get; set; } = "OpenAI";
    public string ApiKey { get; set; } = string.Empty;
    public string Model { get; set; } = "gpt-4o-mini";
    public bool AutoAnalyzeResponses { get; set; } = true;
    public bool SuggestCommands { get; set; } = true;
    public bool DetectAnomalies { get; set; } = true;
    public double Temperature { get; set; } = 0.7;
    public int MaxTokens { get; set; } = 500;
}

public class GeneralSettings
{
    public bool StartWithWindows { get; set; } = false;
    public bool StartMinimized { get; set; } = false;
    public bool MinimizeToTray { get; set; } = true;
    public bool ConfirmOnExit { get; set; } = true;
    public bool EnableLogging { get; set; } = true;
    public string LogLevel { get; set; } = "Info";
    public bool EnableSounds { get; set; } = true;
    public bool EnableNotifications { get; set; } = true;
    public bool AutoRenewValidityForAll { get; set; } = false;
    public string SelectedOperator { get; set; } = "All";

    public List<string> QuickUssdCommands { get; set; } = new()
    {
        "*100#",
        "*101#",
        "*102#",
        "*111#",
        "*121#",
        "*123#"
    };
}

public class CashPasswordSettings
{
    public string OrangeCashPassword { get; set; } = "";
    public string VodafoneCashPassword { get; set; } = "";
    public string EtisalatCashPassword { get; set; } = "";
}

public class FeatureFlags
{
    public bool EnableOrangeCash { get; set; } = true;
    public bool EnableSmsListener { get; set; } = true;
    public bool EnableBalanceQuery { get; set; } = true;
    public bool EnableCardTopUp { get; set; } = true;
    public bool EnableOperatorServices { get; set; } = true;
    public bool EnableVodafoneServices { get; set; } = true;
    public bool EnableOrangeServices { get; set; } = true;
    public bool EnableEtisalatServices { get; set; } = true;
    public bool EnableAiAssistant { get; set; } = true;
    public bool EnableContextMenu { get; set; } = true;
    public bool EnableModemRestart { get; set; } = true;
    public bool EnableParallelTransfers { get; set; } = true;
}
