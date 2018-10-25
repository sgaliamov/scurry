﻿/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___ 
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _| 
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;

namespace SCurry
{
    public static class UncurryActions
    {
        public static Action Uncurry(this Action curry) => curry;
        public static Action<T1> Uncurry<T1>(this Action<T1> curry) => curry;
        public static Action<T1, T2> Uncurry<T1, T2>(this Func<T1, Action<T2>> curry) => (T1 arg1, T2 arg2) => curry(arg1)(arg2);
        public static Action<T1, T2, T3> Uncurry<T1, T2, T3>(this Func<T1, Func<T2, Action<T3>>> curry) => (T1 arg1, T2 arg2, T3 arg3) => curry(arg1)(arg2)(arg3);
        public static Action<T1, T2, T3, T4> Uncurry<T1, T2, T3, T4>(this Func<T1, Func<T2, Func<T3, Action<T4>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4) => curry(arg1)(arg2)(arg3)(arg4);
        public static Action<T1, T2, T3, T4, T5> Uncurry<T1, T2, T3, T4, T5>(this Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => curry(arg1)(arg2)(arg3)(arg4)(arg5);
        public static Action<T1, T2, T3, T4, T5, T6> Uncurry<T1, T2, T3, T4, T5, T6>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6);
        public static Action<T1, T2, T3, T4, T5, T6, T7> Uncurry<T1, T2, T3, T4, T5, T6, T7>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13)(arg14);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13)(arg14)(arg15);
        public static Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Uncurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> curry) => (T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15, T16 arg16) => curry(arg1)(arg2)(arg3)(arg4)(arg5)(arg6)(arg7)(arg8)(arg9)(arg10)(arg11)(arg12)(arg13)(arg14)(arg15)(arg16);
    }
}
