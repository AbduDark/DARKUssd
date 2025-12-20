using System.Collections.Concurrent;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

/// <summary>
/// Orchestrates multiple ModemWorker instances
/// - Manages up to 20 modems
/// - Broadcasts commands to all workers in parallel
/// - Handles worker lifecycle
/// - Cancels previous commands when new ones arrive
/// </summary>
public class ModemManager : IDisposable
{
    private readonly ConcurrentDictionary<string, ModemWorker> _workers = new();
    private CancellationTokenSource? _globalCts;
    private bool _isDisposed;

    public event EventHandler<string>? WorkerAdded;
    public event EventHandler<string>? WorkerRemoved;
    public event EventHandler<string>? LogMessage;

    public ModemManager()
    {
        _globalCts = new CancellationTokenSource();
    }

    /// <summary>
    /// Add a modem to the manager
    /// </summary>
    public async Task AddModemAsync(string portName)
    {
        if (_workers.ContainsKey(portName))
            return;

        try
        {
            var worker = new ModemWorker(portName);
            worker.LogMessage += (s, msg) => LogMessage?.Invoke(this, msg);
            
            await worker.StartAsync(_globalCts?.Token ?? CancellationToken.None);
            
            if (_workers.TryAdd(portName, worker))
            {
                WorkerAdded?.Invoke(this, portName);
                LogMessage?.Invoke(this, $"[Manager] Modem added: {portName}");
            }
        }
        catch (Exception ex)
        {
            LogMessage?.Invoke(this, $"[Manager] Failed to add modem {portName}: {ex.Message}");
        }
    }

    /// <summary>
    /// Remove a modem from the manager
    /// </summary>
    public async Task RemoveModemAsync(string portName)
    {
        if (_workers.TryRemove(portName, out var worker))
        {
            await worker.StopAsync();
            worker.Dispose();
            WorkerRemoved?.Invoke(this, portName);
            LogMessage?.Invoke(this, $"[Manager] Modem removed: {portName}");
        }
    }

    /// <summary>
    /// Execute USSD on a single modem
    /// </summary>
    public async Task<bool> ExecuteOnModemAsync(string portName, string ussdCode, CancellationToken cancellationToken = default)
    {
        if (!_workers.TryGetValue(portName, out var worker))
        {
            LogMessage?.Invoke(this, $"[Manager] Modem not found: {portName}");
            return false;
        }

        return await worker.QueueUssdAsync(ussdCode, cancellationToken);
    }

    /// <summary>
    /// Execute USSD on ALL modems in parallel
    /// Previous commands are cancelled automatically (bounded queue drops old jobs)
    /// </summary>
    public async Task ExecuteOnAllAsync(string ussdCode)
    {
        if (_workers.IsEmpty)
        {
            LogMessage?.Invoke(this, "[Manager] No modems available");
            return;
        }

        LogMessage?.Invoke(this, $"[Manager] Broadcasting USSD to {_workers.Count} modems");

        var tasks = _workers.Values
            .Select(worker => worker.QueueUssdAsync(ussdCode, CancellationToken.None))
            .ToList();

        await Task.WhenAll(tasks);
    }

    /// <summary>
    /// Get all active workers
    /// </summary>
    public IReadOnlyDictionary<string, ModemWorker> GetWorkers() => _workers;

    /// <summary>
    /// Get worker for a specific port
    /// </summary>
    public ModemWorker? GetWorker(string portName) => 
        _workers.TryGetValue(portName, out var worker) ? worker : null;

    /// <summary>
    /// Get count of active workers
    /// </summary>
    public int WorkerCount => _workers.Count;

    /// <summary>
    /// Shutdown all workers
    /// </summary>
    public async Task ShutdownAsync()
    {
        var tasks = _workers.Values
            .Select(w => w.StopAsync())
            .ToList();

        await Task.WhenAll(tasks);
        _workers.Clear();
    }

    public void Dispose()
    {
        if (_isDisposed)
            return;

        try
        {
            ShutdownAsync().Wait(TimeSpan.FromSeconds(5));
        }
        catch { }

        foreach (var worker in _workers.Values)
        {
            try { worker.Dispose(); } catch { }
        }

        _globalCts?.Cancel();
        _globalCts?.Dispose();
        _isDisposed = true;
    }
}
