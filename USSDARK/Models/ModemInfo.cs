using CommunityToolkit.Mvvm.ComponentModel;

namespace USSDARK.Models;

public partial class ModemInfo : ObservableObject
{
    [ObservableProperty]
    private string _imei = string.Empty;

    [ObservableProperty]
    private string _imsi = string.Empty;

    [ObservableProperty]
    private string _iccid = string.Empty;

    [ObservableProperty]
    private string _manufacturer = string.Empty;

    [ObservableProperty]
    private string _model = string.Empty;

    [ObservableProperty]
    private string _firmwareVersion = string.Empty;

    [ObservableProperty]
    private string _simStatus = string.Empty;

    [ObservableProperty]
    private string _networkStatus = string.Empty;

    [ObservableProperty]
    private string _networkType = string.Empty;

    [ObservableProperty]
    private int _signalBars;

    [ObservableProperty]
    private int _signalDbm;

    [ObservableProperty]
    private double _signalPercent;

    [ObservableProperty]
    private string _operatorName = string.Empty;

    [ObservableProperty]
    private string _operatorCode = string.Empty;

    [ObservableProperty]
    private bool _isRoaming;

    [ObservableProperty]
    private DateTime _lastUpdated;
}
