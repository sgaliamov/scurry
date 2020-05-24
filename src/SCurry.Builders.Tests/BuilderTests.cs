using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using Moq;
using SCurry.Builders.Converters;
using SCurry.Builders.Models;

namespace SCurry.Builders.Tests
{
    public abstract class BuilderTests
    {
        protected readonly Mock<IMethodDefinitionsBuilder> DefinitionsBuilder = new Mock<IMethodDefinitionsBuilder>(MockBehavior.Strict);
        protected readonly Fixture Fixture = new Fixture();
        protected readonly Mock<IConverter> MethodConverter = new Mock<IConverter>(MockBehavior.Strict);

        protected string[] SetupMethodConverter(IEnumerable<MethodDefinition> items)
        {
            var extensions = items.Select(definition => new {
                Defenition = definition,
                Extension = Fixture.Create<string>()
            })
                                  .ToArray();

            foreach (var extension in extensions) {
                MethodConverter.Setup(x => x.Convert(extension.Defenition)).Returns(extension.Extension);
            }

            return extensions.Select(x => x.Extension).ToArray();
        }

        protected MethodDefinition[] SetupDefinitionsBuilder(
            MethodType methodType,
            int gapsCount,
            int limitPartial,
            int maxArgsCount,
            int definitionsCount)
        {
            var items = Enumerable.Range(0, maxArgsCount + 1)
                                  .Select(i => new {
                                      ArgsCount = i,
                                      Definitions = Fixture.CreateMany<MethodDefinition>(definitionsCount).ToArray()
                                  })
                                  .ToArray();

            foreach (var item in items) {
                DefinitionsBuilder.Setup(x => x.Build(
                                      methodType,
                                      gapsCount,
                                      item.ArgsCount,
                                      limitPartial))
                                  .Returns(item.Definitions);
            }

            return items.SelectMany(x => x.Definitions).ToArray();
        }
    }
}
