namespace MESSAGING.Events.Update;

public sealed record SampleUpdateMessage
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public DateTime LastUpdated { get; set; } = DateTime.Now;
}
