using System;
using System.Threading;
using System.Threading.Tasks;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

public class RetryService
{
    private readonly RetrySettings _settings;
    
    public event EventHandler<RetryEventArgs>? OnRetryAttempt;
    public event EventHandler<RetryEventArgs>? OnRetrySuccess;
    public event EventHandler<RetryEventArgs>? OnRetryFailed;
    
    public RetryService(RetrySettings? settings = null)
    {
        _settings = settings ?? new RetrySettings();
    }
    
    public static RetryService CreateFromAppSettings(AppSettings appSettings)
    {
        var settings = new RetrySettings
        {
            MaxRetries = appSettings.Modem.RetryCount,
            InitialDelayMs = appSettings.Modem.RetryDelayMs,
            MaxDelayMs = appSettings.Modem.RetryMaxDelayMs,
            UseExponentialBackoff = appSettings.Modem.RetryUseExponentialBackoff,
            AddJitter = appSettings.Modem.RetryAddJitter
        };
        return new RetryService(settings);
    }
    
    public async Task<T> ExecuteWithRetryAsync<T>(
        Func<Task<T>> operation,
        Func<T, bool> isSuccess,
        string operationName = "العملية",
        CancellationToken cancellationToken = default)
    {
        Exception? lastException = null;
        T? lastResult = default;
        
        for (int attempt = 1; attempt <= _settings.MaxRetries + 1; attempt++)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                
                var result = await operation();
                
                if (isSuccess(result))
                {
                    if (attempt > 1)
                    {
                        OnRetrySuccess?.Invoke(this, new RetryEventArgs
                        {
                            OperationName = operationName,
                            AttemptNumber = attempt,
                            MaxAttempts = _settings.MaxRetries + 1,
                            Message = $"نجحت بعد {attempt} محاولات"
                        });
                    }
                    return result;
                }
                
                lastResult = result;
                
                if (attempt <= _settings.MaxRetries)
                {
                    var delay = CalculateDelay(attempt);
                    
                    OnRetryAttempt?.Invoke(this, new RetryEventArgs
                    {
                        OperationName = operationName,
                        AttemptNumber = attempt,
                        MaxAttempts = _settings.MaxRetries + 1,
                        Message = $"فشلت المحاولة {attempt}، إعادة المحاولة بعد {delay}ms...",
                        DelayMs = delay
                    });
                    
                    await Task.Delay(delay, cancellationToken);
                }
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception ex)
            {
                lastException = ex;
                
                if (attempt <= _settings.MaxRetries)
                {
                    var delay = CalculateDelay(attempt);
                    
                    OnRetryAttempt?.Invoke(this, new RetryEventArgs
                    {
                        OperationName = operationName,
                        AttemptNumber = attempt,
                        MaxAttempts = _settings.MaxRetries + 1,
                        Message = $"خطأ في المحاولة {attempt}: {ex.Message}، إعادة المحاولة...",
                        Exception = ex,
                        DelayMs = delay
                    });
                    
                    await Task.Delay(delay, cancellationToken);
                }
            }
        }
        
        OnRetryFailed?.Invoke(this, new RetryEventArgs
        {
            OperationName = operationName,
            AttemptNumber = _settings.MaxRetries + 1,
            MaxAttempts = _settings.MaxRetries + 1,
            Message = $"فشلت جميع المحاولات ({_settings.MaxRetries + 1})",
            Exception = lastException
        });
        
        if (lastException != null)
        {
            throw lastException;
        }
        
        if (lastResult != null)
        {
            return lastResult;
        }
        
        return default!;
    }
    
    public async Task<(bool Success, T? Result, string Message)> ExecuteWithRetryAndStatusAsync<T>(
        Func<Task<T>> operation,
        Func<T, bool> isSuccess,
        Func<T, string>? getErrorMessage = null,
        string operationName = "العملية",
        CancellationToken cancellationToken = default)
    {
        int totalAttempts = 0;
        Exception? lastException = null;
        T? lastResult = default;
        
        for (int attempt = 1; attempt <= _settings.MaxRetries + 1; attempt++)
        {
            totalAttempts = attempt;
            
            try
            {
                cancellationToken.ThrowIfCancellationRequested();
                
                var result = await operation();
                lastResult = result;
                
                if (isSuccess(result))
                {
                    var successMessage = attempt > 1 
                        ? $"نجح بعد {attempt} محاولات" 
                        : "نجح من المحاولة الأولى";
                    return (true, result, successMessage);
                }
                
                if (attempt <= _settings.MaxRetries)
                {
                    var delay = CalculateDelay(attempt);
                    
                    OnRetryAttempt?.Invoke(this, new RetryEventArgs
                    {
                        OperationName = operationName,
                        AttemptNumber = attempt,
                        MaxAttempts = _settings.MaxRetries + 1,
                        Message = $"فشلت المحاولة {attempt}، إعادة بعد {delay}ms",
                        DelayMs = delay
                    });
                    
                    await Task.Delay(delay, cancellationToken);
                }
            }
            catch (OperationCanceledException)
            {
                return (false, default, "تم إلغاء العملية");
            }
            catch (Exception ex)
            {
                lastException = ex;
                
                if (attempt <= _settings.MaxRetries)
                {
                    var delay = CalculateDelay(attempt);
                    
                    OnRetryAttempt?.Invoke(this, new RetryEventArgs
                    {
                        OperationName = operationName,
                        AttemptNumber = attempt,
                        MaxAttempts = _settings.MaxRetries + 1,
                        Message = $"خطأ: {ex.Message}، إعادة المحاولة...",
                        Exception = ex,
                        DelayMs = delay
                    });
                    
                    await Task.Delay(delay, cancellationToken);
                }
            }
        }
        
        var errorMessage = lastException?.Message ?? 
            (lastResult != null && getErrorMessage != null ? getErrorMessage(lastResult) : "فشلت جميع المحاولات");
        
        return (false, lastResult, $"فشل بعد {totalAttempts} محاولات: {errorMessage}");
    }
    
    public async Task<bool> ExecuteWithRetryAsync(
        Func<Task<bool>> operation,
        string operationName = "العملية",
        CancellationToken cancellationToken = default)
    {
        return await ExecuteWithRetryAsync(
            operation,
            result => result,
            operationName,
            cancellationToken);
    }
    
    public async Task<string> ExecuteUssdWithRetryAsync(
        Func<Task<string>> operation,
        Func<string, bool>? customSuccessCheck = null,
        string operationName = "USSD",
        CancellationToken cancellationToken = default)
    {
        Func<string, bool> isSuccess = customSuccessCheck ?? DefaultUssdSuccessCheck;
        
        return await ExecuteWithRetryAsync(
            operation,
            isSuccess,
            operationName,
            cancellationToken);
    }
    
    private bool DefaultUssdSuccessCheck(string response)
    {
        if (string.IsNullOrEmpty(response)) return false;
        if (response.Contains("ERROR")) return false;
        if (response.Contains("لم يتم استلام رد")) return false;
        if (response.Contains("No USSD response")) return false;
        if (response.Contains("تعذر")) return false;
        if (response.Contains("غير معروف") && !response.Contains("+CUSD:")) return false;
        
        return response.Contains("+CUSD:") || 
               response.Contains("OK") || 
               response.Length > 10;
    }
    
    private int CalculateDelay(int attempt)
    {
        if (!_settings.UseExponentialBackoff)
        {
            return _settings.InitialDelayMs;
        }
        
        var delay = _settings.InitialDelayMs * (int)Math.Pow(2, attempt - 1);
        
        if (_settings.AddJitter)
        {
            var jitter = new Random().Next(-_settings.JitterMs, _settings.JitterMs);
            delay += jitter;
        }
        
        return Math.Min(delay, _settings.MaxDelayMs);
    }
}

public class RetrySettings
{
    public int MaxRetries { get; set; } = 3;
    public int InitialDelayMs { get; set; } = 1000;
    public int MaxDelayMs { get; set; } = 10000;
    public bool UseExponentialBackoff { get; set; } = true;
    public bool AddJitter { get; set; } = true;
    public int JitterMs { get; set; } = 200;
}

public class RetryEventArgs : EventArgs
{
    public string OperationName { get; set; } = "";
    public int AttemptNumber { get; set; }
    public int MaxAttempts { get; set; }
    public string Message { get; set; } = "";
    public int DelayMs { get; set; }
    public Exception? Exception { get; set; }
}
