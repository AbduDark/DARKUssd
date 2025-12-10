using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Threading;

namespace ModemPoolManager.Models;

public partial class OtpResult : ObservableObject
{
    [ObservableProperty]
    private int _modemIndex;

    [ObservableProperty]
    private string _portName = string.Empty;

    [ObservableProperty]
    private string _phoneNumber = string.Empty;

    [ObservableProperty]
    private string _otpCode = string.Empty;

    [ObservableProperty]
    private int _amount;

    [ObservableProperty]
    private string _operatorName = string.Empty;

    [ObservableProperty]
    private bool _isWithdrawn;

    [ObservableProperty]
    private bool _isExpired;

    [ObservableProperty]
    private bool _isSuccess;

    [ObservableProperty]
    private string _errorMessage = string.Empty;

    [ObservableProperty]
    private string _rawResponse = string.Empty;

    [ObservableProperty]
    private DateTime _generatedAt;

    [ObservableProperty]
    private DateTime _expiresAt;

    [ObservableProperty]
    private int _remainingSeconds;

    [ObservableProperty]
    private string _remainingTimeDisplay = string.Empty;

    private DispatcherTimer? _countdownTimer;

    public int ExpiryMinutes => OperatorName.ToLower() switch
    {
        "orange" => 3,
        "vodafone" => 15,
        "etisalat" => 15,
        _ => 15
    };

    public void StartCountdown()
    {
        GeneratedAt = DateTime.Now;
        ExpiresAt = GeneratedAt.AddMinutes(ExpiryMinutes);
        UpdateRemainingTime();

        _countdownTimer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(1)
        };
        _countdownTimer.Tick += (s, e) =>
        {
            UpdateRemainingTime();
            if (RemainingSeconds <= 0)
            {
                IsExpired = true;
                _countdownTimer?.Stop();
            }
        };
        _countdownTimer.Start();
    }

    public void StopCountdown()
    {
        _countdownTimer?.Stop();
        _countdownTimer = null;
    }

    private void UpdateRemainingTime()
    {
        var remaining = ExpiresAt - DateTime.Now;
        if (remaining.TotalSeconds <= 0)
        {
            RemainingSeconds = 0;
            RemainingTimeDisplay = "00:00";
            IsExpired = true;
        }
        else
        {
            RemainingSeconds = (int)remaining.TotalSeconds;
            RemainingTimeDisplay = $"{(int)remaining.TotalMinutes:D2}:{remaining.Seconds:D2}";
        }
    }
}
