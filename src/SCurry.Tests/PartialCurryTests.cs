using System;
using Xunit;
using static SCurry.Tests.TestFunctions;

namespace SCurry.Tests
{
    using static Spacer;

    [Trait("Category", "Curry")]
    public class PartialCurryTests
    {
        [Fact]
        public void Partial_WithGaps_Then_Curry()
        {
            var partial = F(Foo).Partial(_, _, 2).Partial(_, 3);
            var curried = partial.Curry();

            Assert.Equal(
                partial(1, 6, 7),
                curried(1)(6)(7));
        }

        [Fact]
        public void Combine_Partial_on_long_funtion()
        {
            var partial = Add16.Partial(1, 2, 3, 4, 5, 6, 7, 8).Partial(_, 8, 7, 6, 5, 4, 3, 2);

            Assert.Equal(72, partial(1));
        }

        static int Foo(int a, int b, int c, int d, int e) => a + b * (c + d - e);

        // it's not possible to make F generic
        public static Func<int, int, int, int, int, int> F(Func<int, int, int, int, int, int> foo) => foo;
    }
}
