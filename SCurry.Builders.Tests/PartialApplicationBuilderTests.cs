using System.Linq;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class PartialApplicationBuilderTests
    {
        [Fact]
        public void GenerateFuncExtentions_2_Test()
        {
            var expected = new[]
            {
                "public static "
                + "Func<T1, T2, TResult> "
                + "Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, "
                + "_ gap1, _ gap2) "
                + "=> func;",

                "public static "
                + "Func<T2, TResult> "
                + "Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, "
                + "T1 arg1, _ gap2) "
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

            var actual = PartialApplicationBuilder.GenerateFuncExtentions(2).ToArray();

            for (var i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
