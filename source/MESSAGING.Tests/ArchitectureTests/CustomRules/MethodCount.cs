using FluentAssertions;
using Mono.Cecil;
using Mono.Cecil.Rocks;
using NetArchTest.Rules;
using System.Reflection;

namespace MESSAGING.Tests.ArchitectureTests.CustomRules
{
    internal class MethodCount : ICustomRule
    {
        public bool MeetsRule(TypeDefinition type)
        {
            var sometype = AssemblyReferences.EventsAssembly.GetType(type.FullName);
            var methods = sometype!.GetMethods(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.DeclaredOnly);
            var userMethods = methods.Where(x => !x.IsSpecialName && !x.IsVirtual && !x.CustomAttributes.Any()).ToList();
            return userMethods.Count == 0;
        }
    }
}
