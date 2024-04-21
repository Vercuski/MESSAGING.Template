using MESSAGING.Messages.Abstractions;

namespace MESSAGING.Messages.Queries;

public sealed record SampleQuery : MessageBase
{
    public string QueryData { get; init; } = string.Empty;
}
