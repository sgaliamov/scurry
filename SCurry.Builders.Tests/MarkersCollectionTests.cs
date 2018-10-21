using System.Linq;
using AutoFixture;
using FluentAssertions;
using SCurry.Builders.Models;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Helpers")]
    public class MarkersCollectionTests
    {
        private readonly Fixture _fixture = new Fixture();

        [Fact]
        public void Build_Actoin_2gaps_5agrs()
        {
            var type = _fixture.Create<MethodType>();

            var actual = MethodsCollection.Create(type, 2, 5);

            var methods = new[]
                {
                    new[] { true, false, false, false, false },
                    new[] { false, true, false, false, false },
                    new[] { true, true, false, false, false },
                    new[] { true, true, true },
                    new[] { true, true, true, true },
                    new[] { true, true, true, true, true }
                }
                .Select(markers =>
                {
                    var parameters = markers
                        .Select((hasArg, index) => new Parameter(hasArg, index + 1))
                        .ToArray();

                    return new MethodDefinition(type, parameters);
                })
                .ToArray();

            var expected = new MethodsCollection(methods);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
