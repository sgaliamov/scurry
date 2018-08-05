/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___ 
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _| 
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using Xunit; 

namespace SCurry.Tests
{
    public class CurryFunctionsTests
    {
        [Fact]
        public void Curry1_Test()
        {
            var curryed = TestFunctions.Id.Curry();

            var actual = curryed(1);

            Assert.Equal(1, actual);
        }

        [Fact]
        public void Curry2_Test()
        {
            var curryedAdd = TestFunctions.Add2.Curry();

            var actual = curryedAdd(1)(2);

            Assert.Equal(3, actual);
        }

        [Fact]
        public void Curry3_Test()
        {
            var curryedAdd = TestFunctions.Add3.Curry();

            var actual = curryedAdd(1)(2)(3);

            Assert.Equal(6, actual);
        }

        [Fact]
        public void Curry4_Test()
        {
            var curryedAdd = TestFunctions.Add4.Curry();

            var actual = curryedAdd(1)(2)(3)(4);

            Assert.Equal(10, actual);
        }

        [Fact]
        public void Curry5_Test()
        {
            var curryedAdd = TestFunctions.Add5.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5);

            Assert.Equal(15, actual);
        }

        [Fact]
        public void Curry6_Test()
        {
            var curryedAdd = TestFunctions.Add6.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6);

            Assert.Equal(21, actual);
        }

        [Fact]
        public void Curry7_Test()
        {
            var curryedAdd = TestFunctions.Add7.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7);

            Assert.Equal(28, actual);
        }

        [Fact]
        public void Curry8_Test()
        {
            var curryedAdd = TestFunctions.Add8.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8);

            Assert.Equal(36, actual);
        }

        [Fact]
        public void Curry9_Test()
        {
            var curryedAdd = TestFunctions.Add9.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9);

            Assert.Equal(45, actual);
        }

        [Fact]
        public void Curry10_Test()
        {
            var curryedAdd = TestFunctions.Add10.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            Assert.Equal(55, actual);
        }

        [Fact]
        public void Curry11_Test()
        {
            var curryedAdd = TestFunctions.Add11.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            Assert.Equal(66, actual);
        }

        [Fact]
        public void Curry12_Test()
        {
            var curryedAdd = TestFunctions.Add12.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            Assert.Equal(78, actual);
        }

        [Fact]
        public void Curry13_Test()
        {
            var curryedAdd = TestFunctions.Add13.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            Assert.Equal(91, actual);
        }

        [Fact]
        public void Curry14_Test()
        {
            var curryedAdd = TestFunctions.Add14.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            Assert.Equal(105, actual);
        }

        [Fact]
        public void Curry15_Test()
        {
            var curryedAdd = TestFunctions.Add15.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            Assert.Equal(120, actual);
        }

        [Fact]
        public void Curry16_Test()
        {
            var curryedAdd = TestFunctions.Add16.Curry();

            var actual = curryedAdd(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)(16);

            Assert.Equal(136, actual);
        }

        [Fact]
        public void Curry0_Test()
        {
            var curryed = TestFunctions.Zero.Curry();

            var actual = curryed();

            Assert.Equal(0, actual);
        }
    }
}
