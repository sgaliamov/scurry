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
        public void Curry_Action_0()
        {
            // arrange
            var actual = -1;
            Action action = () =>
            {
                actual = TestFunctions.Zero();
            };

            // act
            var curried = action.Curry();
            curried();

            // assert
            Assert.Equal(0, actual);
        }

        [Fact]
        public void Curry_Action_1()
        {
            // arrange
            var actual = -1;
            Action<int> action = (arg1) =>
            {
                actual = TestFunctions.Add1(arg1);
            };

            // act
            var curried = action.Curry();
            curried(1);

            // assert
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Curry_Action_2()
        {
            // arrange
            var actual = -1;
            Action<int, int> action = (arg1, arg2) =>
            {
                actual = TestFunctions.Add2(arg1, arg2);
            };

            // act
            var curried = action.Curry();
            curried(1)(2);

            // assert
            Assert.Equal(3, actual);
        }

        [Fact]
        public void Curry_Action_3()
        {
            // arrange
            var actual = -1;
            Action<int, int, int> action = (arg1, arg2, arg3) =>
            {
                actual = TestFunctions.Add3(arg1, arg2, arg3);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3);

            // assert
            Assert.Equal(6, actual);
        }

        [Fact]
        public void Curry_Action_4()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int> action = (arg1, arg2, arg3, arg4) =>
            {
                actual = TestFunctions.Add4(arg1, arg2, arg3, arg4);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4);

            // assert
            Assert.Equal(10, actual);
        }

        [Fact]
        public void Curry_Action_5()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5) =>
            {
                actual = TestFunctions.Add5(arg1, arg2, arg3, arg4, arg5);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5);

            // assert
            Assert.Equal(15, actual);
        }

        [Fact]
        public void Curry_Action_6()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                actual = TestFunctions.Add6(arg1, arg2, arg3, arg4, arg5, arg6);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6);

            // assert
            Assert.Equal(21, actual);
        }

        [Fact]
        public void Curry_Action_7()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                actual = TestFunctions.Add7(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7);

            // assert
            Assert.Equal(28, actual);
        }

        [Fact]
        public void Curry_Action_8()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) =>
            {
                actual = TestFunctions.Add8(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8);

            // assert
            Assert.Equal(36, actual);
        }

        [Fact]
        public void Curry_Action_9()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) =>
            {
                actual = TestFunctions.Add9(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9);

            // assert
            Assert.Equal(45, actual);
        }

        [Fact]
        public void Curry_Action_10()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) =>
            {
                actual = TestFunctions.Add10(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9)(10);

            // assert
            Assert.Equal(55, actual);
        }

        [Fact]
        public void Curry_Action_11()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) =>
            {
                actual = TestFunctions.Add11(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11);

            // assert
            Assert.Equal(66, actual);
        }

        [Fact]
        public void Curry_Action_12()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) =>
            {
                actual = TestFunctions.Add12(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12);

            // assert
            Assert.Equal(78, actual);
        }

        [Fact]
        public void Curry_Action_13()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) =>
            {
                actual = TestFunctions.Add13(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13);

            // assert
            Assert.Equal(91, actual);
        }

        [Fact]
        public void Curry_Action_14()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) =>
            {
                actual = TestFunctions.Add14(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14);

            // assert
            Assert.Equal(105, actual);
        }

        [Fact]
        public void Curry_Action_15()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) =>
            {
                actual = TestFunctions.Add15(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15);

            // assert
            Assert.Equal(120, actual);
        }

        [Fact]
        public void Curry_Action_16()
        {
            // arrange
            var actual = -1;
            Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) =>
            {
                actual = TestFunctions.Add16(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            };

            // act
            var curried = action.Curry();
            curried(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)(11)(12)(13)(14)(15)(16);

            // assert
            Assert.Equal(136, actual);
        }
    }
}
