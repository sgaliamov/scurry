using System.Linq;

namespace SCurry.Builders
{
    using static CommonBuilder;

    public static class CurryBuilder
    {
        public static string FuncReturnType(int argsCount, string result)
        {
            if (argsCount == 0)
            {
                return $"Func<{result}>";
            }

            return Enumerable.Range(1, argsCount)
                .Select(x => $"Func<T{x}, ")
                .Append(result)
                .Concat(Enumerable.Range(0, argsCount).Select(_ => ">"))
                .Join();
        }

        public static string ActionReturnType(int argsCount)
        {
            switch (argsCount)
            {
                case 0:
                    return "Action";

                case 1:
                    return "Action<T1>";

                default:
                    return FuncReturnType(argsCount - 1, $"Action<T{argsCount}>");
            }
        }

        public static string GenerateFuncExtention(int argsCount)
        {
            var types = TypeParameters(argsCount, true);

            return $"public static {FuncReturnType(argsCount, "TResult")} Curry<{types}>"
                   + $"(this Func<{types}> func) => {Body("func", argsCount)};";
        }

        public static string GenerateActionExtention(int argsCount)
        {
            var types = TypeParameters(argsCount, false);

            if (!string.IsNullOrWhiteSpace(types))
            {
                types = $"<{types}>";
            }

            return $"public static {ActionReturnType(argsCount)} Curry{types}"
                   + $"(this Action{types} action) => {Body("action", argsCount)};";
        }

        /// <summary>
        ///     target(arg1, arg2, arg3)
        /// </summary>
        public static string Body(string target, int argsCount)
        {
            if (argsCount == 0 || argsCount == 1)
            {
                return target;
            }

            var args = string.Join(", ", Enumerable.Range(1, argsCount).Select(x => $"arg{x}"));
            var bodyCall = $"{target}({args})";

            return string.Join(
                string.Empty,
                Enumerable.Range(1, argsCount)
                    .Select(x => $"arg{x} => ")
                    .Append(bodyCall)
            );
        }
    }
}
