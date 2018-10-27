using System;
using Xunit;
using static SCurry.Spacer;
using static SCurry.Piper;
using static SCurry.Composer;

namespace SCurry.Tests
{
    [Trait("Category", "Curry")]
    public class PipeAndComposeTests
    {
        [Fact]
        public void Compose_Three_Functions()
        {
            var piped = Compose(
                CurryedAdd2WithGap,
                PartialMultiplyBy3,
                CurryedAdd3(3)(1)
            );

            var actual = piped(0);

            Assert.Equal(14, actual);
        }

        [Fact]
        public void Pipe_Three_Functions()
        {
            var piped = Pipe(
                CurryedAdd2WithGap,
                PartialMultiplyBy3,
                CurryedAdd3(3)(1)
            );

            var actual = piped(0);

            Assert.Equal(10, actual);
        }

        private static readonly Func<int, int, int> Multiply = (a, b) => a * b;
        private static readonly Func<int, int> CurryedAdd2WithGap = TestFunctions.Add2.Curry(_, 2);
        private static readonly Func<int, int> PartialMultiplyBy3 = Multiply.Partial(3);
        private static readonly Func<int, Func<int, Func<int, int>>> CurryedAdd3 = TestFunctions.Add3.Curry();
    }
}
