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
    private readonly BalanceQueryService _balanceQueryService;
    private readonly CardTopUpService _cardTopUpService;

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
    private string _orangeCashPassword = "";

    [ObservableProperty]
    private int _transferAmount = 100;

    [ObservableProperty]
    private bool _isTransferRunning;

    [ObservableProperty]
    private string _transferLog = "";

    [ObservableProperty]
    private int _successfulTransfers;

    [ObservableProperty]
    private int _failedTransfers;

    [ObservableProperty]
    private int _cooldownSeconds;

    [ObservableProperty]
    private bool _isCooldownActive;

    [ObservableProperty]
    private AppSettings _settings;

    [ObservableProperty]
    private int _successfulCommandsCount;

    [ObservableProperty]
    private int _failedCommandsCount;

    [ObservableProperty]
    private int _totalSmsCount;

    [ObservableProperty]
    private string _cardNumbers = "";

    [ObservableProperty]
    private string _topUpLog = "";

    [ObservableProperty]
    private int _successfulTopUps;

    [ObservableProperty]
    private int _failedTopUps;

    [ObservableProperty]
    private ObservableCollection<BalanceResult> _balanceResults = new();

    [ObservableProperty]
    private string _balanceLog = "";

    [ObservableProperty]
    private string _selectedOperatorFilter = "all";

    [ObservableProperty]
    private decimal _totalGroupBalance;

    [ObservableProperty]
    private int _groupQuerySuccessCount;

    [ObservableProperty]
    private int _groupQueryFailCount;

    private int _commandId = 0;

    public MainViewModel()
    {
        Settings = AppSettings.Load();
        _modemService = new ModemService();
        _smsService = new SmsService(_modemService);
        _aiService = new AiAssistantService(Settings);
        _balanceQueryService = new BalanceQueryService(_modemService);
        _cardTopUpService = new CardTopUpService(_modemService);

        CustomUssd1 = Settings.General.QuickUssdCommands.ElementAtOrDefault(0) ?? "*100#";
        CustomUssd2 = Settings.General.QuickUssdCommands.ElementAtOrDefault(1) ?? "*101#";
        CustomUssd3 = Settings.General.QuickUssdCommands.ElementAtOrDefault(2) ?? "*102#";
        
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

            if (Settings.Ai.Enabled && Settings.Ai.AutoAnalyzeResponses && results.Any(r => r.IsSuccess))
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
            if (CommandHistory.Count > Settings.Ui.MaxHistoryItems)
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

        if (!Settings.Ai.Enabled || string.IsNullOrEmpty(Settings.Ai.ApiKey))
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

        if (!Settings.Ai.Enabled || string.IsNullOrEmpty(Settings.Ai.ApiKey))
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
        if (!Settings.Ai.Enabled || string.IsNullOrEmpty(Settings.Ai.ApiKey))
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
            Settings.General.QuickUssdCommands = new List<string> { CustomUssd1, CustomUssd2, CustomUssd3 };
            Settings.Save();
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

    [RelayCommand]
    private async Task StartListeningSmsAsync(Modem modem)
    {
        if (modem == null || !modem.IsConnected) return;

        if (modem.IsListeningSms)
        {
            // إيقاف الاستماع
            modem.IsListeningSms = false;
            modem.Status = "جاهز";
            StatusMessage = $"تم إيقاف الاستماع للرسائل على {modem.PortName}";
            return;
        }

        // بدء الاستماع
        modem.IsListeningSms = true;
        modem.Status = "يستمع للرسائل...";
        StatusMessage = $"بدء الاستماع للرسائل على {modem.PortName}";

        _ = Task.Run(async () =>
        {
            while (modem.IsListeningSms && modem.IsConnected)
            {
                try
                {
                    // جلب الرسائل الجديدة
                    var newMessages = await _smsService.GetUnreadMessagesAsync(modem.PortName, modem.Index);
                    
                    if (newMessages.Count > 0)
                    {
                        Application.Current.Dispatcher.Invoke(() =>
                        {
                            foreach (var msg in newMessages)
                            {
                                SmsMessages.Insert(0, msg);
                            }
                            
                            modem.UnreadSmsCount = newMessages.Count;
                            modem.LastResponse = $"📨 استلام {newMessages.Count} رسالة جديدة\n{newMessages[0].Message}";
                            modem.LastActivity = DateTime.Now;
                            TotalSmsCount += newMessages.Count;
                            
                            StatusMessage = $"📨 استلام {newMessages.Count} رسالة من {modem.PortName}";
                        });
                    }

                    // الانتظار 5 ثوانٍ قبل الفحص التالي
                    await Task.Delay(5000);
                }
                catch (Exception ex)
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        modem.LastError = ex.Message;
                        modem.Status = "خطأ في الاستماع";
                    });
                    await Task.Delay(10000); // انتظار أطول في حالة الخطأ
                }
            }

            Application.Current.Dispatcher.Invoke(() =>
            {
                modem.Status = "جاهز";
            });
        });
    }

    #region Orange Cash Commands

    [RelayCommand]
    private async Task QueryOrangeCashBalancesAsync()
    {
        if (string.IsNullOrEmpty(OrangeCashPassword))
        {
            StatusMessage = "الرجاء إدخال كلمة سر أورانج كاش";
            return;
        }

        try
        {
            IsProcessing = true;
            StatusMessage = "جاري استعلام أرصدة أورانج كاش...";
            TransferLog = "";

            var selectedModems = Modems.Where(m => m.IsConnected && m.IsSelected).ToList();
            
            if (selectedModems.Count == 0)
            {
                StatusMessage = "الرجاء تحديد المودمات للاستعلام";
                return;
            }

            var results = await _modemService.QueryAllOrangeCashBalancesAsync(selectedModems, OrangeCashPassword);
            
            TransferLog = "📊 نتائج استعلام الأرصدة:\n" + string.Join("\n", results);
            StatusMessage = $"تم استعلام {results.Count} مودم";
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
    private async Task ExecuteParallelTransfersAsync()
    {
        if (string.IsNullOrEmpty(OrangeCashPassword))
        {
            StatusMessage = "الرجاء إدخال كلمة سر أورانج كاش";
            return;
        }

        if (TransferAmount <= 0)
        {
            StatusMessage = "الرجاء إدخال مبلغ صحيح";
            return;
        }

        var connectedModems = Modems.Where(m => m.IsConnected).OrderBy(m => m.Index).ToList();
        
        if (connectedModems.Count < 2)
        {
            StatusMessage = "يجب توصيل مودمين على الأقل للتحويل";
            return;
        }

        try
        {
            IsTransferRunning = true;
            IsProcessing = true;
            SuccessfulTransfers = 0;
            FailedTransfers = 0;
            TransferLog = "🚀 بدء التحويل المتوازي...\n";

            var senderModems = connectedModems.Take(6).ToList();
            var receiverModems = connectedModems.Skip(6).Take(6).ToList();

            for (int i = 0; i < senderModems.Count; i++)
            {
                senderModems[i].IsSenderLine = true;
                senderModems[i].IsReceiverLine = false;
                senderModems[i].TransferStatus = "مرسل";
                
                if (i < receiverModems.Count)
                {
                    senderModems[i].PairedModemIndex = receiverModems[i].Index;
                }
            }

            foreach (var receiver in receiverModems)
            {
                receiver.IsReceiverLine = true;
                receiver.IsSenderLine = false;
                receiver.TransferStatus = "مستلم";
            }

            var transferPairs = new List<(Modem Sender, Modem Receiver)>();
            for (int i = 0; i < Math.Min(senderModems.Count, receiverModems.Count); i++)
            {
                transferPairs.Add((senderModems[i], receiverModems[i]));
                TransferLog += $"📍 زوج {i + 1}: {senderModems[i].PhoneNumber} → {receiverModems[i].PhoneNumber}\n";
            }

            if (transferPairs.Count == 0)
            {
                StatusMessage = "لا توجد أزواج للتحويل";
                return;
            }

            TransferLog += $"\n💰 المبلغ: {TransferAmount} ج.م لكل تحويل\n";
            TransferLog += $"⏳ جاري تنفيذ {transferPairs.Count} تحويل متوازي...\n\n";

            var results = await _modemService.ExecuteParallelOrangeCashTransfersAsync(
                transferPairs,
                OrangeCashPassword,
                TransferAmount,
                onSenderStatusUpdate: (modem, status) =>
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        TransferLog += $"📤 {modem.PhoneNumber}: {status}\n";
                    });
                },
                onReceiverStatusUpdate: (modem, status) =>
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        TransferLog += $"📥 {modem.PhoneNumber}: {status}\n";
                    });
                });

            SuccessfulTransfers = results.Count(r => r.Success);
            FailedTransfers = results.Count(r => !r.Success);

            TransferLog += $"\n━━━━━━━━━━━━━━━━━━━━━━\n";
            TransferLog += $"✅ نجح: {SuccessfulTransfers}\n";
            TransferLog += $"❌ فشل: {FailedTransfers}\n";

            if (SuccessfulTransfers > 0)
            {
                await StartCooldownAsync(8);
            }

            StatusMessage = $"اكتمل: {SuccessfulTransfers} نجح، {FailedTransfers} فشل";
        }
        catch (Exception ex)
        {
            StatusMessage = $"خطأ: {ex.Message}";
            TransferLog += $"\n❌ خطأ: {ex.Message}\n";
        }
        finally
        {
            IsTransferRunning = false;
            IsProcessing = false;
        }
    }

    private async Task StartCooldownAsync(int seconds)
    {
        IsCooldownActive = true;
        CooldownSeconds = seconds;
        TransferLog += $"\n⏱️ انتظار {seconds} ثانية قبل التحويل التالي...\n";

        while (CooldownSeconds > 0)
        {
            await Task.Delay(1000);
            CooldownSeconds--;
        }

        IsCooldownActive = false;
        TransferLog += "✓ انتهى وقت الانتظار\n";
    }

    [RelayCommand]
    private async Task RestartModemAsync(Modem modem)
    {
        if (modem == null || !modem.IsConnected) return;

        try
        {
            modem.Status = "جاري إعادة التشغيل...";
            StatusMessage = $"جاري إعادة تشغيل {modem.PortName}...";

            await _modemService.RestartModemAsync(modem.PortName);

            modem.Status = "جاهز";
            StatusMessage = $"تم إعادة تشغيل {modem.PortName}";
        }
        catch (Exception ex)
        {
            modem.Status = "خطأ";
            StatusMessage = $"خطأ: {ex.Message}";
        }
    }

    [RelayCommand]
    private void CopyPhoneNumber(Modem modem)
    {
        if (modem == null || string.IsNullOrEmpty(modem.PhoneNumber)) return;

        try
        {
            Clipboard.SetText(modem.PhoneNumber);
            StatusMessage = $"تم نسخ الرقم: {modem.PhoneNumber}";
        }
        catch (Exception ex)
        {
            StatusMessage = $"خطأ في النسخ: {ex.Message}";
        }
    }

    [RelayCommand]
    private void StopTransfers()
    {
        IsTransferRunning = false;
        TransferLog += "\n⛔ تم إيقاف التحويل\n";
        StatusMessage = "تم إيقاف التحويل";
    }

    [RelayCommand]
    private void ClearTransferLog()
    {
        TransferLog = "";
        SuccessfulTransfers = 0;
        FailedTransfers = 0;
    }

    [RelayCommand]
    private void SetupSenderReceiverPairs()
    {
        var connectedModems = Modems.Where(m => m.IsConnected).OrderBy(m => m.Index).ToList();
        
        if (connectedModems.Count < 2)
        {
            StatusMessage = "يجب توصيل مودمين على الأقل للتحويل";
            TransferLog = "⚠️ لا يوجد عدد كافي من المودمات المتصلة.\nيجب توصيل مودمين على الأقل.";
            return;
        }

        foreach (var modem in Modems)
        {
            modem.IsSenderLine = false;
            modem.IsReceiverLine = false;
            modem.TransferStatus = "";
            modem.ConfirmationMessage = "";
            modem.PairedModemIndex = 0;
        }

        var half = connectedModems.Count / 2;
        
        if (half == 0)
        {
            StatusMessage = "يجب توصيل مودمين على الأقل";
            return;
        }

        var senderCount = Math.Min(half, 6);
        var receiverCount = Math.Min(connectedModems.Count - half, 6);
        var pairCount = Math.Min(senderCount, receiverCount);

        for (int i = 0; i < pairCount; i++)
        {
            var sender = connectedModems[i];
            var receiver = connectedModems[half + i];
            
            sender.IsSenderLine = true;
            sender.TransferStatus = $"📤 مرسل → #{receiver.Index}";
            sender.PairedModemIndex = receiver.Index;
            
            receiver.IsReceiverLine = true;
            receiver.TransferStatus = $"📥 مستلم ← #{sender.Index}";
            receiver.PairedModemIndex = sender.Index;
        }

        TransferLog = "📋 تم إعداد الأزواج:\n";
        TransferLog += $"━━━━━━━━━━━━━━━━━━━━━━\n";
        for (int i = 0; i < pairCount; i++)
        {
            var sender = connectedModems[i];
            var receiver = connectedModems[half + i];
            var senderPhone = !string.IsNullOrEmpty(sender.PhoneNumber) && sender.PhoneNumber != "غير معروف" 
                ? sender.PhoneNumber : $"مودم {sender.Index}";
            var receiverPhone = !string.IsNullOrEmpty(receiver.PhoneNumber) && receiver.PhoneNumber != "غير معروف" 
                ? receiver.PhoneNumber : $"مودم {receiver.Index}";
            TransferLog += $"  #{sender.Index} → #{receiver.Index}\n";
            TransferLog += $"  {senderPhone} → {receiverPhone}\n\n";
        }
        TransferLog += $"━━━━━━━━━━━━━━━━━━━━━━\n";
        TransferLog += $"إجمالي الأزواج: {pairCount}\n";

        if (connectedModems.Count < 12)
        {
            TransferLog += $"\n⚠️ متصل {connectedModems.Count} مودم من أصل 12\n";
        }

        StatusMessage = $"تم إعداد {pairCount} زوج للتحويل ({connectedModems.Count} مودم متصل)";
    }

    #endregion

    #region TopUp Commands

    [RelayCommand]
    private async Task TopUpCardsAsync()
    {
        if (string.IsNullOrWhiteSpace(CardNumbers))
        {
            StatusMessage = "الرجاء إدخال أرقام الكروت";
            return;
        }

        var cards = CardNumbers.Split(new[] { '\n', '\r', ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(c => c.Trim())
            .Where(c => !string.IsNullOrEmpty(c))
            .ToList();

        if (cards.Count == 0)
        {
            StatusMessage = "الرجاء إدخال أرقام كروت صحيحة";
            return;
        }

        var selectedModems = Modems.Where(m => m.IsConnected && m.IsSelected && !m.IsBusy).ToList();
        if (selectedModems.Count == 0)
        {
            StatusMessage = "الرجاء تحديد مودمات للشحن";
            return;
        }

        try
        {
            IsProcessing = true;
            SuccessfulTopUps = 0;
            FailedTopUps = 0;
            TopUpLog = $"🔄 جاري شحن {cards.Count} كارت على {selectedModems.Count} مودم...\n";
            StatusMessage = "جاري الشحن...";

            var results = await _cardTopUpService.TopUpAllCardsAsync(
                selectedModems.ToList(),
                cards,
                (modem, status) => Application.Current.Dispatcher.Invoke(() => modem.Status = status),
                (modem, busy) => Application.Current.Dispatcher.Invoke(() => modem.IsBusy = busy)
            );

            foreach (var result in results)
            {
                if (result.IsSuccess)
                {
                    SuccessfulTopUps++;
                    TopUpLog += $"✅ {result.PhoneNumber}: تم الشحن - الرصيد الجديد: {result.NewBalance}\n";
                }
                else
                {
                    FailedTopUps++;
                    TopUpLog += $"❌ {result.PhoneNumber}: فشل - {result.ErrorMessage}\n";
                }
            }

            StatusMessage = $"تم الشحن: {SuccessfulTopUps} نجح، {FailedTopUps} فشل";
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
    private void ClearTopUpLog()
    {
        TopUpLog = "";
        CardNumbers = "";
        SuccessfulTopUps = 0;
        FailedTopUps = 0;
    }

    #endregion

    #region Balance Query Commands

    [RelayCommand]
    private async Task QueryAllBalancesAsync()
    {
        var selectedModems = Modems.Where(m => m.IsConnected && m.IsSelected && !m.IsBusy).ToList();
        if (selectedModems.Count == 0)
        {
            StatusMessage = "الرجاء تحديد مودمات للاستعلام";
            return;
        }

        try
        {
            IsProcessing = true;
            BalanceResults.Clear();
            BalanceLog = $"🔄 جاري استعلام رصيد {selectedModems.Count} خط...\n";
            StatusMessage = "جاري استعلام الأرصدة...";

            var results = await _balanceQueryService.QueryAllBalancesAsync(
                selectedModems.ToList(),
                (modem, status) => Application.Current.Dispatcher.Invoke(() => modem.Status = status),
                (modem, result) => Application.Current.Dispatcher.Invoke(() => BalanceResults.Add(result)),
                (modem, busy) => Application.Current.Dispatcher.Invoke(() => modem.IsBusy = busy)
            );

            var successCount = results.Count(r => r.IsSuccess);
            var failCount = results.Count - successCount;
            
            BalanceLog = "📊 نتائج الاستعلام:\n━━━━━━━━━━━━━━━━━━━━━━\n";
            foreach (var result in results)
            {
                if (result.IsSuccess)
                {
                    BalanceLog += $"✅ {result.PhoneNumber} ({result.Operator}):\n";
                    BalanceLog += $"   الرصيد: {result.MainBalance} ج.م\n";
                    if (!string.IsNullOrEmpty(result.BonusBalance)) BalanceLog += $"   البونص: {result.BonusBalance} ج.م\n";
                    if (!string.IsNullOrEmpty(result.DataBalance)) BalanceLog += $"   البيانات: {result.DataBalance}\n";
                    if (!string.IsNullOrEmpty(result.ExpiryDate)) BalanceLog += $"   الصلاحية: {result.ExpiryDate}\n";
                }
                else
                {
                    BalanceLog += $"❌ {result.PhoneNumber}: {result.ErrorMessage}\n";
                }
            }

            StatusMessage = $"تم الاستعلام: {successCount} نجح، {failCount} فشل";
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
    private void ClearBalanceLog()
    {
        BalanceLog = "";
        BalanceResults.Clear();
    }

    #endregion

    #region Group Balance Query Commands

    [RelayCommand]
    private async Task QueryGroupBalancesAsync()
    {
        var selectedModems = Modems.Where(m => m.IsConnected && m.IsSelected && !m.IsBusy).ToList();
        if (selectedModems.Count == 0)
        {
            StatusMessage = "الرجاء تحديد مودمات للاستعلام الجماعي";
            return;
        }

        try
        {
            IsProcessing = true;
            GroupQuerySuccessCount = 0;
            GroupQueryFailCount = 0;
            TotalGroupBalance = 0;
            BalanceLog = $"🔄 جاري الاستعلام الجماعي عن {selectedModems.Count} خط";
            if (SelectedOperatorFilter != "all")
                BalanceLog += $" (فلتر: {SelectedOperatorFilter})";
            BalanceLog += "...\n";
            StatusMessage = "جاري الاستعلام الجماعي...";

            var groupResult = await _balanceQueryService.QueryGroupBalancesAsync(
                selectedModems.ToList(),
                SelectedOperatorFilter
            );

            TotalGroupBalance = groupResult.TotalBalance;
            GroupQuerySuccessCount = groupResult.SuccessfulQueries;
            GroupQueryFailCount = groupResult.TotalModems - groupResult.SuccessfulQueries;

            BalanceLog = "📊 نتائج الاستعلام الجماعي:\n";
            BalanceLog += "━━━━━━━━━━━━━━━━━━━━━━\n";
            BalanceLog += $"📱 إجمالي الخطوط: {groupResult.TotalModems}\n";
            BalanceLog += $"✅ نجح: {groupResult.SuccessfulQueries}\n";
            BalanceLog += $"❌ فشل: {groupResult.TotalModems - groupResult.SuccessfulQueries}\n";
            BalanceLog += "━━━━━━━━━━━━━━━━━━━━━━\n";
            BalanceLog += $"💰 إجمالي الأرصدة: {groupResult.TotalBalance:F2} ج.م\n";
            BalanceLog += $"📊 متوسط الرصيد: {groupResult.AverageBalance:F2} ج.م\n";
            BalanceLog += "━━━━━━━━━━━━━━━━━━━━━━\n\n";
            
            BalanceLog += "📋 التفاصيل:\n";
            foreach (var result in groupResult.BalanceResults)
            {
                if (result.IsSuccess)
                {
                    BalanceLog += $"  {result.PhoneNumber}: {result.MainBalance:F2} ج.م\n";
                }
                else
                {
                    BalanceLog += $"  {result.PhoneNumber}: ❌ {result.ErrorMessage}\n";
                }
            }

            StatusMessage = $"إجمالي الأرصدة: {groupResult.TotalBalance:F2} ج.م ({groupResult.SuccessfulQueries}/{groupResult.TotalModems} نجح)";
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
    private void ClearGroupBalanceLog()
    {
        BalanceLog = "";
        TotalGroupBalance = 0;
        GroupQuerySuccessCount = 0;
        GroupQueryFailCount = 0;
    }

    #endregion
}
