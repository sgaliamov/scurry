using System.Linq;
using FluentAssertions;
using SCurry.Builders.Converters;
using SCurry.Builders.Models;
using Xunit;

namespace SCurry.Builders.Tests.Converters
{
    [Trait("Category", "Builder")]
    public class UncurryMethodConverterTests
    {
        [Fact]
        public void Uncurry_Action_0_Args()
        {
            const string expected =
                "public static Action Uncurry(this Action curry) => curry;";

            var actual = Convert(MethodType.Action, 0);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Uncurry_Action_1_Args()
        {
            const string expected =
                "public static Action<T1> Uncurry<T1>(this Action<T1> curry) => curry;";

            var actual = Convert(MethodType.Action, 1);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Uncurry_Action_3_Args()
        {
            const string expected =
                "public static Action<T1, T2, T3> Uncurry<T1, T2, T3>(this Func<T1, Func<T2, Action<T3>>> curry) => (T1 arg1, T2 arg2, T3 arg3) => curry(arg1)(arg2)(arg3);";

            var actual = Convert(MethodType.Action, 3);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Uncurry_Function_0_Args()
        {
            const string expected =
                "public static Func<TResult> Uncurry<TResult>(this Func<TResult> curry) => curry;";

            var actual = Convert(MethodType.Function, 0);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Uncurry_Function_1_Args()
        {
            const string expected =
                "public static Func<T1, TResult> Uncurry<T1, TResult>(this Func<T1, TResult> curry) => curry;";

            var actual = Convert(MethodType.Function, 1);

            actual.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Uncurry_Function_3_Args()
        {
            const string expected =
                "public static Func<T1, T2, T3, TResult> Uncurry<T1, T2, T3, TResult>(this Func<T1, Func<T2, Func<T3, TResult>>> curry) => (T1 arg1, T2 arg2, T3 arg3) => curry(arg1)(arg2)(arg3);";

            var actual = Convert(MethodType.Function, 3);

            actual.Should().BeEquivalentTo(expected);
        }

        private readonly IConverter _target = MethodConverterFactory.UncurryMethodConverter;

        private readonly MethodDefinitionsBuilder _definitionsBuilder = new MethodDefinitionsBuilder();

        private string Convert(MethodType methodType, int argsCount) =>
            _definitionsBuilder.Build(methodType, 0, argsCount, 0)
                               .Select(_target.Convert)
                               .Single();
    }
}
