using MESSAGING.Events.Create;
using System.Reflection;

namespace MESSAGING.Tests.ArchitectureTests;

internal static class AssemblyReferences
{
    internal static readonly Assembly EventsAssembly = typeof(SampleCreateMessage).Assembly;
}
