using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ModemPoolManager.Models;

public partial class Modem : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<SmsMessage> _smsMessages = new();

    [ObservableProperty]
    private SmsMessage? _selectedSmsMessage;

    [ObservableProperty]
    private bool _isSmsPopupOpen;
    [ObservableProperty]
    private int _index;

    [ObservableProperty]
    private string _portName = string.Empty;

    [ObservableProperty]
    private string _phoneNumber = string.Empty;

    [ObservableProperty]
    private string _status = "غير متصل";

    [ObservableProperty]
    private string _lastResponse = string.Empty;

    [ObservableProperty]
    private bool _isConnected;

    [ObservableProperty]
    private bool _isSelected = true;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SignalBars))]
    [NotifyPropertyChangedFor(nameof(SignalColor))]
    private string _signalStrength = "N/A";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(SignalBars))]
    [NotifyPropertyChangedFor(nameof(SignalColor))]
    private int _signalLevel;

    [ObservableProperty]
    private string _operator = "N/A";

    [ObservableProperty]
    private string _networkMode = "N/A";

    public int SignalBars => SignalLevel switch
    {
        >= 20 => 5,
        >= 15 => 4,
        >= 10 => 3,
        >= 5 => 2,
        >= 1 => 1,
        _ => 0
    };

    public string SignalColor => SignalBars switch
    {
        5 => "#3FB950",
        4 => "#56D364",
        3 => "#D29922",
        2 => "#F0883E",
        1 => "#DA3633",
        _ => "#484F58"
    };

    [ObservableProperty]
    private ModemInfo _info = new();

    [ObservableProperty]
    private int _unreadSmsCount;

    [ObservableProperty]
    private bool _isBusy;

    [ObservableProperty]
    private string _lastError = string.Empty;

    [ObservableProperty]
    private DateTime _lastActivity;

    [ObservableProperty]
    private int _successfulCommands;

    [ObservableProperty]
    private int _failedCommands;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ResponseDurationText))]
    private TimeSpan _lastResponseDuration;

    [ObservableProperty]
    private DateTime _lastResponseTime;

    [ObservableProperty]
    private bool _isListeningSms;

    [ObservableProperty]
    private string _cashBalance = "";

    [ObservableProperty]
    private string _transferStatus = "";

    [ObservableProperty]
    private string _confirmationMessage = "";

    [ObservableProperty]
    private int _pairedModemIndex;

    [ObservableProperty]
    private bool _isSenderLine;

    [ObservableProperty]
    private bool _isReceiverLine;

    [ObservableProperty]
    private bool _isMainLine;

    public double SuccessRate => SuccessfulCommands + FailedCommands > 0 
        ? (double)SuccessfulCommands / (SuccessfulCommands + FailedCommands) * 100 
        : 0;

    public string ResponseDurationText => LastResponseDuration.TotalMilliseconds > 0 
        ? $"{LastResponseDuration.TotalSeconds:F1}s" 
        : "";

    public string DisplayName => !string.IsNullOrEmpty(PhoneNumber) && PhoneNumber != "غير معروف" 
        ? PhoneNumber 
        : $"مودم {Index}";

    public string DisplayBalance => !string.IsNullOrEmpty(CashBalance) 
        ? $"💰 {CashBalance}" 
        : PortName;
}
