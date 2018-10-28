using System.Linq;
using FluentAssertions;
using SCurry.Builders.Models;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class UncurryBuilderTests : BuilderTests
    {
        public UncurryBuilderTests() =>
            _target = new UncurryBuilder(MethodConverter.Object, DefinitionsBuilder.Object);

        [Fact]
        public void Generate_3_Action_Extensions()
        {
            const int maxArgsCount = 3;

            var items = SetupDefinitionsBuilder(MethodType.Action, 0, 0, maxArgsCount, 1);
            var extensions = SetupMethodConverter(items);

            var actual = _target.GenerateActionExtensions(maxArgsCount).ToArray();

            actual.Should().BeEquivalentTo(extensions, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Generate_3_Func_Extensions()
        {
            const int maxArgsCount = 3;

            var items = SetupDefinitionsBuilder(MethodType.Function, 0, 0, maxArgsCount, 1);
            var extensions = SetupMethodConverter(items);

            var actual = _target.GenerateFuncExtensions(maxArgsCount).ToArray();

            actual.Should().BeEquivalentTo(extensions, options => options.WithStrictOrdering());
        }

        private readonly UncurryBuilder _target;
    }
}
