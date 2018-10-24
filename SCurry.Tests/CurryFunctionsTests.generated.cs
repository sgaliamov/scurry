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
        public void Curry_Func_0()
        {
            var curryed = TestFunctions.Zero.Curry();

            var actual = curryed();

            Assert.Equal(0, actual);
        }

        [Fact]
        public void Curry_Func_1()
        {
            var curryedAdd = TestFunctions.Add1.Curry();

            var actual = curryedAdd(1);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Curry_Func_2()
        {
            var curryedAdd = TestFunctions.Add2.Curry();

            var actual = curryedAdd(1)(2);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void Curry_Func_3()
        {
            var curryedAdd = TestFunctions.Add3.Curry();

            var actual = curryedAdd(1)(2)(3);

            Assert.Equal(6, actual);
        }

        [Fact]
        public void Curry_Func_4()
        {
            var curryedAdd = TestFunctions.Add4.Curry();

            var actual = curryedAdd(1)(2)(3)(4);

            Assert.Equal(10, actual);
        }

        [Fact]
        public void Curry_Func_5()
        {
            var curryedAdd = TestFunctions.Add5.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5);

            Assert.Equal(15, actual);
        }

        [Fact]
        public void Curry_Func_6()
        {
            var curryedAdd = TestFunctions.Add6.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6);

            Assert.Equal(21, actual);
        }

        [Fact]
        public void Curry_Func_7()
        {
            var curryedAdd = TestFunctions.Add7.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7);

            Assert.Equal(28, actual);
        }

        [Fact]
        public void Curry_Func_8()
        {
            var curryedAdd = TestFunctions.Add8.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8);

            Assert.Equal(36, actual);
        }

        [Fact]
        public void Curry_Func_9()
        {
            var curryedAdd = TestFunctions.Add9.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9);

            Assert.Equal(45, actual);
        }

        [Fact]
        public void Curry_Func_10()
        {
            var curryedAdd = TestFunctions.Add10.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            Assert.Equal(55, actual);
        }

        [Fact]
        public void Curry_Func_11()
        {
            var curryedAdd = TestFunctions.Add11.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            Assert.Equal(66, actual);
        }

        [Fact]
        public void Curry_Func_12()
        {
            var curryedAdd = TestFunctions.Add12.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            Assert.Equal(78, actual);
        }

        [Fact]
        public void Curry_Func_13()
        {
            var curryedAdd = TestFunctions.Add13.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            Assert.Equal(91, actual);
        }

        [Fact]
        public void Curry_Func_14()
        {
            var curryedAdd = TestFunctions.Add14.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            Assert.Equal(105, actual);
        }

        [Fact]
        public void Curry_Func_15()
        {
            var curryedAdd = TestFunctions.Add15.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            Assert.Equal(120, actual);
        }

        [Fact]
        public void Curry_Func_16()
        {
            var curryedAdd = TestFunctions.Add16.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)(16);

            Assert.Equal(136, actual);
        }
    }
}
