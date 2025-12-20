namespace USSDARK.Models;

public class UssdResult
{
    public int ModemIndex { get; set; }
    public string PortName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string UssdCode { get; set; } = string.Empty;
    public string Response { get; set; } = string.Empty;
    public bool IsSuccess { get; set; }
    public DateTime Timestamp { get; set; } = DateTime.Now;
    public string ErrorMessage { get; set; } = string.Empty;
}
