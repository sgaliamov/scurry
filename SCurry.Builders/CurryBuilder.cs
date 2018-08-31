using System.Linq;

namespace SCurry.Builders
{
    using static CommonBuilder;

    public static class CurryBuilder
    {
        public static string FuncReturnType(ushort count, string result)
        {
            if (count == 0)
            {
                return $"Func<{result}>";
            }

            return ShortRange(1, count)
                .Select(x => $"Func<T{x}, ")
                .Append(result)
                .Concat(ShortRange(0, count).Select(_ => ">"))
                .AggregateString();
        }

        public static string ActionReturnType(ushort count)
        {
            switch (count)
            {
                case 0:
                    return "Action";

                case 1:
                    return "Action<T1>";

                default:
                    return FuncReturnType((ushort)(count - 1), $"Action<T{count}>");
            }
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

            if (!string.IsNullOrWhiteSpace(types))
            {
                types = $"<{types}>";
            }

            return $"public static {ActionReturnType(count)} Curry{types}"
                   + $"(this Action{types} action) => {Body("action", count)};";
        }

        /// <summary>
        ///     target(arg1, arg2, arg3)
        /// </summary>
        public static string Body(string target, ushort count)
        {
            if (count == 0 || count == 1)
            {
                return target;
            }

            var args = string.Join(", ", ShortRange(1, count).Select(x => $"arg{x}"));
            var bodyCall = $"{target}({args})";

            return string.Join(
                string.Empty,
                ShortRange(1, count)
                    .Select(x => $"arg{x} => ")
                    .Append(bodyCall)
            );
        }
    }
}
