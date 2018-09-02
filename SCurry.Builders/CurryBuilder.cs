using System.Linq;

namespace SCurry.Builders
{
    using static CommonBuilder;

    public static class CurryBuilder
    {
        public static string FuncReturnType(int count, string result)
        {
            if (count == 0)
            {
                return $"Func<{result}>";
            }

            return Enumerable.Range(1, count)
                .Select(x => $"Func<T{x}, ")
                .Append(result)
                .Concat(Enumerable.Range(0, count).Select(_ => ">"))
                .Join();
        }

        public static string ActionReturnType(int count)
        {
            switch (count)
            {
                case 0:
                    return "Action";

                case 1:
                    return "Action<T1>";

                default:
                    return FuncReturnType(count - 1, $"Action<T{count}>");
            }
        }

        public static string GenerateFuncExtention(int count)
        {
            var types = TypeParameters(count, true);

            return $"public static {FuncReturnType(count, "TResult")} Curry<{types}>"
                   + $"(this Func<{types}> func) => {Body("func", count)};";
        }

        public static string GenerateActionExtention(int count)
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
        public static string Body(string target, int count)
        {
            if (count == 0 || count == 1)
            {
                return target;
            }

            var args = string.Join(", ", Enumerable.Range(1, count).Select(x => $"arg{x}"));
            var bodyCall = $"{target}({args})";

            return string.Join(
                string.Empty,
                Enumerable.Range(1, count)
                    .Select(x => $"arg{x} => ")
                    .Append(bodyCall)
            );
        }
    }
}
