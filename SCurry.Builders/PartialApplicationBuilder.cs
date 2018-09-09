using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders
{
    public sealed class PartialApplicationBuilder : Builder
    {
        public string[] GenerateFuncExtentions(int argsCount)
        {
            if (argsCount == 0)
            {
                return new[]
                {
                    "public static Func<TResult> Partial<TResult>"
                    + "(this Func<TResult> func) => func;"
                };
            }

            return GenerateExtentions("Partial", argsCount, true);
        }

        public string[] GenerateActionExtentions(int argsCount)
        {
            if (argsCount == 0)
            {
                return new[]
                {
                    "public static Action Partial(this Action "
                    + "action) => action;"
                };
            }

            return GenerateExtentions("Partial", argsCount, false);
        }

        protected override ExtensionParameters CreateExtensionParameters(bool hasArg, int number) =>
            new ExtensionParameters
            {
                ReturnType = hasArg ? null : $"T{number}",
                CallAgr = hasArg ? $"T{number} arg{number}" : $"_ gap{number}",
                BodyArg = hasArg ? null : $"arg{number}",
                BodyCallArg = $"arg{number}",
                HasArg = hasArg
            };

        protected override string BuildBodyArguments(IReadOnlyCollection<ExtensionParameters> info)
        {
            if (info.Count == 0)
            {
                return string.Empty;
            }

            var args = info
                .Where(x => x.BodyArg != null)
                .Select(x => x.BodyArg)
                .ToArray();

            return $"({args.Join(", ")}) => ";
        }
    }
}
