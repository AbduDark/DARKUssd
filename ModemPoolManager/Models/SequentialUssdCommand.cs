using CommunityToolkit.Mvvm.ComponentModel;

namespace ModemPoolManager.Models;

public partial class SequentialUssdCommand : ObservableObject
{
    [ObservableProperty]
    private int _order;
    
    [ObservableProperty]
    private string _command = "";
    
    [ObservableProperty]
    private bool _isReply;
    
    [ObservableProperty]
    private string? _response;
    
    [ObservableProperty]
    private bool _isExecuted;
    
    [ObservableProperty]
    private bool _isSuccess;
    
    [ObservableProperty]
    private string? _errorMessage;
}
