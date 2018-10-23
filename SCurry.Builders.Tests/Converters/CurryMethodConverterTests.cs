using System.Linq;
using FluentAssertions;
using SCurry.Builders.Converters;
using SCurry.Builders.Models;
using Xunit;

namespace SCurry.Builders.Tests.Converters
{
    [Trait("Category", "Builder")]
    public class CurryMethodConverterTests
    {
        [Fact]
        public void Generate_Action_Extentions_For_0_Arguments_With_2_Gaps()
        {
            var expected = new[]
            {
                "public static Action Curry(this Action action) => action;"
            };

            var actual = Convert(MethodType.Action, 2, 0);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Generate_Action_Extentions_For_1_Arguments_With_0_Or_1_Gap(int gaps)
        {
            var expected = new[]
            {
                "public static Action<T1> Curry<T1>(this Action<T1> action) => action;",
                "public static Action Curry<T1>(this Action<T1> action, T1 arg1) => () => action(arg1);"
            };

            var actual = Convert(MethodType.Action, gaps, 1);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Action_Extentions_For_3_Arguments_With_0_Gaps()
        {
            var expected = new[]
            {
                "public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action) => arg1 => arg2 => arg3 => action(arg1, arg2, arg3);",
                "public static Func<T2, Action<T3>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1) => arg2 => arg3 => action(arg1, arg2, arg3);",
                "public static Action<T3> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2) => arg3 => action(arg1, arg2, arg3);",
                "public static Action Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) => () => action(arg1, arg2, arg3);"
            };

            var actual = Convert(MethodType.Action, 0, 3);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Action_Extentions_For_3_Arguments_With_2_Gaps()
        {
            var expected = new[]
            {
                "public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action) => arg1 => arg2 => arg3 => action(arg1, arg2, arg3);",
                "public static Func<T2, Action<T3>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1) => arg2 => arg3 => action(arg1, arg2, arg3);",
                "public static Func<T1, Action<T3>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, _ gap1, T2 arg2) => arg1 => arg3 => action(arg1, arg2, arg3);",
                "public static Action<T3> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2) => arg3 => action(arg1, arg2, arg3);",
                "public static Action Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) => () => action(arg1, arg2, arg3);"
            };

            var actual = Convert(MethodType.Action, 2, 3);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Func_Extentions_For_0_Arguments_With_2_Gaps()
        {
            var expected = new[]
            {
                "public static Func<TResult> Curry<TResult>(this Func<TResult> func) => func;"
            };

            var actual = Convert(MethodType.Function, 2, 0);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void Generate_Func_Extentions_For_1_Arguments_With_0_Or_1_Gap(int gaps)
        {
            var expected = new[]
            {
                "public static Func<T1, TResult> Curry<T1, TResult>(this Func<T1, TResult> func) => func;",
                "public static Func<TResult> Curry<T1, TResult>(this Func<T1, TResult> func, T1 arg1) => () => func(arg1);"
            };

            var actual = Convert(MethodType.Function, gaps, 1);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Func_Extentions_For_3_Arguments_With_0_Gaps()
        {
            var expected = new[]
            {
                "public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) => arg1 => arg2 => arg3 => func(arg1, arg2, arg3);",
                "public static Func<T2, Func<T3, TResult>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1) => arg2 => arg3 => func(arg1, arg2, arg3);",
                "public static Func<T3, TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2) => arg3 => func(arg1, arg2, arg3);",
                "public static Func<TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3) => () => func(arg1, arg2, arg3);"
            };

            var actual = Convert(MethodType.Function, 0, 3);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Generate_Func_Extentions_For_3_Arguments_With_2_Gaps()
        {
            var expected = new[]
            {
                "public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) => arg1 => arg2 => arg3 => func(arg1, arg2, arg3);",
                "public static Func<T2, Func<T3, TResult>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1) => arg2 => arg3 => func(arg1, arg2, arg3);",
                "public static Func<T1, Func<T3, TResult>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, T2 arg2) => arg1 => arg3 => func(arg1, arg2, arg3);",
                "public static Func<T3, TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2) => arg3 => func(arg1, arg2, arg3);",
                "public static Func<TResult> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3) => () => func(arg1, arg2, arg3);"
            };

            var actual = Convert(MethodType.Function, 2, 3);

            actual.Should().BeEquivalentTo(expected);
        }

        private readonly IConverter _target = MethodConverterFactory.CurryMethodConverter;

        private readonly MethodDefinitionsBuilder _definitionsBuilder = new MethodDefinitionsBuilder();

        private string[] Convert(MethodType methodType, int gapsCount, int argsCount) =>
            _definitionsBuilder.Build(methodType, gapsCount, argsCount)
                               .Select(_target.Convert)
                               .ToArray();
    }
}
