/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___ 
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _| 
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;
using Xunit;

namespace SCurry.Tests
{
    [Trait("Category", "Curry")]
    public class CurryActionsTests
    {
        [Fact]
        public void Curry_Action_0_Test()
        {
            // arrange
            var actual = -1;
            Action action = () =>
            {
                actual = TestFunctions.Zero();
            };

            // act
            var curryed = action.Curry();
            curryed();

            // assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Curry_Action_1_Test()
        {
            // arrange
            var actual = -1;
            Action<int> action = (arg1) => 
            {
                actual = TestFunctions.Add1(arg1);
            };

            // act
            var curryed = action.Curry();
            curryed(1);

            // assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Curry_Action_2_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int> action = (arg1, arg2) => 
            {
                actual = TestFunctions.Add2(arg1, arg2);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2);

            // assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void Curry_Action_3_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int> action = (arg1, arg2, arg3) => 
            {
                actual = TestFunctions.Add3(arg1, arg2, arg3);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3);

            // assert
            Assert.Equal(6, actual);
        }

        [Fact]
        public void Curry_Action_4_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int> action = (arg1, arg2, arg3, arg4) => 
            {
                actual = TestFunctions.Add4(arg1, arg2, arg3, arg4);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4);

            // assert
            Assert.Equal(10, actual);
        }

        [Fact]
        public void Curry_Action_5_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5) => 
            {
                actual = TestFunctions.Add5(arg1, arg2, arg3, arg4, arg5);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5);

            // assert
            Assert.Equal(15, actual);
        }

        [Fact]
        public void Curry_Action_6_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6) => 
            {
                actual = TestFunctions.Add6(arg1, arg2, arg3, arg4, arg5, arg6);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6);

            // assert
            Assert.Equal(21, actual);
        }

        [Fact]
        public void Curry_Action_7_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => 
            {
                actual = TestFunctions.Add7(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7);

            // assert
            Assert.Equal(28, actual);
        }

        [Fact]
        public void Curry_Action_8_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => 
            {
                actual = TestFunctions.Add8(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8);

            // assert
            Assert.Equal(36, actual);
        }

        [Fact]
        public void Curry_Action_9_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => 
            {
                actual = TestFunctions.Add9(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9);

            // assert
            Assert.Equal(45, actual);
        }

        [Fact]
        public void Curry_Action_10_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => 
            {
                actual = TestFunctions.Add10(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            // assert
            Assert.Equal(55, actual);
        }

        [Fact]
        public void Curry_Action_11_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => 
            {
                actual = TestFunctions.Add11(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            // assert
            Assert.Equal(66, actual);
        }

        [Fact]
        public void Curry_Action_12_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => 
            {
                actual = TestFunctions.Add12(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            // assert
            Assert.Equal(78, actual);
        }

        [Fact]
        public void Curry_Action_13_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => 
            {
                actual = TestFunctions.Add13(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            // assert
            Assert.Equal(91, actual);
        }

        [Fact]
        public void Curry_Action_14_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => 
            {
                actual = TestFunctions.Add14(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            // assert
            Assert.Equal(105, actual);
        }

        [Fact]
        public void Curry_Action_15_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => 
            {
                actual = TestFunctions.Add15(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            // assert
            Assert.Equal(120, actual);
        }

        [Fact]
        public void Curry_Action_16_Test()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => 
            {
                actual = TestFunctions.Add16(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            };

            // act
            var curryed = action.Curry();
            curryed(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)(16);

            // assert
            Assert.Equal(136, actual);
        }
    }
}
