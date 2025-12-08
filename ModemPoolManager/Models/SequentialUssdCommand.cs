namespace ModemPoolManager.Models;

public class SequentialUssdCommand
{
    public int Order { get; set; }
    public string Command { get; set; } = "";
    public bool IsReply { get; set; }
    public string? Response { get; set; }
    public bool IsExecuted { get; set; }
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
}
