using System.Linq;

namespace SCurry.Builders.Models
{
    public sealed class MethodDefinition
    {
        public MethodDefinition(MethodType type, Parameter[] parameters)
        {
            Type = type;

            Parameters = parameters;

            TrimmedParameters = parameters.Reverse()
                                          .SkipWhile(x => !x.IsArgument)
                                          .Reverse()
                                          .ToArray();

            GappedParameters = parameters.Where(x => !x.IsArgument).ToArray();
        }

        public MethodType Type { get; }

        public Parameter[] Parameters { get; }

        public Parameter[] GappedParameters { get; }

        public Parameter[] TrimmedParameters { get; }

        public string Delegate => Type == MethodType.Action ? "Action" : "Func";

        public string SimpleReturnType => Type == MethodType.Action ? "Action" : "Func<TResult>";

        public string Target => Type == MethodType.Action ? "action" : "func";
    }
}
