using CommunityToolkit.Mvvm.ComponentModel;

namespace USSDARK.Models;

public partial class TransferLogEntry : ObservableObject
{
    [ObservableProperty]
    private string _phoneNumber = string.Empty;

    [ObservableProperty]
    private string _message = string.Empty;

    [ObservableProperty]
    private bool _isSuccess;

    [ObservableProperty]
    private string _rawResponse = string.Empty;

    [ObservableProperty]
    private DateTime _timestamp = DateTime.Now;

    public string StatusColor => IsSuccess ? "#FF7900" : "#DA3633";
    
    public string StatusIcon => IsSuccess ? "✓" : "✗";
}
