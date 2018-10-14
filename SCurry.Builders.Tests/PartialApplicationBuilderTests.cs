using System.Linq;
using SCurry.Builders.Old;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class PartialApplicationBuilderTests
    {
        private readonly PartialApplicationBuilder _target = new PartialApplicationBuilder();

        [Fact]
        public void GenerateActionExtentions_0_Test()
        {
            const string expected = "public static Action Partial(this Action action) => action;";

            var actual = _target.GenerateActionExtentions(0).Single();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GenerateActionExtentions_2_Test()
        {
            var expected = new[]
            {
                "public static "
                + "Action<T2> "
                + "Partial<T1, T2>(this Action<T1, T2> action, "
                + "T1 arg1) "
                + "=> (arg2) => action(arg1, arg2);",

                "public static "
                + "Action<T1> "
                + "Partial<T1, T2>(this Action<T1, T2> action, "
                + "_ gap1, T2 arg2) "
                + "=> (arg1) => action(arg1, arg2);",

                "public static "
                + "Action "
                + "Partial<T1, T2>(this Action<T1, T2> action, "
                + "T1 arg1, T2 arg2) "
                + "=> () => action(arg1, arg2);"
            };

            // act
            var actual = _target.GenerateActionExtentions(2);

            // asserts
            for (var i = 0; i < actual.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }

        [Fact]
        public void GenerateFuncExtentions_0_Test()
        {
            const string expected = "public static "
                                    + "Func<TResult> "
                                    + "Partial<TResult>(this Func<TResult> func) "
                                    + "=> func;";

            var actual = _target.GenerateFuncExtentions(0).Single();

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
            var actual = _target.GenerateFuncExtentions(2);

            // asserts
            for (var i = 0; i < actual.Length; i++)
            {
                Assert.Equal(expected[i], actual[i]);
            }
        }
    }
}
