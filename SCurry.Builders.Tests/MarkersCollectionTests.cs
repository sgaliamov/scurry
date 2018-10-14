using System.Linq;
using AutoFixture;
using FluentAssertions;
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
            var type = _fixture.Create<MarkersCollection.MarkersType>();

            var actual = new MarkersCollection(type, 2, 5);

            var flags = new[]
                {
                    new[] { true, false, false, false, false },
                    new[] { false, true, false, false, false },
                    new[] { true, true, false, false, false },
                    new[] { true, true, true },
                    new[] { true, true, true, true },
                    new[] { true, true, true, true, true }
                }
                .Select(x => new MarkersCollection.MarkerFlags(x))
                .ToArray();

            actual.Should().BeEquivalentTo(new MarkersCollection(type, flags));
        }
    }
}
