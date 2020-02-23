using System;

namespace SCurry
{
    public static class Helpers
    {
        public static Func<T1, T2, TResult> Func<T1, T2, TResult>(Func<T1, T2, TResult> func) => func;

        public static Func<T1, T2, TResult> Part<T1, T2, TResult>(
            this Func<T1, T2, TResult> func,
            PartWrap<T1> arg1,
            PartWrap<T2> arg2) => func;
    }

    public class PartWrap
    {
        public static PartWrap Spacer => new PartWrap();
    }

    public sealed class PartWrap<T> : PartWrap
    {
        private readonly T _value;

        private PartWrap(T value) => _value = value;

        public static explicit operator T(PartWrap<T> p) => p._value;

        public static explicit operator PartWrap<T>(T value) => new PartWrap<T>(value);
    }
}
