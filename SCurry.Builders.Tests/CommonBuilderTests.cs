using Xunit;

namespace SCurry.Builders.Tests
{
    using static CommonBuilder;

    [Trait("Category", "Builder")]
    public class CommonBuilderTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void TypeParameters_AppendResult_Test(ushort count)
        {
            var expected = count == 0
                ? "TResult"
                : count == 1
                    ? "T1, TResult"
                    : "T1, T2, T3, TResult";

            var actual = TypeParameters(count, true);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void TypeParameters_NoResult_Test(ushort count)
        {
            var expected = count == 0
                ? string.Empty
                : count == 1
                    ? "T1"
                    : "T1, T2, T3";

            var actual = TypeParameters(count, false);

            Assert.Equal(expected, actual);
        }
    }
}
