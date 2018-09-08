using System.Linq;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class PartialApplicationBuilderTests
    {
        [Fact]
        public void GenerateFuncExtentions_0_Test()
        {
            const string expected = "public static "
                                    + "Func<TResult> "
                                    + "Partial<TResult>(this Func<TResult> func) "
                                    + "=> func;";

            var actual = PartialApplicationBuilder.GenerateFuncExtentions(0).Single();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GenerateFuncExtentions_2_Test()
        {
            var expected = new[]
            {
                "public static "
                + "Func<T2, TResult> "
                + "Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, "
                + "T1 arg1) "
                + "=> (arg2) => func(arg1, arg2);",

                "public static "
                + "Func<T1, TResult> "
                + "Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, "
                + "_ gap1, T2 arg2) "
                + "=> (arg1) => func(arg1, arg2);",

                "public static "
                + "Func<TResult> "
                + "Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, "
                + "T1 arg1, T2 arg2) "
                + "=> () => func(arg1, arg2);"
            };

            // act
            var actual = PartialApplicationBuilder.GenerateFuncExtentions(2).ToArray();

            // asserts
            for (var i = 0; i < actual.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
