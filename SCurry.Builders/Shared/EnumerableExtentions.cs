using System;
using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders.Shared
{
    public static class EnumerableExtentions
    {
        public static string Join<T>(this IEnumerable<T> enumerable, string separator = null) =>
            string.Join(separator, enumerable);

        public static T Map<T>(this T str, Func<T, T> map) => map(str);

        public static IEnumerable<T> AppendIf<T>(this IEnumerable<T> enumerable, Func<bool> predicate, T value)
        {
            if (predicate())
            {
                return enumerable.Append(value);
            }

            return enumerable;
        }
    }
}
