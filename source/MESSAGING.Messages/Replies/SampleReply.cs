using MESSAGING.Messages.Abstractions;

namespace MESSAGING.Messages.Replies;

public sealed record SampleReply : MessageBase
{
    public string ReplyData { get; init; } = string.Empty;
}
