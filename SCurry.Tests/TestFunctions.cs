/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _|
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/
using System;

namespace SCurry.Tests
{
    public static class TestFunctions
    {
        public static readonly Func<int> Zero = () => 0;
        public static readonly Func<int, int> Id = i => i;
        public static readonly Func<int, int, int> Add2 = (arg1, arg2) => arg1 + arg2;
        public static readonly Func<int, int, int, int> Add3 = (arg1, arg2, arg3) => arg1 + arg2 + arg3;
        public static readonly Func<int, int, int, int, int> Add4 = (arg1, arg2, arg3, arg4) => arg1 + arg2 + arg3 + arg4;
        public static readonly Func<int, int, int, int, int, int> Add5 = (arg1, arg2, arg3, arg4, arg5) => arg1 + arg2 + arg3 + arg4 + arg5;
        public static readonly Func<int, int, int, int, int, int, int> Add6 = (arg1, arg2, arg3, arg4, arg5, arg6) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6;
        public static readonly Func<int, int, int, int, int, int, int, int> Add7 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7;
        public static readonly Func<int, int, int, int, int, int, int, int, int> Add8 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int> Add9 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int> Add10 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int> Add11 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int> Add12 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add13 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add14 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13 + arg14;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add15 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13 + arg14 + arg15;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add16 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13 + arg14 + arg15 + arg16;
    }
}
