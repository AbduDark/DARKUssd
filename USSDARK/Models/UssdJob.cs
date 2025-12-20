namespace USSDARK.Models;

/// <summary>
/// Represents a single USSD execution job with cancellation support
/// </summary>
public record UssdJob(
    string UssdCode, 
    Guid JobId, 
    DateTime CreatedAt,
    CancellationToken CancellationToken = default
)
{
    public static UssdJob Create(string ussdCode) => new(
        ussdCode,
        Guid.NewGuid(),
        DateTime.Now,
        default
    );

    public static UssdJob CreateWithCancellation(string ussdCode, CancellationToken ct) => new(
        ussdCode,
        Guid.NewGuid(),
        DateTime.Now,
        ct
    );
}
