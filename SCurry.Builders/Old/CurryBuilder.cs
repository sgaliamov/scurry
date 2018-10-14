using System;
using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders
{
    public sealed class CurryBuilder : Builder
    {
        public string FuncReturnType(int argsCount, string result)
        {
            return Enumerable.Range(1, argsCount)
                .Select(x => $"Func<T{x}, ")
                .Append(result)
                .Concat(Enumerable.Range(0, argsCount).Select(_ => ">"))
                .Join();
        }

        public string ActionReturnType(int argsCount)
        {
            switch (argsCount)
            {
                case 1:
                    return "Action<T1>";

                default:
                    return FuncReturnType(argsCount - 1, $"Action<T{argsCount}>");
            }
        }

        public string GenerateFuncExtention(int argsCount)
        {
            var types = TypeParameters(argsCount, true);

            return $"public static {FuncReturnType(argsCount, "TResult")} Curry<{types}>"
                   + $"(this Func<{types}> func) => {Body("func", argsCount)};";
        }

        public string GenerateActionExtention(int argsCount)
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
        public string Body(string target, int argsCount)
        {
            if (argsCount == 1)
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

        protected override ExtensionParameters CreateExtensionParameters(bool hasArg, int number) => new ExtensionParameters
        {
            HasArg = hasArg,
            ReturnType = hasArg ? $"Func<T{number}" : null
        };

        protected override string BuildBodyArguments(IReadOnlyCollection<ExtensionParameters> info) =>
            throw new NotImplementedException();
    }
}
