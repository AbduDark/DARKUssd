using System.Collections.ObjectModel;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class OcSeriesService
{
    private readonly ModemService _modemService;
    private CancellationTokenSource? _cancellationTokenSource;
    
    public event EventHandler<string>? LogUpdated;
    public event EventHandler<OcTransferResult>? TransferCompleted;
    public event EventHandler<int>? CountdownTick;
    
    public bool IsRunning { get; private set; }
    
    public OcSeriesService(ModemService modemService)
    {
        _modemService = modemService;
    }
    
    public async Task<List<OcTransferResult>> ExecuteSeriesTransfersAsync(
        List<OcSeriesTransferItem> transferItems,
        string password,
        int delayBetweenTransfers = 12,
        CancellationToken cancellationToken = default)
    {
        var results = new List<OcTransferResult>();
        IsRunning = true;
        
        try
        {
            for (int i = 0; i < transferItems.Count; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    LogUpdated?.Invoke(this, "⏹ تم إيقاف التحويل بناءً على طلب المستخدم");
                    break;
                }
                
                var item = transferItems[i];
                LogUpdated?.Invoke(this, $"━━━━━━━━━━━━━━━━━━━━━━━━");
                LogUpdated?.Invoke(this, $"📤 تحويل {i + 1}/{transferItems.Count}");
                LogUpdated?.Invoke(this, $"   من: {item.SenderModem.PhoneNumber} ({item.SenderModem.PortName})");
                LogUpdated?.Invoke(this, $"   إلى: {item.ReceiverPhone}");
                LogUpdated?.Invoke(this, $"   المبلغ: {item.Amount} ج.م");
                
                item.SenderModem.TransferStatus = "جاري التحويل...";
                
                var (success, message) = await _modemService.ExecuteOrangeCashTransferAsync(
                    item.SenderModem.PortName,
                    password,
                    item.ReceiverPhone,
                    item.Amount);
                
                var result = new OcTransferResult
                {
                    SenderPhone = item.SenderModem.PhoneNumber ?? "غير معروف",
                    ReceiverPhone = item.ReceiverPhone,
                    Amount = item.Amount,
                    Success = success,
                    Message = message,
                    Timestamp = DateTime.Now
                };
                
                results.Add(result);
                TransferCompleted?.Invoke(this, result);
                
                if (success)
                {
                    item.SenderModem.TransferStatus = "تم التحويل ✓";
                    LogUpdated?.Invoke(this, $"   ✅ نجح: {message}");
                }
                else
                {
                    item.SenderModem.TransferStatus = "فشل ✗";
                    LogUpdated?.Invoke(this, $"   ❌ فشل: {message}");
                }
                
                if (i < transferItems.Count - 1 && !cancellationToken.IsCancellationRequested)
                {
                    LogUpdated?.Invoke(this, $"\n⏳ انتظار {delayBetweenTransfers} ثانية قبل التحويل التالي...");
                    
                    for (int sec = delayBetweenTransfers; sec > 0; sec--)
                    {
                        if (cancellationToken.IsCancellationRequested) break;
                        CountdownTick?.Invoke(this, sec);
                        await Task.Delay(1000, cancellationToken);
                    }
                    CountdownTick?.Invoke(this, 0);
                }
            }
            
            var successCount = results.Count(r => r.Success);
            var failCount = results.Count(r => !r.Success);
            
            LogUpdated?.Invoke(this, $"\n━━━━━━━━━━━━━━━━━━━━━━━━");
            LogUpdated?.Invoke(this, $"📊 النتيجة النهائية:");
            LogUpdated?.Invoke(this, $"   ✅ نجح: {successCount}");
            LogUpdated?.Invoke(this, $"   ❌ فشل: {failCount}");
            LogUpdated?.Invoke(this, $"   💰 إجمالي المحول: {results.Where(r => r.Success).Sum(r => r.Amount)} ج.م");
        }
        catch (OperationCanceledException)
        {
            LogUpdated?.Invoke(this, "⏹ تم إلغاء العملية");
        }
        catch (Exception ex)
        {
            LogUpdated?.Invoke(this, $"❌ خطأ: {ex.Message}");
        }
        finally
        {
            IsRunning = false;
        }
        
        return results;
    }
    
    public void Stop()
    {
        _cancellationTokenSource?.Cancel();
        IsRunning = false;
    }
}

public class OcSeriesTransferItem
{
    public Modem SenderModem { get; set; } = null!;
    public string ReceiverPhone { get; set; } = "";
    public int Amount { get; set; }
    public int Order { get; set; }
}

public class OcTransferResult
{
    public string SenderPhone { get; set; } = "";
    public string ReceiverPhone { get; set; } = "";
    public int Amount { get; set; }
    public bool Success { get; set; }
    public string Message { get; set; } = "";
    public DateTime Timestamp { get; set; }
}

public class ExcelTransferItem
{
    public string PhoneNumber { get; set; } = "";
    public int Amount { get; set; }
    public string Status { get; set; } = "في الانتظار";
    public string Result { get; set; } = "";
}
