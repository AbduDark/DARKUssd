using CommunityToolkit.Mvvm.ComponentModel;

namespace ModemPoolManager.Models;

public partial class SmsMessage : ObservableObject
{
    [ObservableProperty]
    private int _index;

    [ObservableProperty]
    private string _phoneNumber = string.Empty;

    [ObservableProperty]
    private string _message = string.Empty;

    [ObservableProperty]
    private DateTime _timestamp;

    [ObservableProperty]
    private SmsStatus _status;

    [ObservableProperty]
    private SmsDirection _direction;

    [ObservableProperty]
    private string _modemPort = string.Empty;

    [ObservableProperty]
    private int _modemIndex;
}

public enum SmsStatus
{
    Unread,
    Read,
    Sent,
    Unsent,
    Failed
}

public enum SmsDirection
{
    Incoming,
    Outgoing
}
