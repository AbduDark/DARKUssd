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
    public event EventHandler<decimal>? MainLineBalanceUpdated;
    
    public bool IsRunning { get; private set; }
    
    public OcSeriesService(ModemService modemService)
    {
        _modemService = modemService;
    }
    
    public async Task<List<OcTransferResult>> ExecuteChainedTransfersAsync(
        Modem mainLineModem,
        List<Modem> recipientModems,
        string password,
        int remainingPerModem,
        decimal initialMainLineBalance,
        int delayBetweenTransfers = 12,
        CancellationToken cancellationToken = default)
    {
        var results = new List<OcTransferResult>();
        IsRunning = true;
        
        try
        {
            int modemCount = recipientModems.Count;
            int totalToTransfer = modemCount * remainingPerModem;
            
            LogUpdated?.Invoke(this, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            LogUpdated?.Invoke(this, "🔗 بدء التحويل المتسلسل (Chain Transfer)");
            LogUpdated?.Invoke(this, $"📱 الخط الأساسي: {mainLineModem.PhoneNumber} ({mainLineModem.PortName})");
            LogUpdated?.Invoke(this, $"💰 رصيد الأساسي: {initialMainLineBalance} ج.م");
            LogUpdated?.Invoke(this, $"📊 عدد المودمات المستلمة: {modemCount}");
            LogUpdated?.Invoke(this, $"💵 المبلغ المتبقي لكل مودم: {remainingPerModem} ج.م");
            LogUpdated?.Invoke(this, $"💸 إجمالي التحويل من الأساسي: {totalToTransfer} ج.م");
            LogUpdated?.Invoke(this, "━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            
            if (initialMainLineBalance < totalToTransfer)
            {
                LogUpdated?.Invoke(this, $"⚠️ تحذير: رصيد الأساسي ({initialMainLineBalance}) أقل من المطلوب ({totalToTransfer})");
                LogUpdated?.Invoke(this, "⏹ تم إيقاف التحويل - رصيد غير كافي");
                return results;
            }
            
            decimal currentMainLineBalance = initialMainLineBalance;
            
            mainLineModem.TransferStatus = "جاري التحويل...";
            var firstRecipient = recipientModems[0];
            
            LogUpdated?.Invoke(this, $"\n📤 الخطوة 1: الأساسي → مودم 1");
            LogUpdated?.Invoke(this, $"   من: {mainLineModem.PhoneNumber}");
            LogUpdated?.Invoke(this, $"   إلى: {firstRecipient.PhoneNumber}");
            LogUpdated?.Invoke(this, $"   المبلغ: {totalToTransfer} ج.م");
            
            var (success, message, rawResponse) = await _modemService.ExecuteOrangeCashTransferAsync(
                mainLineModem.PortName,
                password,
                firstRecipient.PhoneNumber!,
                totalToTransfer);
            
            var mainTransferResult = new OcTransferResult
            {
                SenderPhone = mainLineModem.PhoneNumber ?? "غير معروف",
                ReceiverPhone = firstRecipient.PhoneNumber ?? "غير معروف",
                Amount = totalToTransfer,
                Success = success,
                Message = message,
                RawResponse = rawResponse,
                Timestamp = DateTime.Now,
                IsMainLineTransfer = true
            };
            
            results.Add(mainTransferResult);
            TransferCompleted?.Invoke(this, mainTransferResult);
            
            LogUpdated?.Invoke(this, $"   📨 رد الشبكة: {rawResponse}");
            
            if (success)
            {
                currentMainLineBalance -= totalToTransfer;
                MainLineBalanceUpdated?.Invoke(this, currentMainLineBalance);
                mainLineModem.TransferStatus = $"تم ✓ (الرصيد: {currentMainLineBalance})";
                LogUpdated?.Invoke(this, $"   ✅ نجح - الرصيد المتبقي: {currentMainLineBalance} ج.م");
                
                firstRecipient.TransferStatus = $"استلم {totalToTransfer} ج.م";
            }
            else
            {
                mainLineModem.TransferStatus = "فشل ✗";
                LogUpdated?.Invoke(this, $"   ❌ فشل: {message}");
                LogUpdated?.Invoke(this, "⏹ تم إيقاف السلسلة بسبب فشل التحويل الأول");
                return results;
            }
            
            int amountToForward = totalToTransfer - remainingPerModem;
            
            for (int i = 0; i < recipientModems.Count - 1; i++)
            {
                if (cancellationToken.IsCancellationRequested)
                {
                    LogUpdated?.Invoke(this, "\n⏹ تم إيقاف التحويل بناءً على طلب المستخدم");
                    break;
                }
                
                LogUpdated?.Invoke(this, $"\n⏳ انتظار {delayBetweenTransfers} ثانية قبل التحويل التالي...");
                for (int sec = delayBetweenTransfers; sec > 0; sec--)
                {
                    if (cancellationToken.IsCancellationRequested) break;
                    CountdownTick?.Invoke(this, sec);
                    await Task.Delay(1000, cancellationToken);
                }
                CountdownTick?.Invoke(this, 0);
                
                if (cancellationToken.IsCancellationRequested) break;
                
                var sender = recipientModems[i];
                var receiver = recipientModems[i + 1];
                
                LogUpdated?.Invoke(this, $"\n📤 الخطوة {i + 2}: مودم {i + 1} → مودم {i + 2}");
                LogUpdated?.Invoke(this, $"   من: {sender.PhoneNumber}");
                LogUpdated?.Invoke(this, $"   إلى: {receiver.PhoneNumber}");
                LogUpdated?.Invoke(this, $"   المبلغ: {amountToForward} ج.م (يحتفظ بـ {remainingPerModem})");
                
                sender.TransferStatus = "جاري التحويل...";
                
                var (chainSuccess, chainMessage, chainRawResponse) = await _modemService.ExecuteOrangeCashTransferAsync(
                    sender.PortName,
                    password,
                    receiver.PhoneNumber!,
                    amountToForward);
                
                var chainResult = new OcTransferResult
                {
                    SenderPhone = sender.PhoneNumber ?? "غير معروف",
                    ReceiverPhone = receiver.PhoneNumber ?? "غير معروف",
                    Amount = amountToForward,
                    Success = chainSuccess,
                    Message = chainMessage,
                    RawResponse = chainRawResponse,
                    Timestamp = DateTime.Now,
                    KeptAmount = remainingPerModem,
                    ForwardedAmount = amountToForward
                };
                
                results.Add(chainResult);
                TransferCompleted?.Invoke(this, chainResult);
                
                LogUpdated?.Invoke(this, $"   📨 رد الشبكة: {chainRawResponse}");
                
                if (chainSuccess)
                {
                    sender.TransferStatus = $"احتفظ بـ {remainingPerModem} ✓";
                    receiver.TransferStatus = $"استلم {amountToForward} ج.م";
                    LogUpdated?.Invoke(this, $"   ✅ نجح - {sender.PhoneNumber} احتفظ بـ {remainingPerModem} ج.م");
                    
                    amountToForward -= remainingPerModem;
                }
                else
                {
                    sender.TransferStatus = "فشل ✗";
                    LogUpdated?.Invoke(this, $"   ❌ فشل: {chainMessage}");
                    LogUpdated?.Invoke(this, "⏹ تم إيقاف السلسلة - لا يمكن المتابعة بدون استلام المبلغ");
                    
                    for (int j = i + 1; j < recipientModems.Count; j++)
                    {
                        recipientModems[j].TransferStatus = "ملغى (لم يتم الوصول)";
                    }
                    break;
                }
            }
            
            var lastModem = recipientModems[recipientModems.Count - 1];
            if (lastModem.TransferStatus?.StartsWith("استلم") == true)
            {
                lastModem.TransferStatus = $"احتفظ بـ {remainingPerModem} ✓ (الأخير)";
            }
            
            var successCount = results.Count(r => r.Success);
            var failCount = results.Count(r => !r.Success);
            var totalTransferred = results.Where(r => r.Success).Sum(r => r.Amount);
            
            LogUpdated?.Invoke(this, $"\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
            LogUpdated?.Invoke(this, $"📊 النتيجة النهائية:");
            LogUpdated?.Invoke(this, $"   ✅ نجح: {successCount}");
            LogUpdated?.Invoke(this, $"   ❌ فشل: {failCount}");
            LogUpdated?.Invoke(this, $"   💰 رصيد الأساسي المتبقي: {currentMainLineBalance} ج.م");
            LogUpdated?.Invoke(this, $"   💵 كل مودم احتفظ بـ: {remainingPerModem} ج.م");
        }
        catch (OperationCanceledException)
        {
            LogUpdated?.Invoke(this, "\n⏹ تم إلغاء العملية");
        }
        catch (Exception ex)
        {
            LogUpdated?.Invoke(this, $"\n❌ خطأ: {ex.Message}");
        }
        finally
        {
            IsRunning = false;
        }
        
        return results;
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
                
                var (success, message, rawResponse) = await _modemService.ExecuteOrangeCashTransferAsync(
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
                    RawResponse = rawResponse,
                    Timestamp = DateTime.Now
                };
                
                results.Add(result);
                TransferCompleted?.Invoke(this, result);
                
                LogUpdated?.Invoke(this, $"   📨 رد الشبكة: {rawResponse}");
                
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
    public string RawResponse { get; set; } = "";
    public DateTime Timestamp { get; set; }
    public bool IsMainLineTransfer { get; set; }
    public int KeptAmount { get; set; }
    public int ForwardedAmount { get; set; }
}

public class ExcelTransferItem
{
    public string PhoneNumber { get; set; } = "";
    public int Amount { get; set; }
    public string Status { get; set; } = "في الانتظار";
    public string Result { get; set; } = "";
}
