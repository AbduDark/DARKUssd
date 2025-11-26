namespace ModemPoolManager.Models;

public class Modem
{
    public int Index { get; set; }
    public string PortName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Status { get; set; } = "غير متصل";
    public string LastResponse { get; set; } = string.Empty;
    public bool IsConnected { get; set; }
    public bool IsSelected { get; set; } = true;
    public string SignalStrength { get; set; } = "N/A";
    public string Operator { get; set; } = "N/A";
}
