using System.Linq;
using FluentAssertions;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class PartialApplicationBuilderTests
    {
        [Fact]
        public void Generate_Action_Extentions_For_1_Argument()
        {
            var expected = new[]
            {
                "public static Action Partial(this Action action) => action;",
                "public static Action Partial<T1>(this Action<T1> action, T1 arg1) => () => action(arg1);"
            };

            var actual = _target.GenerateActionExtentions(0, 1).ToArray();

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Action_Extentions_For_2_Argument_2_Gaps()
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

            var actual = _target.GenerateActionExtentions(2, 2);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Function_Extentions_For_1_Argument()
        {
            var expected = new[]
            {
                "public static Func<TResult> Partial<TResult>(this Func<TResult> func) => func;",
                "public static Func<TResult> Partial<T1, TResult>(this Func<T1, TResult> func, T1 arg1) => () => func(arg1);"
            };

            var actual = _target.GenerateFuncExtentions(0, 1).ToArray();

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Function_Extentions_For_2_Argument_2_Gaps()
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
            var actual = _target.GenerateFuncExtentions(2, 2);

            // asserts
            actual.Should().BeEquivalentTo(expected);
        }

        private readonly PartialApplicationBuilder _target = new PartialApplicationBuilder();
    }
}
