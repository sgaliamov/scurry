using System;

namespace SCurry
{
    public static class Helpers
    {
        public static Func<T1, T2, TResult> Func<T1, T2, TResult>(Func<T1, T2, TResult> func) => func;
    }
}
