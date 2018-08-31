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
        public static string TypeParameters(ushort count, bool appendResult)
        {
            var types = ShortRange(1, count).Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}");

            if (appendResult)
            {
                types = types.Append("TResult");
            }

            return types.Join(", ");
        }

        public static IEnumerable<ushort> ShortRange(ushort start, ushort count)
        {
            for (var i = start; i < count + start; i++)
            {
                yield return i;
            }
        }

        public static string Join<T>(this IEnumerable<T> enumerable, string separator = null) =>
            string.Join(separator, enumerable);
    }
}
