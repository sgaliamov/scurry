using System;
using Xunit;

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

        static int Foo(int a, int b, int c, int d, int e) => a + b * (c + d - e);

        // it's not possible to make F generic
        public static Func<int, int, int, int, int, int> F(Func<int, int, int, int, int, int> foo) => foo;
    }
}
