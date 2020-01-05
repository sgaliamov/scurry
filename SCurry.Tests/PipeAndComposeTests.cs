using System;
using Xunit;
using static SCurry.Spacer;
using static SCurry.Piper;
using static SCurry.Composer;
using static SCurry.Helpers;

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
                CurryedPartialMultiplyBy3(1),
                CurryedAdd3(3)(1)
            );

            var actual = piped(0);

            Assert.Equal(14, actual);
        }

        [Fact]
        public void Func_Tests()
        {
            var f1 = Func((int a, int b) => a + b).Curry();

            var f2 = Func<int, int, int>(Test).Partial(_, 1);
        }

        [Fact]
        public void Pipe_Three_Functions()
        {
            var piped = Pipe(
                CurryedAdd2WithGap,
                CurryedPartialMultiplyBy3(1),
                CurryedAdd3(3)(1)
            );

            var actual = piped(0);

            Assert.Equal(10, actual);
        }

        public static int Test(int i, int y) => i + y;

        private static readonly Func<int, int, int, int> Multiply = (a, b, c) => a * b * c;
        private static readonly Func<int, int> CurryedAdd2WithGap = TestFunctions.Add2.Partial(_, 2).Curry();
        private static readonly Func<int, Func<int, int>> CurryedPartialMultiplyBy3 = Multiply.Partial(_, _, 3).Curry();
        private static readonly Func<int, Func<int, Func<int, int>>> CurryedAdd3 = TestFunctions.Add3.Curry();
    }
}
