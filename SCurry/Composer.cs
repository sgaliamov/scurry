using System;

namespace SCurry
{
    public static class Composer
    {
        public static Func<T, T> Compose<T>(params Func<T, T>[] functions) => value =>
        {
            for (var i = functions.Length - 1; i >= 0; i--)
            {
                value = functions[i](value);
            }

            return value;
        };
    }
}
