using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MESSAGING.Messages.Events;

public sealed record SampleEvent
{
    public string EventData { get; init; } = string.Empty;
}
