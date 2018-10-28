using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using FluentAssertions;
using Moq;
using SCurry.Builders.Converters;
using SCurry.Builders.Models;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class DefaultBuilderTests
    {
        public DefaultBuilderTests() =>
            _target = new DefaultBuilder(_methodConverter.Object, _definitionsBuilder.Object);

        [Fact]
        public void Generate_3_Func_Extensions()
        {
            const int maxArgsCount = 3;
            var gapsCount = _fixture.Create<int>();
            var limitPartial = _fixture.Create<int>();

            var items = SetupDefinitionsBuilder(MethodType.Function, gapsCount, limitPartial, maxArgsCount);
            var extensions = SetupMethodConverter(items);

            var actual = _target.GenerateFuncExtensions(gapsCount, maxArgsCount, limitPartial).ToArray();

            actual.Should().BeEquivalentTo(extensions, options => options.WithStrictOrdering());
        }

        [Fact]
        public void Generate_3_Action_Extensions()
        {
            const int maxArgsCount = 3;
            var gapsCount = _fixture.Create<int>();
            var limitPartial = _fixture.Create<int>();

            var items = SetupDefinitionsBuilder(MethodType.Action, gapsCount, limitPartial, maxArgsCount);
            var extensions = SetupMethodConverter(items);

            var actual = _target.GenerateActionExtensions(gapsCount, maxArgsCount, limitPartial).ToArray();

            actual.Should().BeEquivalentTo(extensions, options => options.WithStrictOrdering());
        }

        private string[] SetupMethodConverter(IEnumerable<MethodDefinition> items)
        {
            var extensions = items.Select(definition => new
                                  {
                                      Defenition = definition,
                                      Extension = _fixture.Create<string>()
                                  })
                                  .ToArray();

            foreach (var extension in extensions)
            {
                _methodConverter.Setup(x => x.Convert(extension.Defenition)).Returns(extension.Extension);
            }

            return extensions.Select(x => x.Extension).ToArray();
        }

        private MethodDefinition[] SetupDefinitionsBuilder(MethodType methodType, int gapsCount, int limitPartial, int maxArgsCount)
        {
            var items = Enumerable.Range(0, maxArgsCount + 1)
                                  .Select(i => new
                                  {
                                      ArgsCount = i,
                                      Definitions = _fixture.CreateMany<MethodDefinition>(2).ToArray()
                                  })
                                  .ToArray();

            foreach (var item in items)
            {
                _definitionsBuilder.Setup(x => x.Build(
                                       methodType,
                                       gapsCount,
                                       item.ArgsCount,
                                       limitPartial))
                                   .Returns(item.Definitions);
            }

            return items.SelectMany(x => x.Definitions).ToArray();
        }

        private readonly Fixture _fixture = new Fixture();
        private readonly DefaultBuilder _target;
        private readonly Mock<IConverter> _methodConverter = new Mock<IConverter>(MockBehavior.Strict);
        private readonly Mock<IMethodDefinitionsBuilder> _definitionsBuilder = new Mock<IMethodDefinitionsBuilder>(MockBehavior.Strict);
    }
}
