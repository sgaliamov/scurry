/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___ 
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _| 
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using Xunit;

namespace SCurry.Tests
{
    [Trait("Category", "Curry")]
    public class CurryFunctionsTests
    {
        [Fact]
        public void Curry_Func_0_Test()
        {
            var curryed = TestFunctions.Zero.Curry();

            var actual = curryed();

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Curry_Func_1_Test()
        {
            var curryedAdd = TestFunctions.Add1.Curry();

            var actual = curryedAdd(1);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Curry_Func_2_Test()
        {
            var curryedAdd = TestFunctions.Add2.Curry();

            var actual = curryedAdd(1)(2);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void Curry_Func_3_Test()
        {
            var curryedAdd = TestFunctions.Add3.Curry();

            var actual = curryedAdd(1)(2)(3);

            Assert.Equal(6, actual);
        }

        [Fact]
        public void Curry_Func_4_Test()
        {
            var curryedAdd = TestFunctions.Add4.Curry();

            var actual = curryedAdd(1)(2)(3)(4);

            Assert.Equal(10, actual);
        }

        [Fact]
        public void Curry_Func_5_Test()
        {
            var curryedAdd = TestFunctions.Add5.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5);

            Assert.Equal(15, actual);
        }

        [Fact]
        public void Curry_Func_6_Test()
        {
            var curryedAdd = TestFunctions.Add6.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6);

            Assert.Equal(21, actual);
        }

        [Fact]
        public void Curry_Func_7_Test()
        {
            var curryedAdd = TestFunctions.Add7.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7);

            Assert.Equal(28, actual);
        }

        [Fact]
        public void Curry_Func_8_Test()
        {
            var curryedAdd = TestFunctions.Add8.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8);

            Assert.Equal(36, actual);
        }
    }
}
