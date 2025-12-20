using System.Collections.ObjectModel;
using System.IO.Ports;
using System.Windows;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using USSDARK.Models;
using USSDARK.Services;

namespace USSDARK.ViewModels;

public partial class MainViewModel : ObservableObject, IDisposable
{
    private readonly ModemManager _modemManager;

    [ObservableProperty]
    private ObservableCollection<Modem> modems = new();

    [ObservableProperty]
    private string ussdCode = "*100#";

    [ObservableProperty]
    private string statusMessage = "جاري التحقق من المودمات...";

    [ObservableProperty]
    private bool isProcessing;

    [ObservableProperty]
    private int connectedCount;

    [ObservableProperty]
    private int totalPorts;

    public MainViewModel()
    {
        _modemManager = new ModemManager();
        _modemManager.LogMessage += (s, msg) => Console.WriteLine(msg);
        
        InitializeAsync();
    }

    private async void InitializeAsync()
    {
        await DetectModemsAsync();
    }

    [RelayCommand]
    public async Task DetectModems()
    {
        await DetectModemsAsync();
    }

    private async Task DetectModemsAsync()
    {
        IsProcessing = true;
        StatusMessage = "جاري البحث عن المودمات...";
        
        try
        {
            Modems.Clear();
            var ports = SerialPort.GetPortNames();
            TotalPorts = ports.Length;

            foreach (var port in ports)
            {
                var modem = new Modem
                {
                    Index = Modems.Count + 1,
                    PortName = port,
                    Status = "جاري الاتصال...",
                    IsConnected = true
                };
                
                Modems.Add(modem);
                await _modemManager.AddModemAsync(port);
            }

            ConnectedCount = Modems.Count;
            StatusMessage = $"تم الكشف عن {ConnectedCount} مودم";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    [RelayCommand]
    public async Task ExecuteOnAll()
    {
        if (string.IsNullOrEmpty(UssdCode))
        {
            StatusMessage = "يجب إدخال كود USSD";
            return;
        }

        IsProcessing = true;
        StatusMessage = $"جاري تنفيذ {UssdCode} على جميع المودمات...";
        
        try
        {
            await _modemManager.ExecuteOnAllAsync(UssdCode);
            StatusMessage = "✓ تم التنفيذ على جميع المودمات";
        }
        catch (Exception ex)
        {
            StatusMessage = $"✗ خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    public void Dispose()
    {
        _modemManager?.Dispose();
    }
}
