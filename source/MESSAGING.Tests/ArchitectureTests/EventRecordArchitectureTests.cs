using FluentAssertions;
using MESSAGING.Tests.ArchitectureTests.CustomRules;
using NetArchTest.Rules;
using static MESSAGING.Tests.ArchitectureTests.AssemblyReferences;

namespace MESSAGING.Tests.ArchitectureTests;

[TestFixture]
public class EventRecordArchitectureTests
{
    [Test]
    public void EventRecords_Should_ContainNoMethods()
    {
        var methodCountCustomRule = new MethodCount();
        var result = Types
            .InAssembly(EventsAssembly)
            .That()
            .AreClasses()
            .Should()
            .BeSealed().Or().BeAbstract()
            .And()
            .MeetCustomRule(methodCountCustomRule)
            .GetResult();

        if (result.FailingTypeNames != null && result.FailingTypeNames.Any())
        {
            Console.WriteLine("Failing Method != 0 Types:");
            foreach (var failingType in result.FailingTypeNames)
            {
                Console.WriteLine($"    {failingType}");
            }
        }

        result.IsSuccessful.Should().BeTrue();
    }
}
