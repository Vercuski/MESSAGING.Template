using MESSAGING.Messages.Abstractions;

namespace MESSAGING.Messages.Documents;

public sealed record SampleDocument : MessageBase
{
    public string DocumentData { get; init; } = string.Empty;
}
