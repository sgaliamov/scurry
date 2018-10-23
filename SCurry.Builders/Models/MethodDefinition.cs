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
        }

        public MethodType Type { get; }

        public Parameter[] Parameters { get; }

        public Parameter[] TrimmedParameters { get; }

        public string Delegate => Type == MethodType.Action ? "Action" : "Func";

        public string Target => Type == MethodType.Action ? "action" : "func";
    }
}
