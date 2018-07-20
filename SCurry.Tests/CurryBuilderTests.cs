using SCurry.Builders;
using Xunit;

namespace SCurry.Tests
{
    public class CurryBuilderTests
    {
        [Fact]
        public void Arguments_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void Body_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void GenerateAllFuncExtentions_0_Test()
        {
            var actual = CurryBuilder.GenerateAllFuncExtentions(0);

            Assert.Equal("", actual);
        }

        [Fact]
        public void GenerateAllFuncExtentions_3_Test()
        {
            var actual = CurryBuilder.GenerateAllFuncExtentions(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void GenerateFuncExtention_0_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(0);

            const string result = "public static Func<TResult> "
                                  + "Curry<TResult>(this Func<TResult> func) "
                                  + "=> func;";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void GenerateFuncExtention_3_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void ReturnType_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }

        [Fact]
        public void TypeParameters_Test()
        {
            var actual = CurryBuilder.GenerateFuncExtention(3);

            const string result = "public static Func<T1, Func<T2, Func<T3, TResult>>> "
                                  + "Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func) "
                                  + "=> a => b => c => func(a, b, c);";

            Assert.Equal(result, actual);
        }
    }
}