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
        public static readonly Func<int, int> Add1 = (arg1) => arg1;
        public static readonly Func<int, int, int> Add2 = (arg1, arg2) => arg1 + arg2;
        public static readonly Func<int, int, int, int> Add3 = (arg1, arg2, arg3) => arg1 + arg2 + arg3;
        public static readonly Func<int, int, int, int, int> Add4 = (arg1, arg2, arg3, arg4) => arg1 + arg2 + arg3 + arg4;
        public static readonly Func<int, int, int, int, int, int> Add5 = (arg1, arg2, arg3, arg4, arg5) => arg1 + arg2 + arg3 + arg4 + arg5;
        public static readonly Func<int, int, int, int, int, int, int> Add6 = (arg1, arg2, arg3, arg4, arg5, arg6) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6;
        public static readonly Func<int, int, int, int, int, int, int, int> Add7 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7;
        public static readonly Func<int, int, int, int, int, int, int, int, int> Add8 = (arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8) => arg1 + arg2 + arg3 + arg4 + arg5 + arg6 + arg7 + arg8;
    }
}
