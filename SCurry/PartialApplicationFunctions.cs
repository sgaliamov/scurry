﻿/*
   ___ ___ _  _ ___ ___    _ _____ ___ ___     ___ ___  ___  ___ 
  / __| __| \| | __| _ \  /_\_   _| __|   \   / __/ _ \|   \| __|
 | (_ | _|| .` | _||   / / _ \| | | _|| |) | | (_| (_) | |) | _| 
  \___|___|_|\_|___|_|_\/_/ \_\_| |___|___/   \___\___/|___/|___|

*/

using System;

namespace SCurry
{
    using _ = Spacer.SpacerInstance;

    public static class PartialApplicationFunctions
    {
        public static Func<TResult> Partial<TResult>(this Func<TResult> func) => func;
        public static Func<T1, TResult> Partial<T1, TResult>(this Func<T1, TResult> func, _ gap1) => func;
        public static Func<TResult> Partial<T1, TResult>(this Func<T1, TResult> func, T1 arg1) => () => func(arg1);
        public static Func<T1, T2, TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, _ gap1, _ gap2) => func;
        public static Func<T2, TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 arg1, _ gap2) => (arg2) => func(arg1, arg2);
        public static Func<T1, TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, _ gap1, T2 arg2) => (arg1) => func(arg1, arg2);
        public static Func<TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 arg1, T2 arg2) => () => func(arg1, arg2);
        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, _ gap2, _ gap3) => func;
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, _ gap2, _ gap3) => (arg2, arg3) => func(arg1, arg2, arg3);
        public static Func<T1, T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, T2 arg2, _ gap3) => (arg1, arg3) => func(arg1, arg2, arg3);
        public static Func<T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, _ gap3) => (arg3) => func(arg1, arg2, arg3);
        public static Func<T1, T2, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, _ gap2, T3 arg3) => (arg1, arg2) => func(arg1, arg2, arg3);
        public static Func<T2, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, _ gap2, T3 arg3) => (arg2) => func(arg1, arg2, arg3);
        public static Func<T1, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, T2 arg2, T3 arg3) => (arg1) => func(arg1, arg2, arg3);
        public static Func<TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3) => () => func(arg1, arg2, arg3);
        public static Func<T1, T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, _ gap2, _ gap3, _ gap4) => func;
        public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, _ gap2, _ gap3, _ gap4) => (arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2, _ gap3, _ gap4) => (arg1, arg3, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, _ gap3, _ gap4) => (arg3, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T2, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, _ gap2, T3 arg3, _ gap4) => (arg1, arg2, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T2, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, _ gap2, T3 arg3, _ gap4) => (arg2, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2, T3 arg3, _ gap4) => (arg1, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3, _ gap4) => (arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4) => (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4) => (arg2, arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4) => (arg1, arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4) => (arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T2, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4) => (arg1, arg2) => func(arg1, arg2, arg3, arg4);
        public static Func<T2, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4) => (arg2) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4) => (arg1) => func(arg1, arg2, arg3, arg4);
        public static Func<TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => () => func(arg1, arg2, arg3, arg4);
    }
}
