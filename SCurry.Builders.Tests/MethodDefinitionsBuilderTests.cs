using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using FluentAssertions;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Helpers")]
    public class MethodDefinitionsBuilderTests
    {
        [Fact]
        public void Build_With_0_Gaps_4_Args_4_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(
                new[]
                {
                    new[] { 0, 0, 0, 0 },
                    new[] { 1, 0, 0, 0 },
                    new[] { 1, 1, 0, 0 },
                    new[] { 1, 1, 1, 0 },
                    new[] { 1, 1, 1, 1 }
                },
                type);

            var actual = _target.Build(type, 0, 4, 4);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_0_Gaps_5_Args_0_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(new[] { new[] { 0, 0, 0, 0, 0 } }, type);

            var actual = _target.Build(type, 0, 5, 0);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_2_Gaps_0_Args_3_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(
                new[]
                {
                    new int[0]
                },
                type);

            var actual = _target.Build(type, 2, 0, 3);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_2_Gaps_1_Args_3_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(
                new[]
                {
                    new[] { 0 },
                    new[] { 1 }
                },
                type);

            var actual = _target.Build(type, 2, 1, 3);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_3_Gaps_3_Args_4_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(
                new[]
                {
                    new[] { 0, 0, 0 },
                    new[] { 1, 0, 0 },
                    new[] { 0, 1, 0 },
                    new[] { 1, 1, 0 },
                    new[] { 0, 0, 1 },
                    new[] { 1, 0, 1 },
                    new[] { 0, 1, 1 },
                    new[] { 1, 1, 1 }
                },
                type);

            var actual = _target.Build(type, 3, 3, 4);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_3_Gaps_4_Args_4_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(
                new[]
                {
                    new[] { 0, 0, 0, 0 },
                    new[] { 1, 0, 0, 0 },
                    new[] { 1, 1, 0, 0 },
                    new[] { 1, 1, 1, 0 },
                    new[] { 1, 1, 1, 1 }
                },
                type);

            var actual = _target.Build(type, 3, 4, 4);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_3_Gaps_5_Args_4_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(new[] { new[] { 0, 0, 0, 0, 0 } }, type);

            var actual = _target.Build(type, 3, 5, 4);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Build_With_4_Gaps_3_Args_3_PartialLimit()
        {
            var type = _fixture.Create<MethodType>();
            var expected = Convert(
                new[]
                {
                    new[] { 0, 0, 0 },
                    new[] { 1, 0, 0 },
                    new[] { 0, 1, 0 },
                    new[] { 1, 1, 0 },
                    new[] { 0, 0, 1 },
                    new[] { 1, 0, 1 },
                    new[] { 0, 1, 1 },
                    new[] { 1, 1, 1 }
                },
                type);

            var actual = _target.Build(type, 4, 3, 3);

            actual.Should().BeEquivalentTo(expected.AsEnumerable());
        }

        [Fact]
        public void Invalid_Args_Count()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                _target.Build(_fixture.Create<MethodType>(), 0, -1, 0));

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                _target.Build(_fixture.Create<MethodType>(), 0, Constants.MaxInputArgumentsCount + 1, 0));
        }

        [Fact]
        public void Invalid_Gaps_Count()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                _target.Build(_fixture.Create<MethodType>(), -1, Constants.MaxInputArgumentsCount, 0));
        }

        private readonly MethodDefinitionsBuilder _target = new MethodDefinitionsBuilder();
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
