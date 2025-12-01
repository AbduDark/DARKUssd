using CommunityToolkit.Mvvm.ComponentModel;

namespace ModemPoolManager.Models;

public partial class Modem : ObservableObject
{
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
    private string _signalStrength = "N/A";

    [ObservableProperty]
    private string _operator = "N/A";

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

    public double SuccessRate => SuccessfulCommands + FailedCommands > 0 
        ? (double)SuccessfulCommands / (SuccessfulCommands + FailedCommands) * 100 
        : 0;
}
