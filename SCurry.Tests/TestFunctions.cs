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
        public static readonly Func<int, int> Id = (int i) => i;
        public static readonly Func<int, int, int> Add2 = (int arg1, int arg2) => arg1 + arg2;
        public static readonly Func<int, int, int, int> Add3 = (int arg1, int arg2, int arg3) => arg1 + arg2 + arg3;
        public static readonly Func<int, int, int, int, int> Add4 = (int arg1, int arg2, int arg3, int arg4) => arg1 + arg2 + arg3 + arg4;
        public static readonly Func<int, int, int, int, int, int> Add5 = (int arg1, int arg2, int arg3, int arg4, int arg5) => arg1 + arg2 + arg3 + arg4 + arg5;
        public static readonly Func<int, int, int, int, int, int, int> Add6 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6;
        public static readonly Func<int, int, int, int, int, int, int, int> Add7 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7;
        public static readonly Func<int, int, int, int, int, int, int, int, int> Add8 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int> Add9 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int> Add10 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int> Add11 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int> Add12 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add13 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12, int arg13) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add14 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12, int arg13, int arg14) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13 + arg14;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add15 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12, int arg13, int arg14, int arg15) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13 + arg14 + arg15;
        public static readonly Func<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> Add16 = (int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, int arg10, int arg11, int arg12, int arg13, int arg14, int arg15, int arg16) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8 + arg9 + arg10 + arg11 + arg12 + arg13 + arg14 + arg15 + arg16;
    }
}
