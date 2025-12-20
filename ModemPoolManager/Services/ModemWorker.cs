using System.IO.Ports;
using System.Text;
using System.Text.RegularExpressions;
using ModemPoolManager.Models;

namespace ModemPoolManager.Services;

/// <summary>
/// Manages a single modem with isolated worker thread
/// - One SerialPort instance per worker
/// - Sequential command execution per modem
/// - Bounded queue for command scheduling
/// - Automatic recovery on disconnect
/// </summary>
public class ModemWorker : IDisposable
{
    private readonly string _portName;
    private readonly int _baudRate = 115200;
    private SerialPort? _port;
    private Channel<UssdJob>? _commandQueue;
    private CancellationTokenSource? _workerCts;
    private Task? _workerTask;
    private bool _isDisposed;
    private readonly object _portLock = new();
    
    public event EventHandler<(bool Success, string Message)>? StateChanged;
    public event EventHandler<string>? LogMessage;
    
    public string PortName => _portName;
    public bool IsRunning { get; private set; }
    public bool IsConnected { get; private set; }
    public DateTime LastActivity { get; private set; }
    public int QueuedJobsCount => _commandQueue?.Reader.Count ?? 0;

    public ModemWorker(string portName)
    {
        _portName = portName;
        LastActivity = DateTime.Now;
    }

    /// <summary>
    /// Start the worker and begin listening for commands
    /// </summary>
    public async Task StartAsync(CancellationToken cancellationToken = default)
    {
        if (IsRunning)
            return;

        try
        {
            _workerCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            _commandQueue = Channel.CreateBounded<UssdJob>(
                new BoundedChannelOptions(1) 
                { 
                    FullMode = BoundedChannelFullMode.DropOldest 
                }
            );

            if (!await OpenPortAsync())
            {
                throw new Exception($"Failed to open port {_portName}");
            }

            IsRunning = true;
            IsConnected = true;
            StateChanged?.Invoke(this, (true, "Worker started"));
            
            _workerTask = Task.Run(() => WorkerLoopAsync(_workerCts.Token), _workerCts.Token);
        }
        catch (Exception ex)
        {
            LogMessage?.Invoke(this, $"[{_portName}] Start error: {ex.Message}");
            IsRunning = false;
            throw;
        }
    }

    /// <summary>
    /// Stop the worker and cleanup resources
    /// </summary>
    public async Task StopAsync()
    {
        IsRunning = false;
        _commandQueue?.Writer.TryComplete();
        _workerCts?.Cancel();
        
        if (_workerTask != null)
        {
            try
            {
                await _workerTask.ConfigureAwait(false);
            }
            catch (OperationCanceledException) { }
        }
        
        ClosePort();
        StateChanged?.Invoke(this, (false, "Worker stopped"));
    }

    /// <summary>
    /// Queue a USSD command for execution
    /// If queue is full (another job pending), the old job is dropped
    /// </summary>
    public async Task<bool> QueueUssdAsync(string ussdCode, CancellationToken cancellationToken = default)
    {
        if (!IsRunning || _commandQueue == null)
        {
            LogMessage?.Invoke(this, $"[{_portName}] Worker not running");
            return false;
        }

        var job = UssdJob.CreateWithCancellation(ussdCode, cancellationToken);
        return await _commandQueue.Writer.TryWriteAsync(job);
    }

    /// <summary>
    /// Main worker loop - processes commands sequentially
    /// </summary>
    private async Task WorkerLoopAsync(CancellationToken cancellationToken)
    {
        try
        {
            if (_commandQueue == null)
                return;

            await foreach (var job in _commandQueue.Reader.ReadAllAsync(cancellationToken))
            {
                try
                {
                    await ExecuteUssdJobAsync(job);
                    LastActivity = DateTime.Now;
                }
                catch (OperationCanceledException)
                {
                    LogMessage?.Invoke(this, $"[{_portName}] Job cancelled");
                }
                catch (Exception ex)
                {
                    LogMessage?.Invoke(this, $"[{_portName}] Job error: {ex.Message}");
                    await HandleErrorAsync();
                }
            }
        }
        catch (OperationCanceledException)
        {
            LogMessage?.Invoke(this, $"[{_portName}] Worker cancelled");
        }
        catch (Exception ex)
        {
            LogMessage?.Invoke(this, $"[{_portName}] Worker error: {ex.Message}");
        }
        finally
        {
            IsRunning = false;
        }
    }

    /// <summary>
    /// Execute a USSD job
    /// </summary>
    private async Task ExecuteUssdJobAsync(UssdJob job)
    {
        lock (_portLock)
        {
            if (_port == null || !_port.IsOpen)
                throw new Exception("Port is not open");

            try
            {
                _port.DiscardInBuffer();
                _port.DiscardOutBuffer();
            }
            catch { }
        }

        // Cancel previous USSD session
        await SendATCommandAsync("AT+CUSD=2", 300);
        await Task.Delay(300);

        // Send new USSD command
        var encodedUssd = EncodeUssd(job.UssdCode);
        var command = $"AT+CUSD=1,\"{encodedUssd}\",15";
        
        LogMessage?.Invoke(this, $"[{_portName}] Executing USSD: {job.UssdCode}");
        await SendUssdCommandAsync(command, job.CancellationToken);
    }

    /// <summary>
    /// Send AT command and wait for response
    /// </summary>
    private async Task<string> SendATCommandAsync(string command, int timeoutMs = 3000)
    {
        lock (_portLock)
        {
            if (_port == null || !_port.IsOpen)
                throw new Exception("Port is not open");

            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();
            
            try
            {
                _port.Write(command + "\r");
            }
            catch
            {
                throw;
            }
        }

        var response = new StringBuilder();
        var startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalMilliseconds < timeoutMs)
        {
            await Task.Delay(50);

            lock (_portLock)
            {
                if (_port == null || !_port.IsOpen)
                    throw new Exception("Port disconnected");

                if (_port.BytesToRead > 0)
                {
                    var data = _port.ReadExisting();
                    response.Append(data);

                    if (response.ToString().Contains("OK") || response.ToString().Contains("ERROR"))
                        break;
                }
            }
        }

        return response.ToString();
    }

    /// <summary>
    /// Send USSD command and listen for response
    /// </summary>
    private async Task SendUssdCommandAsync(string command, CancellationToken cancellationToken = default)
    {
        const int ussdTimeout = 10000;
        var startTime = DateTime.Now;

        lock (_portLock)
        {
            if (_port == null || !_port.IsOpen)
                throw new Exception("Port is not open");

            _port.DiscardInBuffer();
            _port.DiscardOutBuffer();
            
            try
            {
                _port.Write(command + "\r");
            }
            catch
            {
                throw;
            }
        }

        LogMessage?.Invoke(this, $"[{_portName}] Listening for USSD response (10s timeout)...");

        while ((DateTime.Now - startTime).TotalMilliseconds < ussdTimeout)
        {
            cancellationToken.ThrowIfCancellationRequested();
            await Task.Delay(100);

            lock (_portLock)
            {
                if (_port == null || !_port.IsOpen)
                    throw new Exception("Port disconnected");

                if (_port.BytesToRead > 0)
                {
                    var data = _port.ReadExisting();
                    LogMessage?.Invoke(this, $"[{_portName}] Response: {data}");

                    if (data.Contains("+CUSD:") || data.Contains("ERROR"))
                        return;
                }
            }
        }

        LogMessage?.Invoke(this, $"[{_portName}] USSD timeout");
    }

    /// <summary>
    /// Open the serial port
    /// </summary>
    private async Task<bool> OpenPortAsync()
    {
        try
        {
            lock (_portLock)
            {
                _port = new SerialPort(_portName, _baudRate, Parity.None, 8, StopBits.One)
                {
                    ReadTimeout = 30000,
                    WriteTimeout = 3000,
                    Encoding = Encoding.ASCII
                };
                
                _port.Open();
                await Task.Delay(100);
            }
            
            LogMessage?.Invoke(this, $"[{_portName}] Port opened successfully");
            return true;
        }
        catch (Exception ex)
        {
            LogMessage?.Invoke(this, $"[{_portName}] Open error: {ex.Message}");
            IsConnected = false;
            return false;
        }
    }

    /// <summary>
    /// Close the serial port
    /// </summary>
    private void ClosePort()
    {
        lock (_portLock)
        {
            if (_port != null)
            {
                try
                {
                    if (_port.IsOpen)
                        _port.Close();
                    _port.Dispose();
                }
                catch { }
                
                _port = null;
            }
        }

        IsConnected = false;
    }

    /// <summary>
    /// Handle modem errors by attempting recovery
    /// </summary>
    private async Task HandleErrorAsync()
    {
        IsConnected = false;
        ClosePort();
        
        LogMessage?.Invoke(this, $"[{_portName}] Attempting recovery...");
        await Task.Delay(500);
        
        if (await OpenPortAsync())
        {
            IsConnected = true;
            LogMessage?.Invoke(this, $"[{_portName}] Recovery successful");
        }
    }

    private string EncodeUssd(string ussdCode)
    {
        if (ussdCode.All(c => char.IsDigit(c) || c == '*' || c == '#' || c == '+'))
            return ussdCode;

        var bytes = Encoding.BigEndianUnicode.GetBytes(ussdCode);
        return BitConverter.ToString(bytes).Replace("-", "");
    }

    public void Dispose()
    {
        if (_isDisposed)
            return;

        try
        {
            _workerCts?.Cancel();
            _workerTask?.Wait(TimeSpan.FromSeconds(2));
        }
        catch { }

        ClosePort();
        _commandQueue?.Dispose();
        _workerCts?.Dispose();
        _isDisposed = true;
    }
}
