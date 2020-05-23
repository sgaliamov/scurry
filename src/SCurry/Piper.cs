using System;

namespace SCurry
{
    public static class Piper
    {
        public static Func<T, T> Pipe<T>(params Func<T, T>[] functions) => value =>
        {
            for (var i = 0; i < functions.Length; i++)
            {
                value = functions[i](value);
            }

            return value;
        };
    }
}
