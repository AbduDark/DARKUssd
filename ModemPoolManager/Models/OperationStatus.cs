namespace ModemPoolManager.Models;

public class OperationStatus
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string OperationType { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string TargetPhone { get; set; } = string.Empty;
    public DateTime StartTime { get; set; } = DateTime.Now;
    public bool IsRunning { get; set; } = true;

    public string DisplayText => string.IsNullOrEmpty(TargetPhone) 
        ? Description 
        : $"{Description} {TargetPhone}";
}
