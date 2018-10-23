using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using FluentAssertions;
using SCurry.Builders.Models;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Helpers")]
    public class MethodDefinitionsBuilderTests
    {
        [Fact]
        public void Build_With_0_Gaps_4_Agrs()
        {
            var type = _fixture.Create<MethodType>();

            var markers = new[]
            {
                new[] { 0, 0, 0, 0 },
                new[] { 1, 0, 0, 0 },
                new[] { 1, 1, 0, 0 },
                new[] { 1, 1, 1, 0 },
                new[] { 1, 1, 1, 1 }
            };
            var expected = Convert(markers, type);

            var actual = MethodDefinitionsBuilder.Build(type, 0, 4);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_3_Gaps_3_Agrs()
        {
            var type = _fixture.Create<MethodType>();

            var markers = new[]
            {
                new[] { 0, 0, 0 },
                new[] { 1, 0, 0 },
                new[] { 0, 1, 0 },
                new[] { 1, 1, 0 },
                new[] { 0, 0, 1 },
                new[] { 1, 0, 1 },
                new[] { 0, 1, 1 },
                new[] { 1, 1, 1 }
            };
            var expected = Convert(markers, type);

            var actual = MethodDefinitionsBuilder.Build(type, 3, 3);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_3_Gaps_4_Agrs()
        {
            var type = _fixture.Create<MethodType>();

            var markers = new[]
            {
                new[] { 0, 0, 0, 0 },
                new[] { 1, 0, 0, 0 },
                new[] { 0, 1, 0, 0 },
                new[] { 1, 1, 0, 0 },
                new[] { 0, 0, 1, 0 },
                new[] { 1, 0, 1, 0 },
                new[] { 0, 1, 1, 0 },
                new[] { 1, 1, 1, 0 },
                new[] { 1, 1, 1, 1 }
            };
            var expected = Convert(markers, type);

            var actual = MethodDefinitionsBuilder.Build(type, 3, 4);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_3_Gaps_5_Agrs()
        {
            var type = _fixture.Create<MethodType>();

            var markers = new[]
            {
                new[] { 0, 0, 0, 0, 0 },
                new[] { 1, 0, 0, 0, 0 },
                new[] { 0, 1, 0, 0, 0 },
                new[] { 1, 1, 0, 0, 0 },
                new[] { 0, 0, 1, 0, 0 },
                new[] { 1, 0, 1, 0, 0 },
                new[] { 0, 1, 1, 0, 0 },
                new[] { 1, 1, 1, 0, 0 },
                new[] { 1, 1, 1, 1, 0 },
                new[] { 1, 1, 1, 1, 1 }
            };
            var expected = Convert(markers, type);

            var actual = MethodDefinitionsBuilder.Build(type, 3, 5);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_4_Gaps_3_Agrs()
        {
            var type = _fixture.Create<MethodType>();

            var markers = new[]
            {
                new[] { 0, 0, 0 },
                new[] { 1, 0, 0 },
                new[] { 0, 1, 0 },
                new[] { 1, 1, 0 },
                new[] { 0, 0, 1 },
                new[] { 1, 0, 1 },
                new[] { 0, 1, 1 },
                new[] { 1, 1, 1 }
            };
            var expected = Convert(markers, type);

            var actual = MethodDefinitionsBuilder.Build(type, 4, 3);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        private readonly Fixture _fixture = new Fixture();

        private static MethodDefinition[] Convert(IEnumerable<int[]> markers, MethodType type)
        {
            return markers
                .Select(m =>
                {
                    var parameters = m
                        .Select((isArg, index) => new Parameter(isArg == 1, index + 1))
                        .ToArray();

                    return new MethodDefinition(type, parameters);
                })
                .ToArray();
        }
    }
}
