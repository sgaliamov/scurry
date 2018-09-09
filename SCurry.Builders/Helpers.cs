using System.Collections.Generic;

namespace SCurry.Builders
{
    public static class Helpers
    {
        public static string Join<T>(this IEnumerable<T> enumerable, string separator = null) =>
            string.Join(separator, enumerable);
    }
}
