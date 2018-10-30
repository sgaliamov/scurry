/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___ 
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _| 
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;

namespace SCurry
{
    using _ = Spacer.SpacerInstance;

    public static class CurryActions
    {
        public static Action Curry(this Action action) => action;
        public static Action<T1> Curry<T1>(this Action<T1> action) => action;
        public static Action Curry<T1>(this Action<T1> action, T1 arg1) => () => action(arg1);
        public static Func<T1, Action<T2>> Curry<T1, T2>(this Action<T1, T2> action) => arg1 => arg2 => action(arg1, arg2);
        public static Action<T2> Curry<T1, T2>(this Action<T1, T2> action, T1 arg1) => arg2 => action(arg1, arg2);
        public static Action Curry<T1, T2>(this Action<T1, T2> action, T1 arg1, T2 arg2) => () => action(arg1, arg2);
        public static Func<T1, Func<T2, Action<T3>>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action) => arg1 => arg2 => arg3 => action(arg1, arg2, arg3);
        public static Func<T2, Action<T3>> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1) => arg2 => arg3 => action(arg1, arg2, arg3);
        public static Action<T3> Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2) => arg3 => action(arg1, arg2, arg3);
        public static Action Curry<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) => () => action(arg1, arg2, arg3);
        public static Func<T1, Func<T2, Func<T3, Action<T4>>>> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action) => arg1 => arg2 => arg3 => arg4 => action(arg1, arg2, arg3, arg4);
        public static Func<T2, Func<T3, Action<T4>>> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1) => arg2 => arg3 => arg4 => action(arg1, arg2, arg3, arg4);
        public static Func<T3, Action<T4>> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2) => arg3 => arg4 => action(arg1, arg2, arg3, arg4);
        public static Action<T4> Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3) => arg4 => action(arg1, arg2, arg3, arg4);
        public static Action Curry<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => () => action(arg1, arg2, arg3, arg4);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action) => arg1 => arg2 => arg3 => arg4 => arg5 => action(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, Func<T3, Func<T4, Action<T5>>>> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1) => arg2 => arg3 => arg4 => arg5 => action(arg1, arg2, arg3, arg4, arg5);
        public static Func<T3, Func<T4, Action<T5>>> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2) => arg3 => arg4 => arg5 => action(arg1, arg2, arg3, arg4, arg5);
        public static Func<T4, Action<T5>> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3) => arg4 => arg5 => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T5> Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => arg5 => action(arg1, arg2, arg3, arg4, arg5);
        public static Action Curry<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => () => action(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1) => arg2 => arg3 => arg4 => arg5 => arg6 => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, Func<T4, Func<T5, Action<T6>>>> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2) => arg3 => arg4 => arg5 => arg6 => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T4, Func<T5, Action<T6>>> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3) => arg4 => arg5 => arg6 => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T5, Action<T6>> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => arg5 => arg6 => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T6> Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => arg6 => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action Curry<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => () => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1) => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2) => arg3 => arg4 => arg5 => arg6 => arg7 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Func<T4, Func<T5, Func<T6, Action<T7>>>> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3) => arg4 => arg5 => arg6 => arg7 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Func<T5, Func<T6, Action<T7>>> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => arg5 => arg6 => arg7 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Func<T6, Action<T7>> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => arg6 => arg7 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Action<T7> Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => arg7 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Action Curry<T1, T2, T3, T4, T5, T6, T7>(this Action<T1, T2, T3, T4, T5, T6, T7> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => () => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1) => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2) => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3) => arg4 => arg5 => arg6 => arg7 => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Func<T5, Func<T6, Func<T7, Action<T8>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => arg5 => arg6 => arg7 => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Func<T6, Func<T7, Action<T8>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => arg6 => arg7 => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Func<T7, Action<T8>> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => arg7 => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Action<T8> Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7) => arg8 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Action Curry<T1, T2, T3, T4, T5, T6, T7, T8>(this Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8) => () => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Action<T16>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action) => arg1 => arg2 => arg3 => arg4 => arg5 => arg6 => arg7 => arg8 => arg9 => arg10 => arg11 => arg12 => arg13 => arg14 => arg15 => arg16 => action(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
    }
}
