using SCurry.Builders;
using Xunit;

namespace SCurry.Tests
{
    public class CurryBuilderTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void TypeParameters_Test(ushort count)
        {
            var expected = count == 0
                ? new[] {"TResult"}
                : count == 1
                    ? new[] {"T1", "TResult"}
                    : new[] {"T1", "T2", "T3", "TResult"};

            var actual = CurryBuilder.TypeParameters(count);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void ReturnType_Test(ushort count)
        {
            var expected = count == 0
                ? "Func<TResult>"
                : count == 1
                    ? "Func<T1, TResult>"
                    : "Func<T1, Func<T2, Func<T3, TResult>>>";

            var actual = CurryBuilder.ReturnType(count);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void Body_Test(ushort count)
        {
            var expected = count == 0 || count == 1
                ? "func"
                : "arg1 => arg2 => arg3 => func(arg1, arg2, arg3)";

            var actual = CurryBuilder.Body(count);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GenerateAllFuncExtentions_0_Test()
        {
            var actual = CurryBuilder.GenerateAllFuncExtentions(0);

            Assert.Equal("", actual);
        }

        [Fact]
        public void GenerateAllFuncExtentions_3_Test()
        {
            var actual = CurryBuilder.GenerateAllFuncExtentions(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void GenerateFuncExtention_0_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(0);

            const string result = "public static Func<TResult> "
                                  + "Curry<TResult>(this Func<TResult> func) "
                                  + "=> func;";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void GenerateFuncExtention_3_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }
    }
}