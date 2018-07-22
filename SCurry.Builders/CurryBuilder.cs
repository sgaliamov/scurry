using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SCurry.Builders
{
    public static class CurryBuilder
    {
        public const ushort MaxInputArgumentsCount = 16;

        public static string ReturnType(ushort count)
        {
            if (count == 0) return "Func<TResult>";

            return ShortRange(1, count)
                .Select(x => $"Func<T{x}, ")
                .Append("TResult")
                .Concat(ShortRange(0, count).Select(_ => ">"))
                .Aggregate(new StringBuilder(), Append)
                .ToString();
        }

        public static string GenerateFuncExtention(ushort count)
        {
            var types = TypeParameters(count);

            return $"public static {ReturnType(count)} Curry<{types}>"
                   + $"(this Func<{types}> func) => {Body(count)};";
        }

        public static string Body(ushort count)
        {
            if (count == 0 || count == 1) return "func";

            var args = string.Join(", ", ShortRange(1, count).Select(x => $"arg{x}"));

            return string.Join(
                string.Empty,
                ShortRange(1, count)
                    .Select(x => $"arg{x} => ")
                    .Append("func(")
                    .Append(args)
                    .Append(")")
            );
        }

        public static string TypeParameters(ushort count) =>
            string.Join(
                ", ",
                ShortRange(1, count)
                    .Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}")
                    .Append("TResult")
            );

        public static IEnumerable<ushort> ShortRange(ushort start, ushort count)
        {
            for (var i = start; i < count + start; i++) yield return i;
        }

        private static StringBuilder Append(StringBuilder sb, string value) => sb.Append(value);
    }
}