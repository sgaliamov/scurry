using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SCurry.Builders
{
    public static class CommonBuilder
    {
        /// <summary>
        ///     func(arg1, arg2, arg3)
        /// </summary>
        public static string Body(string target, ushort count)
        {
            if (count == 0 || count == 1) return target;

            var args = string.Join(", ", ShortRange(1, count).Select(x => $"arg{x}"));

            return string.Join(
                string.Empty,
                ShortRange(1, count)
                    .Select(x => $"arg{x} => ")
                    .Append($"{target}(")
                    .Append(args)
                    .Append(")")
            );
        }

        /// <summary>
        ///     T1, T2, T3, TResult
        /// </summary>
        public static string TypeParameters(ushort count, bool appendResult)
        {
            var types = ShortRange(1, count)
                .Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}");

            if (appendResult) types = types.Append("TResult");

            return string.Join(", ", types);
        }

        public static IEnumerable<ushort> ShortRange(ushort start, ushort count)
        {
            for (var i = start; i < count + start; i++) yield return i;
        }

        public static StringBuilder Append(StringBuilder sb, string value) => sb.Append(value);
    }
}
