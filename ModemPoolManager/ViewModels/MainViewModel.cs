using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ModemPoolManager.Models;
using ModemPoolManager.Services;

namespace ModemPoolManager.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly ModemService _modemService;
    private readonly SmsService _smsService;
    private readonly AiAssistantService _aiService;

    [ObservableProperty]
    private ObservableCollection<Modem> _modems = new();

    [ObservableProperty]
    private ObservableCollection<UssdResult> _results = new();

    [ObservableProperty]
    private ObservableCollection<SmsMessage> _smsMessages = new();

    [ObservableProperty]
    private ObservableCollection<CommandHistory> _commandHistory = new();

    [ObservableProperty]
    private string _ussdCode = "*100#";

    [ObservableProperty]
    private string _statusMessage = "جاري المراقبة التلقائية للمودمات...";

    [ObservableProperty]
    private bool _isProcessing;

    [ObservableProperty]
    private int _connectedCount;

    [ObservableProperty]
    private int _totalPorts;
    
    [ObservableProperty]
    private bool _isMonitoring;

    [ObservableProperty]
    private string _customUssd1 = "*100#";

    [ObservableProperty]
    private string _customUssd2 = "*101#";

    [ObservableProperty]
    private string _customUssd3 = "*102#";

    [ObservableProperty]
    private string _smsPhoneNumber = string.Empty;

    [ObservableProperty]
    private string _smsMessage = string.Empty;

    [ObservableProperty]
    private string _aiQuestion = string.Empty;

    [ObservableProperty]
    private string _aiResponse = "مرحباً! أنا المساعد الذكي لإدارة المودمات.\n\nيمكنني مساعدتك في:\n• تحليل ردود USSD\n• اقتراح أوامر مناسبة\n• تشخيص مشاكل المودمات\n• فهم رسائل SMS\n\nاكتب سؤالك أو اختر أحد الأزرار للبدء.";

    [ObservableProperty]
    private AppSettings _settings;

    [ObservableProperty]
    private int _successfulCommandsCount;

    [ObservableProperty]
    private int _failedCommandsCount;

    [ObservableProperty]
    private int _totalSmsCount;

    private int _commandId = 0;

    public MainViewModel()
    {
        _settings = AppSettings.Load();
        _modemService = new ModemService();
        _smsService = new SmsService(_modemService);
        _aiService = new AiAssistantService(_settings);

        CustomUssd1 = _settings.General.QuickUssdCommands.ElementAtOrDefault(0) ?? "*100#";
        CustomUssd2 = _settings.General.QuickUssdCommands.ElementAtOrDefault(1) ?? "*101#";
        CustomUssd3 = _settings.General.QuickUssdCommands.ElementAtOrDefault(2) ?? "*102#";
        
        _modemService.ModemConnected += OnModemConnected;
        _modemService.ModemDisconnected += OnModemDisconnected;
        _modemService.ModemUpdated += OnModemUpdated;
        _modemService.MonitoringStatusChanged += OnMonitoringStatusChanged;
        
        _modemService.StartMonitoring(5000);
        IsMonitoring = true;
    }

    private void OnModemConnected(object? sender, Modem modem)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            var existing = Modems.FirstOrDefault(m => m.PortName == modem.PortName);
            if (existing == null)
            {
                modem.Index = Modems.Count + 1;
                Modems.Add(modem);
                StatusMessage = $"تم اكتشاف مودم جديد: {modem.PortName} - جاري جلب الرقم...";
            }
            else
            {
                existing.IsConnected = true;
                existing.Status = modem.Status;
                existing.PhoneNumber = modem.PhoneNumber;
                existing.SignalStrength = modem.SignalStrength;
                existing.Operator = modem.Operator;
                existing.LastActivity = DateTime.Now;
                StatusMessage = $"تم إعادة توصيل المودم: {modem.PortName}";
            }
            UpdateCounts();
        });
    }

    private void OnModemDisconnected(object? sender, Modem modem)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            var existing = Modems.FirstOrDefault(m => m.PortName == modem.PortName);
            if (existing != null)
            {
                Modems.Remove(existing);
                ReindexModems();
            }
            UpdateCounts();
            StatusMessage = $"تم فصل المودم: {modem.PortName}";
        });
    }

    private void ReindexModems()
    {
        int index = 1;
        foreach (var modem in Modems.OrderBy(m => m.PortName))
        {
            modem.Index = index++;
        }
    }

    private void OnModemUpdated(object? sender, Modem modem)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            var existing = Modems.FirstOrDefault(m => m.PortName == modem.PortName);
            if (existing != null)
            {
                existing.PhoneNumber = modem.PhoneNumber;
                existing.SignalStrength = modem.SignalStrength;
                existing.Operator = modem.Operator;
                existing.Status = modem.Status;
                existing.LastActivity = modem.LastActivity;
            }
            UpdateCounts();
        });
    }

    private void OnMonitoringStatusChanged(object? sender, string status)
    {
        Application.Current.Dispatcher.Invoke(() =>
        {
            StatusMessage = status;
        });
    }

    private void UpdateCounts()
    {
        ConnectedCount = Modems.Count(m => m.IsConnected);
        TotalPorts = Modems.Count;
    }

    [RelayCommand]
    private void ToggleMonitoring()
    {
        if (IsMonitoring)
        {
            _modemService.StopMonitoring();
            IsMonitoring = false;
            StatusMessage = "تم إيقاف المراقبة التلقائية";
        }
        else
        {
            _modemService.StartMonitoring(5000);
            IsMonitoring = true;
            StatusMessage = "تم بدء المراقبة التلقائية";
        }
    }

    [RelayCommand]
    private async Task RefreshPortsAsync()
    {
        try
        {
            IsProcessing = true;
            StatusMessage = "جاري إعادة فحص المودمات...";
            
            Modems.Clear();
            Results.Clear();
            UpdateCounts();
            
            await _modemService.ForceRescanAsync();
            
            await Task.Delay(2000);
            
            var activeModems = _modemService.GetActiveModems().ToList();
            foreach (var modem in activeModems)
            {
                var existing = Modems.FirstOrDefault(m => m.PortName == modem.PortName);
                if (existing == null)
                {
                    modem.Index = Modems.Count + 1;
                    Modems.Add(modem);
                }
            }

            UpdateCounts();
            
            if (ConnectedCount == 0)
            {
                var allDevices = _modemService.GetAllComDevices();
                if (allDevices.Count > 0)
                {
                    var deviceList = string.Join(", ", allDevices.Take(5));
                    StatusMessage = $"لم يتم العثور على مودمات ZTE. الأجهزة: {deviceList}";
                }
                else
                {
                    StatusMessage = "لم يتم العثور على مودمات - تحقق من الاتصال";
                }
            }
            else
            {
                StatusMessage = $"تم العثور على {ConnectedCount} مودم متصل";
            }
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
            StatusMessage = "جاري جلب أرقام الهواتف ومعلومات المودمات...";

            var connectedModems = Modems.Where(m => m.IsConnected).ToList();
            
            var tasks = connectedModems.Select(async modem =>
            {
                modem.Operator = await _modemService.GetOperatorAsync(modem.PortName);
                modem.PhoneNumber = await _modemService.GetPhoneNumberViaUssdDirectAsync(modem.PortName, modem.Operator);
                modem.SignalStrength = await _modemService.GetSignalStrengthAsync(modem.PortName);
                modem.Info = await _modemService.GetModemInfoAsync(modem.PortName);
                modem.UnreadSmsCount = await _smsService.GetUnreadCountAsync(modem.PortName);
                modem.Status = "جاهز";
                modem.LastActivity = DateTime.Now;
            });

            await Task.WhenAll(tasks);
            
            OnPropertyChanged(nameof(Modems));
            StatusMessage = $"تم جلب معلومات {connectedModems.Count} مودم";
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
    private async Task RefreshModemSignalAsync(Modem modem)
    {
        if (modem == null || !modem.IsConnected || modem.IsBusy) return;
        
        try
        {
            var previousStatus = modem.Status;
            modem.Status = "جاري التحديث...";
            
            var success = await _modemService.RefreshModemSignalAsync(modem);
            
            modem.Status = success ? "جاهز" : previousStatus;
            StatusMessage = success 
                ? $"تم تحديث إشارة {modem.PortName}: {modem.SignalStrength}" 
                : $"المودم {modem.PortName} مشغول";
        }
        catch (Exception ex)
        {
            modem.Status = "خطأ";
            StatusMessage = $"خطأ في تحديث الإشارة: {ex.Message}";
        }
    }

    [RelayCommand]
    private async Task RefreshModemPhoneNumberAsync(Modem modem)
    {
        if (modem == null || !modem.IsConnected || modem.IsBusy) return;
        
        try
        {
            var previousStatus = modem.Status;
            modem.Status = "جاري جلب الرقم...";
            
            var success = await _modemService.RefreshModemPhoneNumberAsync(modem);
            
            modem.Status = success ? "جاهز" : previousStatus;
            StatusMessage = success 
                ? $"تم تحديث رقم {modem.PortName}: {modem.PhoneNumber}" 
                : $"المودم {modem.PortName} مشغول";
        }
        catch (Exception ex)
        {
            modem.Status = "خطأ";
            StatusMessage = $"خطأ في جلب الرقم: {ex.Message}";
        }
    }

    [RelayCommand]
    private async Task RefreshAllSignalsAsync()
    {
        try
        {
            IsProcessing = true;
            StatusMessage = "جاري تحديث جميع الإشارات...";

            var connectedModems = Modems.Where(m => m.IsConnected && !m.IsBusy).ToList();
            
            var tasks = connectedModems.Select(async modem =>
            {
                modem.Status = "جاري التحديث...";
                var success = await _modemService.RefreshModemSignalAsync(modem);
                modem.Status = success ? "جاهز" : "خطأ";
                return success;
            });
            
            var results = await Task.WhenAll(tasks);
            int successCount = results.Count(r => r);
            
            foreach (var modem in connectedModems)
            {
                OnPropertyChanged(nameof(modem.SignalStrength));
                OnPropertyChanged(nameof(modem.SignalLevel));
            }
            
            StatusMessage = $"تم تحديث إشارات {successCount}/{connectedModems.Count} مودم";
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
                modem.IsBusy = true;
                modem.LastResponse = string.Empty;
                modem.LastResponseDuration = TimeSpan.Zero;
            }

            var startTime = DateTime.Now;
            var modemStartTimes = selectedModems.ToDictionary(m => m.PortName, m => DateTime.Now);
            var results = await _modemService.ExecuteUssdOnAllAsync(selectedModems, ussdCode);
            var executionTime = DateTime.Now - startTime;

            foreach (var result in results)
            {
                Results.Add(result);
                
                var modem = Modems.FirstOrDefault(m => m.PortName == result.PortName);
                if (modem != null)
                {
                    var modemDuration = DateTime.Now - modemStartTimes[modem.PortName];
                    modem.LastResponse = result.Response;
                    modem.LastResponseDuration = modemDuration;
                    modem.LastResponseTime = DateTime.Now;
                    modem.Status = result.IsSuccess ? "نجح" : "فشل";
                    modem.IsBusy = false;
                    modem.LastActivity = DateTime.Now;

                    if (result.IsSuccess)
                    {
                        modem.SuccessfulCommands++;
                        SuccessfulCommandsCount++;
                    }
                    else
                    {
                        modem.FailedCommands++;
                        FailedCommandsCount++;
                    }
                }

                AddToHistory(ussdCode, result.Response, result.PortName, result.ModemIndex, result.IsSuccess, executionTime);
            }

            var successCount = results.Count(r => r.IsSuccess);
            StatusMessage = $"تم التنفيذ: {successCount}/{results.Count} نجح في {executionTime.TotalSeconds:F1} ثانية";

            if (_settings.Ai.Enabled && _settings.Ai.AutoAnalyzeResponses && results.Any(r => r.IsSuccess))
            {
                await AutoAnalyzeResponsesAsync(results.Where(r => r.IsSuccess).ToList());
            }
        }
        catch (Exception ex)
        {
            StatusMessage = $"خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
            foreach (var modem in Modems)
            {
                modem.IsBusy = false;
            }
        }
    }

    private void AddToHistory(string command, string response, string portName, int modemIndex, bool isSuccess, TimeSpan executionTime)
    {
        var history = new CommandHistory
        {
            Id = ++_commandId,
            Command = command,
            Response = response.Length > 100 ? response.Substring(0, 100) + "..." : response,
            ModemPort = portName,
            ModemIndex = modemIndex,
            Timestamp = DateTime.Now,
            IsSuccess = isSuccess,
            ExecutionTime = executionTime,
            CommandType = command.StartsWith("AT+CUSD") ? CommandType.USSD : 
                          command.StartsWith("AT+CMGS") ? CommandType.SMS : CommandType.AT
        };

        System.Windows.Application.Current.Dispatcher.Invoke(() =>
        {
            CommandHistory.Insert(0, history);
            if (CommandHistory.Count > _settings.Ui.MaxHistoryItems)
            {
                CommandHistory.RemoveAt(CommandHistory.Count - 1);
            }
        });
    }

    private async Task AutoAnalyzeResponsesAsync(List<UssdResult> results)
    {
        try
        {
            var firstResult = results.First();
            var modem = Modems.FirstOrDefault(m => m.PortName == firstResult.PortName);
            var operatorName = modem?.Operator ?? "غير معروف";

            var analysis = await _aiService.AnalyzeUssdResponseAsync(firstResult.UssdCode, firstResult.Response, operatorName);
            if (!string.IsNullOrEmpty(analysis))
            {
                AiResponse = $"📊 تحليل تلقائي للرد:\n\n{analysis}";
            }
        }
        catch { }
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

    [RelayCommand]
    private async Task SendSmsAsync()
    {
        if (string.IsNullOrWhiteSpace(SmsPhoneNumber) || string.IsNullOrWhiteSpace(SmsMessage))
        {
            StatusMessage = "الرجاء إدخال رقم الهاتف والرسالة";
            return;
        }

        try
        {
            IsProcessing = true;
            StatusMessage = "جاري إرسال الرسائل...";

            var selectedModems = Modems.Where(m => m.IsConnected && m.IsSelected).ToList();
            
            if (selectedModems.Count == 0)
            {
                StatusMessage = "لا توجد مودمات محددة للإرسال";
                return;
            }

            int successCount = 0;
            foreach (var modem in selectedModems)
            {
                var (success, error) = await _smsService.SendSmsAsync(modem.PortName, SmsPhoneNumber, SmsMessage);
                if (success)
                {
                    successCount++;
                    modem.Status = "تم الإرسال";
                }
                else
                {
                    modem.Status = $"فشل: {error}";
                }
            }

            StatusMessage = $"تم إرسال {successCount}/{selectedModems.Count} رسالة";
            TotalSmsCount += successCount;
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
    private async Task GetSmsAsync()
    {
        try
        {
            IsProcessing = true;
            StatusMessage = "جاري جلب الرسائل...";
            SmsMessages.Clear();

            var connectedModems = Modems.Where(m => m.IsConnected).ToList();
            
            foreach (var modem in connectedModems)
            {
                var messages = await _smsService.GetAllMessagesAsync(modem.PortName, modem.Index);
                foreach (var msg in messages)
                {
                    SmsMessages.Add(msg);
                }
            }

            TotalSmsCount = SmsMessages.Count;
            StatusMessage = $"تم جلب {SmsMessages.Count} رسالة";
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
    private async Task DeleteAllSmsAsync()
    {
        try
        {
            IsProcessing = true;
            StatusMessage = "جاري حذف الرسائل...";

            var connectedModems = Modems.Where(m => m.IsConnected).ToList();
            
            foreach (var modem in connectedModems)
            {
                await _smsService.DeleteAllSmsAsync(modem.PortName);
            }

            SmsMessages.Clear();
            TotalSmsCount = 0;
            StatusMessage = "تم حذف جميع الرسائل";
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
    private async Task AskAiAsync()
    {
        if (string.IsNullOrWhiteSpace(AiQuestion))
        {
            StatusMessage = "الرجاء كتابة سؤال";
            return;
        }

        if (!_settings.Ai.Enabled || string.IsNullOrEmpty(_settings.Ai.ApiKey))
        {
            AiResponse = "⚠️ المساعد الذكي غير مفعل.\n\nلتفعيله:\n1. اذهب إلى الإعدادات\n2. فعّل خيار 'تفعيل المساعد الذكي'\n3. أدخل مفتاح OpenAI API";
            return;
        }

        try
        {
            IsProcessing = true;
            AiResponse = "جاري التحليل...";

            var response = await _aiService.DiagnoseModemIssueAsync(AiQuestion, 
                string.Join(", ", CommandHistory.Take(5).Select(h => h.Command)));
            
            AiResponse = string.IsNullOrEmpty(response) 
                ? "لم أتمكن من الحصول على رد. تحقق من اتصال الإنترنت ومفتاح API." 
                : response;
        }
        catch (Exception ex)
        {
            AiResponse = $"خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    [RelayCommand]
    private async Task AnalyzeResponsesAsync()
    {
        if (!Results.Any())
        {
            StatusMessage = "لا توجد نتائج للتحليل";
            return;
        }

        if (!_settings.Ai.Enabled || string.IsNullOrEmpty(_settings.Ai.ApiKey))
        {
            AiResponse = "⚠️ المساعد الذكي غير مفعل. فعّله من الإعدادات.";
            return;
        }

        try
        {
            IsProcessing = true;
            AiResponse = "جاري تحليل الردود...";

            var firstResult = Results.First();
            var modem = Modems.FirstOrDefault(m => m.PortName == firstResult.PortName);
            
            var response = await _aiService.AnalyzeUssdResponseAsync(
                firstResult.UssdCode, 
                firstResult.Response,
                modem?.Operator ?? "غير معروف");
            
            AiResponse = string.IsNullOrEmpty(response) 
                ? "لم أتمكن من تحليل الرد." 
                : $"📊 تحليل الرد:\n\n{response}";
        }
        catch (Exception ex)
        {
            AiResponse = $"خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    [RelayCommand]
    private async Task GetSuggestionsAsync()
    {
        if (!_settings.Ai.Enabled || string.IsNullOrEmpty(_settings.Ai.ApiKey))
        {
            AiResponse = "⚠️ المساعد الذكي غير مفعل. فعّله من الإعدادات.";
            return;
        }

        try
        {
            IsProcessing = true;
            AiResponse = "جاري جلب الاقتراحات...";

            var modem = Modems.FirstOrDefault(m => m.IsConnected);
            var operatorName = modem?.Operator ?? "غير معروف";
            
            var response = await _aiService.SuggestUssdCommandsAsync(operatorName, "استعلام عن الرصيد والباقات");
            
            AiResponse = string.IsNullOrEmpty(response) 
                ? "لم أتمكن من جلب الاقتراحات." 
                : $"💡 اقتراحات أوامر USSD لـ {operatorName}:\n\n{response}";
        }
        catch (Exception ex)
        {
            AiResponse = $"خطأ: {ex.Message}";
        }
        finally
        {
            IsProcessing = false;
        }
    }

    [RelayCommand]
    private void OpenSettings()
    {
    }

    [RelayCommand]
    private void SaveSettings()
    {
        try
        {
            _settings.General.QuickUssdCommands = new List<string> { CustomUssd1, CustomUssd2, CustomUssd3 };
            _settings.Save();
            StatusMessage = "تم حفظ الإعدادات بنجاح";
        }
        catch (Exception ex)
        {
            StatusMessage = $"خطأ في حفظ الإعدادات: {ex.Message}";
        }
    }

    [RelayCommand]
    private void ResetSettings()
    {
        Settings = new AppSettings();
        Settings.Save();
        StatusMessage = "تم إعادة تعيين الإعدادات";
    }
}
