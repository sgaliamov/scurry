﻿using System.Linq;
using System.Text;

namespace SCurry.Builders
{
    using static CommonBuilder;

    public static class CurryBuilder
    {
        public static string FuncReturnType(ushort count, string result)
        {
            if (count == 0) return $"Func<{result}>";

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
            var types = TypeParameters(count, true);

            return $"public static {FuncReturnType(count, "TResult")} Curry<{types}>"
                   + $"(this Func<{types}> func) => {Body("func", count)};";
        }

        public static string GenerateActionExtention(ushort count)
        {
            var types = TypeParameters(count, false);
            if (!string.IsNullOrWhiteSpace(types)) types = $"<{types}>";

            return $"public static {ActionReturnType(count)} Curry{types}"
                   + $"(this Action{types} action) => {Body("action", count)};";
        }
    }
}
