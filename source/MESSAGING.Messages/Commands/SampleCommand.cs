using MESSAGING.Messages.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESSAGING.Messages.Commands;

public sealed record SampleDocument : MessageBase
{
    public string CommandData { get; init; } = string.Empty;
}
