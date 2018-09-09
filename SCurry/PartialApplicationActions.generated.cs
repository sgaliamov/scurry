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

    public static class PartialApplicationActions
    {
        public static Action Partial(this Action action) => action;
        public static Action Partial<T1>(this Action<T1> action, T1 arg1) => () => action(arg1);
        public static Action<T2> Partial<T1, T2>(this Action<T1, T2> action, T1 arg1) => (arg2) => action(arg1, arg2);
        public static Action<T1> Partial<T1, T2>(this Action<T1, T2> action, _ gap1, T2 arg2) => (arg1) => action(arg1, arg2);
        public static Action Partial<T1, T2>(this Action<T1, T2> action, T1 arg1, T2 arg2) => () => action(arg1, arg2);
        public static Action<T2, T3> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1) => (arg2, arg3) => action(arg1, arg2, arg3);
        public static Action<T1, T3> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, _ gap1, T2 arg2) => (arg1, arg3) => action(arg1, arg2, arg3);
        public static Action<T3> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2) => (arg3) => action(arg1, arg2, arg3);
        public static Action<T1, T2> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, _ gap1, _ gap2, T3 arg3) => (arg1, arg2) => action(arg1, arg2, arg3);
        public static Action<T2> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, _ gap2, T3 arg3) => (arg2) => action(arg1, arg2, arg3);
        public static Action<T1> Partial<T1, T2, T3>(this Action<T1, T2, T3> action, _ gap1, T2 arg2, T3 arg3) => (arg1) => action(arg1, arg2, arg3);
        public static Action Partial<T1, T2, T3>(this Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3) => () => action(arg1, arg2, arg3);
        public static Action<T2, T3, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1) => (arg2, arg3, arg4) => action(arg1, arg2, arg3, arg4);
        public static Action<T1, T3, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, _ gap1, T2 arg2) => (arg1, arg3, arg4) => action(arg1, arg2, arg3, arg4);
        public static Action<T3, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2) => (arg3, arg4) => action(arg1, arg2, arg3, arg4);
        public static Action<T1, T2, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, _ gap1, _ gap2, T3 arg3) => (arg1, arg2, arg4) => action(arg1, arg2, arg3, arg4);
        public static Action<T2, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, _ gap2, T3 arg3) => (arg2, arg4) => action(arg1, arg2, arg3, arg4);
        public static Action<T1, T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, _ gap1, T2 arg2, T3 arg3) => (arg1, arg4) => action(arg1, arg2, arg3, arg4);
        public static Action<T4> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3) => (arg4) => action(arg1, arg2, arg3, arg4);
        public static Action<T1, T2, T3> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, _ gap1, _ gap2, _ gap3, T4 arg4) => (arg1, arg2, arg3) => action(arg1, arg2, arg3, arg4);
        public static Action<T2, T3> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, _ gap2, _ gap3, T4 arg4) => (arg2, arg3) => action(arg1, arg2, arg3, arg4);
        public static Action<T1, T3> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, _ gap1, T2 arg2, _ gap3, T4 arg4) => (arg1, arg3) => action(arg1, arg2, arg3, arg4);
        public static Action<T3> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, _ gap3, T4 arg4) => (arg3) => action(arg1, arg2, arg3, arg4);
        public static Action<T1, T2> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, _ gap1, _ gap2, T3 arg3, T4 arg4) => (arg1, arg2) => action(arg1, arg2, arg3, arg4);
        public static Action<T2> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, _ gap2, T3 arg3, T4 arg4) => (arg2) => action(arg1, arg2, arg3, arg4);
        public static Action<T1> Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, _ gap1, T2 arg2, T3 arg3, T4 arg4) => (arg1) => action(arg1, arg2, arg3, arg4);
        public static Action Partial<T1, T2, T3, T4>(this Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => () => action(arg1, arg2, arg3, arg4);
        public static Action<T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1) => (arg2, arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T3, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2) => (arg1, arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T3, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2) => (arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T2, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, _ gap2, T3 arg3) => (arg1, arg2, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, _ gap2, T3 arg3) => (arg2, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2, T3 arg3) => (arg1, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T4, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3) => (arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T2, T3, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, _ gap2, _ gap3, T4 arg4) => (arg1, arg2, arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2, T3, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, _ gap2, _ gap3, T4 arg4) => (arg2, arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T3, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2, _ gap3, T4 arg4) => (arg1, arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T3, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, _ gap3, T4 arg4) => (arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T2, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, _ gap2, T3 arg3, T4 arg4) => (arg1, arg2, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, _ gap2, T3 arg3, T4 arg4) => (arg2, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2, T3 arg3, T4 arg4) => (arg1, arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T5> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => (arg5) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T2, T3, T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg1, arg2, arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2, T3, T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg2, arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T3, T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg1, arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T3, T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T2, T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg2, arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2, T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg2, arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T4> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg4) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T2, T3> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg2, arg3) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2, T3> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg2, arg3) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T3> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg3) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T3> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg3) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1, T2> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg1, arg2) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg2) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T1> Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, _ gap1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => (arg1) => action(arg1, arg2, arg3, arg4, arg5);
        public static Action Partial<T1, T2, T3, T4, T5>(this Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => () => action(arg1, arg2, arg3, arg4, arg5);
        public static Action<T2, T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1) => (arg2, arg3, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2) => (arg1, arg3, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2) => (arg3, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3) => (arg1, arg2, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3) => (arg2, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3) => (arg1, arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3) => (arg4, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T3, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, _ gap3, T4 arg4) => (arg1, arg2, arg3, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T3, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, _ gap3, T4 arg4) => (arg2, arg3, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, _ gap3, T4 arg4) => (arg1, arg3, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, _ gap3, T4 arg4) => (arg3, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3, T4 arg4) => (arg1, arg2, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3, T4 arg4) => (arg2, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3, T4 arg4) => (arg1, arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T5, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4) => (arg5, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T3, T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg1, arg2, arg3, arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T3, T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, _ gap3, _ gap4, T5 arg5) => (arg2, arg3, arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3, T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg1, arg3, arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3, T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, _ gap3, _ gap4, T5 arg5) => (arg3, arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg2, arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3, _ gap4, T5 arg5) => (arg2, arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg1, arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T4, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, _ gap4, T5 arg5) => (arg4, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T3, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg2, arg3, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T3, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, _ gap3, T4 arg4, T5 arg5) => (arg2, arg3, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg1, arg3, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, _ gap3, T4 arg4, T5 arg5) => (arg3, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg1, arg2, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3, T4 arg4, T5 arg5) => (arg2, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => (arg1, arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T6> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5) => (arg6) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg1, arg2, arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg2, arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3, T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg1, arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3, T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, _ gap3, _ gap4, _ gap5, T6 arg6) => (arg3, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg1, arg2, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg2, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg1, arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T4, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, _ gap4, _ gap5, T6 arg6) => (arg4, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T3, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg2, arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T3, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg2, arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, _ gap3, T4 arg4, _ gap5, T6 arg6) => (arg3, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg2, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg2, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg1, arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T5> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, _ gap5, T6 arg6) => (arg5) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T3, T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg2, arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T3, T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg2, arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3, T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3, T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, _ gap3, _ gap4, T5 arg5, T6 arg6) => (arg3, arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg2, arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg2, arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg1, arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T4> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, _ gap4, T5 arg5, T6 arg6) => (arg4) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2, T3> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg1, arg2, arg3) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2, T3> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg2, arg3) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T3> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg1, arg3) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T3> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, _ gap3, T4 arg4, T5 arg5, T6 arg6) => (arg3) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1, T2> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, _ gap2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => (arg1, arg2) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T2> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, _ gap2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => (arg2) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action<T1> Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, _ gap1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => (arg1) => action(arg1, arg2, arg3, arg4, arg5, arg6);
        public static Action Partial<T1, T2, T3, T4, T5, T6>(this Action<T1, T2, T3, T4, T5, T6> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6) => () => action(arg1, arg2, arg3, arg4, arg5, arg6);
    }
}
