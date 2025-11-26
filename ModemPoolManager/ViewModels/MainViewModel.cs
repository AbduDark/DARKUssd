using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ModemPoolManager.Models;
using ModemPoolManager.Services;

namespace ModemPoolManager.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly ModemService _modemService;

    [ObservableProperty]
    private ObservableCollection<Modem> _modems = new();

    [ObservableProperty]
    private ObservableCollection<UssdResult> _results = new();

    [ObservableProperty]
    private string _ussdCode = "*100#";

    [ObservableProperty]
    private string _statusMessage = "جاهز للعمل";

    [ObservableProperty]
    private bool _isProcessing;

    [ObservableProperty]
    private int _connectedCount;

    [ObservableProperty]
    private int _totalPorts;

    [ObservableProperty]
    private string _customUssd1 = "*100#";

    [ObservableProperty]
    private string _customUssd2 = "*101#";

    [ObservableProperty]
    private string _customUssd3 = "*102#";

    public MainViewModel()
    {
        _modemService = new ModemService();
    }

    [RelayCommand]
    private async Task RefreshPortsAsync()
    {
        try
        {
            IsProcessing = true;
            StatusMessage = "جاري البحث عن المودمات...";
            
            Modems.Clear();
            Results.Clear();

            var detectedModems = await _modemService.DetectModemsAsync(12);
            
            foreach (var modem in detectedModems)
            {
                Modems.Add(modem);
            }

            ConnectedCount = Modems.Count(m => m.IsConnected);
            TotalPorts = Modems.Count;
            
            StatusMessage = $"تم العثور على {ConnectedCount} مودم متصل";
        }
        catch (Exception ex)
        {
            StatusMessage = $"خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    [RelayCommand]
    private async Task GetPhoneNumbersAsync()
    {
        try
        {
            IsProcessing = true;
            StatusMessage = "جاري جلب أرقام الهواتف...";

            var connectedModems = Modems.Where(m => m.IsConnected).ToList();
            
            var tasks = connectedModems.Select(async modem =>
            {
                modem.PhoneNumber = await _modemService.GetPhoneNumberAsync(modem.PortName);
                modem.SignalStrength = await _modemService.GetSignalStrengthAsync(modem.PortName);
                modem.Operator = await _modemService.GetOperatorAsync(modem.PortName);
                modem.Status = "جاهز";
            });

            await Task.WhenAll(tasks);
            
            OnPropertyChanged(nameof(Modems));
            StatusMessage = $"تم جلب {connectedModems.Count} رقم هاتف";
        }
        catch (Exception ex)
        {
            StatusMessage = $"خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    [RelayCommand]
    private async Task ExecuteUssdAsync()
    {
        await ExecuteUssdOnAllAsync(UssdCode);
    }

    [RelayCommand]
    private async Task ExecuteCustomUssd1Async()
    {
        await ExecuteUssdOnAllAsync(CustomUssd1);
    }

    [RelayCommand]
    private async Task ExecuteCustomUssd2Async()
    {
        await ExecuteUssdOnAllAsync(CustomUssd2);
    }

    [RelayCommand]
    private async Task ExecuteCustomUssd3Async()
    {
        await ExecuteUssdOnAllAsync(CustomUssd3);
    }

    private async Task ExecuteUssdOnAllAsync(string ussdCode)
    {
        if (string.IsNullOrWhiteSpace(ussdCode))
        {
            StatusMessage = "الرجاء إدخال كود USSD";
            return;
        }

        try
        {
            IsProcessing = true;
            Results.Clear();
            
            var selectedModems = Modems.Where(m => m.IsConnected && m.IsSelected).ToList();
            
            if (selectedModems.Count == 0)
            {
                StatusMessage = "لا توجد مودمات محددة للتنفيذ";
                return;
            }

            StatusMessage = $"جاري تنفيذ {ussdCode} على {selectedModems.Count} مودم...";

            foreach (var modem in selectedModems)
            {
                modem.Status = "جاري التنفيذ...";
            }

            var results = await _modemService.ExecuteUssdOnAllAsync(selectedModems, ussdCode);

            foreach (var result in results)
            {
                Results.Add(result);
                
                var modem = Modems.FirstOrDefault(m => m.PortName == result.PortName);
                if (modem != null)
                {
                    modem.LastResponse = result.Response;
                    modem.Status = result.IsSuccess ? "نجح" : "فشل";
                }
            }

            var successCount = results.Count(r => r.IsSuccess);
            StatusMessage = $"تم التنفيذ: {successCount}/{results.Count} نجح";
        }
        catch (Exception ex)
        {
            StatusMessage = $"خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    [RelayCommand]
    private void SelectAllModems()
    {
        foreach (var modem in Modems)
        {
            modem.IsSelected = true;
        }
        OnPropertyChanged(nameof(Modems));
    }

    [RelayCommand]
    private void DeselectAllModems()
    {
        foreach (var modem in Modems)
        {
            modem.IsSelected = false;
        }
        OnPropertyChanged(nameof(Modems));
    }

    [RelayCommand]
    private void ClearResults()
    {
        Results.Clear();
        foreach (var modem in Modems)
        {
            modem.LastResponse = string.Empty;
            modem.Status = modem.IsConnected ? "جاهز" : "غير متصل";
        }
        StatusMessage = "تم مسح النتائج";
    }
}
