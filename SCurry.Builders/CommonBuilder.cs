using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SCurry.Builders
{
    public static class CommonBuilder
    {
        /// <summary>
        ///     T1, T2, T3, TResult
        /// </summary>
        public static string TypeParameters(int count, bool isFunc)
        {
            var types = Enumerable.Range(1, count).Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}");

            if (isFunc)
            {
                types = types.Append("TResult");
            }

            return types.Join(", ");
        }

        public static string Join<T>(this IEnumerable<T> enumerable, string separator = null) =>
            string.Join(separator, enumerable);
    }
}
