using System.Linq;
using AutoFixture;
using FluentAssertions;
using SCurry.Builders.Models;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class DefaultBuilderTests : BuilderTests
    {
        public DefaultBuilderTests() =>
            _target = new DefaultBuilder(MethodConverter.Object, DefinitionsBuilder.Object);

        [Fact]
        public void Generate_3_Action_Extensions()
        {
            const int maxArgsCount = 3;
            var gapsCount = Fixture.Create<int>();
            var limitPartial = Fixture.Create<int>();

            var items = SetupDefinitionsBuilder(MethodType.Action, gapsCount, limitPartial, maxArgsCount, 2);
            var extensions = SetupMethodConverter(items);

            var actual = _target.GenerateActionExtensions(maxArgsCount, gapsCount, limitPartial).ToArray();

            actual.Should().BeEquivalentTo(extensions, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Generate_3_Func_Extensions()
        {
            const int maxArgsCount = 3;
            var gapsCount = Fixture.Create<int>();
            var limitPartial = Fixture.Create<int>();

            var items = SetupDefinitionsBuilder(MethodType.Function, gapsCount, limitPartial, maxArgsCount, 3);
            var extensions = SetupMethodConverter(items);

            var actual = _target.GenerateFuncExtensions(maxArgsCount, gapsCount, limitPartial).ToArray();

            actual.Should().BeEquivalentTo(extensions, options => options.WithStrictOrdering());
        }

        private readonly DefaultBuilder _target;
    }
}
