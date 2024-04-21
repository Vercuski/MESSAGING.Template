using MESSAGING.Messages.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESSAGING.Messages.Queries;

public sealed record SampleQuery : MessageBase
{
    public string QueryData { get; init; } = string.Empty;
}
