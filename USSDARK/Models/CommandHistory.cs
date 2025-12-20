using CommunityToolkit.Mvvm.ComponentModel;

namespace USSDARK.Models;

public partial class CommandHistory : ObservableObject
{
    [ObservableProperty]
    private int _id;

    [ObservableProperty]
    private string _command = string.Empty;

    [ObservableProperty]
    private string _response = string.Empty;

    [ObservableProperty]
    private string _modemPort = string.Empty;

    [ObservableProperty]
    private int _modemIndex;

    [ObservableProperty]
    private DateTime _timestamp;

    [ObservableProperty]
    private bool _isSuccess;

    [ObservableProperty]
    private TimeSpan _executionTime;

    [ObservableProperty]
    private CommandType _commandType;
}

public enum CommandType
{
    AT,
    USSD,
    SMS,
    Query,
    Config
}
