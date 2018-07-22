using System;
using Xunit;

namespace SCurry.Builders.Tests
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
                ? "TResult"
                : count == 1
                    ? "T1, TResult"
                    : "T1, T2, T3, TResult";

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

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void GenerateFuncExtention_Test(ushort count)
        {
            var expected = count == 0
                ? "public static Func<TResult> Curry<TResult>(this Func<TResult> func) => func;"
                : count == 1
                    ? "public static Func<T1, TResult> Curry<T1, TResult>(this Func<T1, TResult> func) => func;"
                    : "public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>"
                      + "(this Func<T1, T2, T3, TResult> func) => "
                      + "arg1 => arg2 => arg3 => func(arg1, arg2, arg3);";

            var actual = CurryBuilder.GenerateFuncExtention(count);

            Assert.Equal(expected, actual);
        }
    }
}