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
            var partial = Foo.Partial(_, _, 2, _, 3);
            var curried = partial.Curry();

            Assert.Equal(
                partial(1, 6, 7),
                curried(1)(6)(7));
        }

        private static readonly Func<int, int, int, int, int, int> Foo = (a, b, c, d, e) =>
            a + b * (c + d - e);
    }
}
