using MESSAGING.Messages.Abstractions;

namespace MESSAGING.Messages.Commands;

public sealed record SampleCommand : MessageBase
{
    public string CommandData { get; init; } = string.Empty;
}
