using System.Linq;
using AutoFixture;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class PartialApplicationBuilderTests
    {
        private readonly Fixture _fixture = new Fixture();

        [Theory]
        [InlineData(3)]
        public void FuncReturnType_Test(ushort count)
        {
            var expected = new[]
            {
                "public static "
                + "Func<T1, T2, T3, TResult> "
                + "Partial<T1, T2, T3, TResult> this Func<T1, T2, T3, TResult> func, "
                + "_ s1, _ s2, _ s3) => "
                + "func;",

                "public static "
                + "Func<T2, T3, TResult> "
                + "Partial<T1, T2, T3, TResult> this Func<T1, T2, T3, TResult> func, "
                + "T1 arg1, _ s2, _ s3) => "
                + "(T2 arg2, T3 arg3) => func(arg1, arg2, arg3);",

                "public static "
                + "Func<T1, T3, TResult> "
                + "Partial<T1, T2, T3, TResult> this Func<T1, T2, T3, TResult> func, "
                + "_ s1, T2 arg2, _ s3) => "
                + "(T1 arg1, T3 arg3) => func(arg1, arg2, arg3);",

                "public static "
                + "Func<T1, T2, T3, TResult> "
                + "Partial<T1, T2, T3, TResult> this Func<T1, T2, T3, TResult> func, "
                + "T1 arg1, T2 arg2, T3 arg3) => "
                + "func(arg1, arg2, arg3);"
            };

            var actual = PartialApplicationBuilder.GenerateFuncExtentions(count).ToArray();

            Assert.Equal(expected, actual);
        }
    }
}
