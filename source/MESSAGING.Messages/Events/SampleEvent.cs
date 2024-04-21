using MESSAGING.Messages.Abstractions;

namespace MESSAGING.Messages.Events;

public sealed record SampleEvent : MessageBase
{
    public string EventData { get; init; } = string.Empty;
}
