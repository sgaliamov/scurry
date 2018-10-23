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
    }
}
