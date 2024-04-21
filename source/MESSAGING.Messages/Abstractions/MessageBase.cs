namespace MESSAGING.Messages.Abstractions;

public abstract record MessageBase
{
    public Guid MessageId { get; init; } = Guid.NewGuid();
    public DateTime MessageCreatedDateUTC { get; init; } = DateTime.UtcNow;
    public Guid CorrelationId { get; init; } = Guid.NewGuid();
}
