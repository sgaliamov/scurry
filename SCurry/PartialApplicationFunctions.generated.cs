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
        public static Func<TResult> Partial<T1, TResult>(this Func<T1, TResult> func, T1 arg1) => () => func(arg1);
        public static Func<T2, TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 arg1) => (arg2) => func(arg1, arg2);
        public static Func<T1, TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, _ gap1, T2 arg2) => (arg1) => func(arg1, arg2);
        public static Func<TResult> Partial<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 arg1, T2 arg2) => () => func(arg1, arg2);
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1) => (arg2, arg3) => func(arg1, arg2, arg3);
        public static Func<T1, T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, T2 arg2) => (arg1, arg3) => func(arg1, arg2, arg3);
        public static Func<T3, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2) => (arg3) => func(arg1, arg2, arg3);
        public static Func<T1, T2, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, _ gap2, T3 arg3) => (arg1, arg2) => func(arg1, arg2, arg3);
        public static Func<T2, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, _ gap2, T3 arg3) => (arg2) => func(arg1, arg2, arg3);
        public static Func<T1, TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, _ gap1, T2 arg2, T3 arg3) => (arg1) => func(arg1, arg2, arg3);
        public static Func<TResult> Partial<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3) => () => func(arg1, arg2, arg3);
        public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1) => (arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2) => (arg1, arg3, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2) => (arg3, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T2, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, _ gap2, T3 arg3) => (arg1, arg2, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T2, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, _ gap2, T3 arg3) => (arg2, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2, T3 arg3) => (arg1, arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3) => (arg4) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4) => (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4) => (arg2, arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4) => (arg1, arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T3, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4) => (arg3) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, T2, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4) => (arg1, arg2) => func(arg1, arg2, arg3, arg4);
        public static Func<T2, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4) => (arg2) => func(arg1, arg2, arg3, arg4);
        public static Func<T1, TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4) => (arg1) => func(arg1, arg2, arg3, arg4);
        public static Func<TResult> Partial<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => () => func(arg1, arg2, arg3, arg4);
        public static Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1) => (arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2) => (arg1, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2) => (arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T2, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, _ gap2, T3 arg3) => (arg1, arg2, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, _ gap2, T3 arg3) => (arg2, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2, T3 arg3) => (arg1, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3) => (arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T2, T3, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4) => (arg1, arg2, arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, T3, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4) => (arg2, arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T3, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4) => (arg1, arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T3, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4) => (arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T2, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4) => (arg1, arg2, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4) => (arg2, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4) => (arg1, arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => (arg5) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T2, T3, T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T3, T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg1, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T3, T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T2, T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg2, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg2, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T4, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg4) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T3, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg3) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T3, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg3) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, T2, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg2) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T1, TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => (arg1) => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<TResult> Partial<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => () => func(arg1, arg2, arg3, arg4, arg5);
        public static Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1) => (arg2, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2) => (arg1, arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2) => (arg3, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3) => (arg1, arg2, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3) => (arg2, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3) => (arg1, arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3) => (arg4, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T3, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4) => (arg1, arg2, arg3, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T3, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4) => (arg2, arg3, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4) => (arg1, arg3, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4) => (arg3, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4) => (arg1, arg2, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4) => (arg2, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4) => (arg1, arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => (arg5, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T3, T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg1, arg2, arg3, arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T3, T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg2, arg3, arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg1, arg3, arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg3, arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg2, arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg2, arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T4, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg4, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T3, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg2, arg3, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T3, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg2, arg3, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg3, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg3, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg1, arg2, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg2, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => (arg1, arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => (arg6) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg1, arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg2, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg1, arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg3, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg1, arg2, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg2, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg1, arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg4, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T3, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg2, arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T3, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg2, arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg3, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg2, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg2, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T5, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg5) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T3, T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg2, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg3, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg2, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg2, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T4, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg4) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, T3, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg1, arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, T3, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg2, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T3, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg1, arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T3, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg3) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, T2, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, _ gap2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => (arg1, arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T2, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, _ gap2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => (arg2) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<T1, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, _ gap1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => (arg1) => func(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Func<TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => () => func(arg1, arg2, arg3, arg4, arg5, arg6);
    }
}
