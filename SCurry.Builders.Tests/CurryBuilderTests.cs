using AutoFixture;
using Xunit;

namespace SCurry.Builders.Tests
{
    [Trait("Category", "Builder")]
    public class CurryBuilderTests
    {
        private readonly Fixture _fixture = new Fixture();

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void TypeParameters_AppendResult_Test(ushort count)
        {
            var expected = count == 0
                ? "TResult"
                : count == 1
                    ? "T1, TResult"
                    : "T1, T2, T3, TResult";

            var actual = CurryBuilder.TypeParameters(true, count);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void TypeParameters_NoResult_Test(ushort count)
        {
            var expected = count == 0
                ? string.Empty
                : count == 1
                    ? "T1"
                    : "T1, T2, T3";

            var actual = CurryBuilder.TypeParameters(false, count);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void FuncReturnType_Test(ushort count)
        {
            var result = _fixture.Create<string>();
            var expected = count == 0
                ? $"Func<{result}>"
                : count == 1
                    ? $"Func<T1, {result}>"
                    : $"Func<T1, Func<T2, Func<T3, {result}>>>";

            var actual = CurryBuilder.FuncReturnType(count, result);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void ActionReturnType_Test(ushort count)
        {
            var expected = count == 0
                ? "Action"
                : count == 1
                    ? "Action<T1>"
                    : "Func<T1, Func<T2, Action<T3>>>";

            var actual = CurryBuilder.ActionReturnType(count);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void Body_Test(ushort count)
        {
            var target = _fixture.Create<string>();
            var expected = count == 0 || count == 1
                ? target
                : $"arg1 => arg2 => arg3 => {target}(arg1, arg2, arg3)";

            var actual = CurryBuilder.Body(target, count);

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

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(3)]
        public void GenerateActionExtention_Test(ushort count)
        {
            var expected = count == 0
                ? "public static Action Curry(this Action action) => action;"
                : count == 1
                    ? "public static Action<T1> Curry<T1>(this Action<T1> action) => action;"
                    : "public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>"
                      + "(this Action<T1, T2, T3> action) => "
                      + "arg1 => arg2 => arg3 => action(arg1, arg2, arg3);";

            var actual = CurryBuilder.GenerateActionExtention(count);

            Assert.Equal(expected, actual);
        }
    }
}