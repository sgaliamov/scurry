using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

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

            return string.Join(", ", types);
        }

        public static IEnumerable<ushort> ShortRange(ushort start, ushort count)
        {
            for (var i = start; i < count + start; i++)
            {
                yield return i;
            }
        }

        public static string AggregateString<T>(this IEnumerable<T> enumerable) =>
            enumerable.Aggregate(new StringBuilder(), Append).ToString();

        private static StringBuilder Append<T>(StringBuilder sb, T value) => sb.Append(value);
    }
}
