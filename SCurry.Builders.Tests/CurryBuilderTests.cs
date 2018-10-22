using System.Linq;
using FluentAssertions;
using SCurry.Builders.Builders;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class CurryBuilderTests
    {
        [Fact]
        public void Generate_Action_Extentions_For_3_Arguments_With_No_Gaps()
        {
            var expected = new[]
            {
                "public static Action Curry(this Action action) => action;",
                "public static Action<T1> Curry<T1>(this Action<T1> action) => action;",
                "public static Func<T1, Action<T2>> Curry<T1, T2>(this Action<T1, T2> action) => arg1 => arg2 => action(arg1, arg2);",
                "public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action) => arg1 => arg2 => arg3 => action(arg1, arg2, arg3);"
            };

            var actual = _target.GenerateActionExtentions(0, 3).ToArray();

            actual.Should().BeEquivalentTo(expected);
        }

        //[Fact]
        //public void Generate_Action_Extentions_For_3_Arguments_With_2_Gaps()
        //{
        //    var expected = new[]
        //    {
        //        "public static Action Curry(this Action action) => action;",
        //        "public static Action<T1> Curry<T1>(this Action<T1> action) => action;",
        //        "public static Func<T1, Action<T2>> Curry<T1, T2>(this Action<T1, T2> action) => arg1 => arg2 => action(arg1, arg2);",
        //        "public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action) => arg1 => arg2 => arg3 => action(arg1, arg2, arg3);"
        //    };

        //    var actual = _target.GenerateActionExtentions(2, 3);

        //    actual.Should().BeEquivalentTo(expected);
        //}

        [Fact]
        public void Generate_Func_Extentions_For_3_Arguments_With_No_Gaps()
        {
            var expected = new[]
            {
                "public static Func<TResult> Curry<TResult>(this Func<TResult> func) => func;",
                "public static Func<T1, TResult> Curry<T1, TResult>(this Func<T1, TResult> func) => func;",
                "public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> func) => arg1 => arg2 => func(arg1, arg2);",
                "public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) => arg1 => arg2 => arg3 => func(arg1, arg2, arg3);"
            };
            var actual = _target.GenerateFuncExtentions(0, 3);

            actual.Should().BeEquivalentTo(expected);
        }

        private readonly CurryBuilder _target = new CurryBuilder();
    }
}
