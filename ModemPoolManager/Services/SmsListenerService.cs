using System.Collections.Concurrent;
using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using System.Timers;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class SmsListenerService : IDisposable
{
    private readonly ModemService _modemService;
    private readonly SmsService _smsService;
    private readonly ConcurrentDictionary<string, DateTime> _lastCheckedTimes = new();
    private readonly ConcurrentDictionary<string, int> _lastSmsCount = new();
    private System.Timers.Timer? _pollingTimer;
    private bool _isListening;
    private int _pollingIntervalMs = 3000;

    public event EventHandler<SmsMessage>? NewSmsReceived;
    public event EventHandler<(string PortName, int Count)>? SmsCountChanged;
    public event EventHandler<string>? ListenerStatusChanged;

    public bool IsListening => _isListening;
    public int PollingIntervalMs
    {
        get => _pollingIntervalMs;
        set => _pollingIntervalMs = Math.Max(1000, Math.Min(30000, value));
    }

    public SmsListenerService(ModemService modemService, SmsService smsService)
    {
        _modemService = modemService;
        _smsService = smsService;
    }

    public void StartListening()
    {
        if (_isListening) return;
        _isListening = true;

        _pollingTimer = new System.Timers.Timer(_pollingIntervalMs);
        _pollingTimer.Elapsed += async (s, e) => await PollForNewMessagesAsync();
        _pollingTimer.AutoReset = true;
        _pollingTimer.Start();

        ListenerStatusChanged?.Invoke(this, "بدء الاستماع للرسائل الواردة...");
        Console.WriteLine("[SmsListener] بدء الاستماع للرسائل");

        Task.Run(async () =>
        {
            try
            {
                await EnableNewMessageIndicationsAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SmsListener] خطأ في تفعيل الإشعارات: {ex.Message}");
            }
        });
    }

    public void StopListening()
    {
        if (!_isListening) return;
        _isListening = false;

        _pollingTimer?.Stop();
        _pollingTimer?.Dispose();
        _pollingTimer = null;

        ListenerStatusChanged?.Invoke(this, "تم إيقاف الاستماع");
        Console.WriteLine("[SmsListener] تم إيقاف الاستماع");
    }

    private async Task EnableNewMessageIndicationsAsync()
    {
        var activeModems = _modemService.GetActiveModems();
        var tasks = activeModems.Select(async modem =>
        {
            try
            {
                await _modemService.SendATCommandPublicAsync(modem.PortName, "AT+CMGF=1", 2000);
                await _modemService.SendATCommandPublicAsync(modem.PortName, "AT+CNMI=2,1,0,0,0", 2000);
                Console.WriteLine($"[SmsListener] تم تفعيل إشعارات الرسائل على {modem.PortName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SmsListener] فشل تفعيل CNMI على {modem.PortName}: {ex.Message}");
            }
        });

        await Task.WhenAll(tasks);
    }

    private async Task PollForNewMessagesAsync()
    {
        if (!_isListening) return;

        var activeModems = _modemService.GetActiveModems().ToList();
        if (activeModems.Count == 0) return;

        var tasks = activeModems.Select(async modem =>
        {
            if (modem.IsBusy) return;

            try
            {
                var messages = await _smsService.GetUnreadMessagesAsync(modem.PortName, modem.Index);
                
                var lastChecked = _lastCheckedTimes.GetOrAdd(modem.PortName, DateTime.MinValue);
                var lastCount = _lastSmsCount.GetOrAdd(modem.PortName, 0);
                
                var newMessages = messages.Where(m => m.Timestamp > lastChecked).ToList();
                
                if (newMessages.Any())
                {
                    foreach (var msg in newMessages)
                    {
                        Console.WriteLine($"[SmsListener] رسالة جديدة من {msg.PhoneNumber} على {modem.PortName}");
                        NewSmsReceived?.Invoke(this, msg);
                    }
                    
                    _lastCheckedTimes[modem.PortName] = DateTime.Now;
                }

                if (messages.Count != lastCount)
                {
                    _lastSmsCount[modem.PortName] = messages.Count;
                    modem.UnreadSmsCount = messages.Count;
                    SmsCountChanged?.Invoke(this, (modem.PortName, messages.Count));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[SmsListener] خطأ في فحص الرسائل على {modem.PortName}: {ex.Message}");
            }
        });

        await Task.WhenAll(tasks);
    }

    public async Task<List<SmsMessage>> GetAllMessagesFromAllModemsAsync()
    {
        var allMessages = new List<SmsMessage>();
        var activeModems = _modemService.GetActiveModems().ToList();

        var tasks = activeModems.Select(async modem =>
        {
            try
            {
                var messages = await _smsService.GetAllMessagesAsync(modem.PortName, modem.Index);
                return messages;
            }
            catch
            {
                return new List<SmsMessage>();
            }
        });

        var results = await Task.WhenAll(tasks);
        foreach (var messages in results)
        {
            allMessages.AddRange(messages);
        }

        return allMessages.OrderByDescending(m => m.Timestamp).ToList();
    }

    public async Task<int> GetTotalUnreadCountAsync()
    {
        var activeModems = _modemService.GetActiveModems().ToList();
        var tasks = activeModems.Select(async modem =>
        {
            try
            {
                return await _smsService.GetUnreadCountAsync(modem.PortName);
            }
            catch
            {
                return 0;
            }
        });

        var results = await Task.WhenAll(tasks);
        return results.Sum();
    }

    public void ResetState()
    {
        _lastCheckedTimes.Clear();
        _lastSmsCount.Clear();
    }

    public void Dispose()
    {
        StopListening();
    }
}
