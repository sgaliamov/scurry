using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SCurry.Builders
{
    public static class CurryBuilder
    {
        public static string FuncReturnType(ushort count, string result)
        {
            if (count == 0) return "Func<TResult>";

            return ShortRange(1, count)
                .Select(x => $"Func<T{x}, ")
                .Append(result)
                .Concat(ShortRange(0, count).Select(_ => ">"))
                .Aggregate(new StringBuilder(), Append)
                .ToString();
        }

        public static string ActionReturnType(ushort count)
        {
            if (count == 0) return "Action";

            if (count == 1) return "Action<T1>";

            return FuncReturnType((ushort)(count - 1), $"Action<T{count}>");
        }

        public static string GenerateFuncExtention(ushort count)
        {
            var types = TypeParameters(true, count);

            return $"public static {FuncReturnType(count, "TResult")} Curry<{types}>"
                   + $"(this Func<{types}> func) => {Body("func", count)};";
        }

        public static string GenerateActionExtention(ushort count)
        {
            var types = TypeParameters(false, count);
            if (!string.IsNullOrWhiteSpace(types)) types = $"<{types}>";

            return $"public static {ActionReturnType(count)} Curry{types}"
                   + $"(this Action{types} action) => {Body("action", count)};";
        }

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

        public static string TypeParameters(bool appendResult, ushort count)
        {
            var types = ShortRange(1, count)
                .Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}");

            if (appendResult) types = types.Append("TResult");

            return string.Join(", ", types);
        }

        private static IEnumerable<ushort> ShortRange(ushort start, ushort count)
        {
            for (var i = start; i < count + start; i++) yield return i;
        }

        private static StringBuilder Append(StringBuilder sb, string value) => sb.Append(value);
    }
}