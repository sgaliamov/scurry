using System;
using System.Collections.Generic;

namespace SCurry.Builders.Old
{
    public sealed class UncurryBuilder : Builder
    {
        public string[] GenerateFuncExtentions(int argsCount)
        {
            if (argsCount == 0)
            {
                return new[]
                {
                    "public static Func<TResult> Uncurry<TResult>"
                    + "(this Func<TResult> func) => func;"
                };
            }

            return GenerateExtentions("Uncurry", argsCount, true);
        }

        public string[] GenerateActionExtentions(int argsCount)
        {
            if (argsCount == 0)
            {
                return new[]
                {
                    "public static Action Uncurry(this Action "
                    + "action) => action;"
                };
            }

            return GenerateExtentions("Uncurry", argsCount, false);
        }

        protected override ExtensionParameters CreateExtensionParameters(bool hasArg, int number) =>
            throw new NotImplementedException();

        protected override string BuildBodyArguments(IReadOnlyCollection<ExtensionParameters> info) =>
            throw new NotImplementedException();
    }
}
