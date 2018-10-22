namespace SCurry.Builders.Models
{
    public sealed class MethodDefinition
    {
        public MethodDefinition(MethodType type, Parameter[] parameters)
        {
            Parameters = parameters;
            Type = type;
        }

        public Parameter[] Parameters { get; }

        public MethodType Type { get; }

        public string Delegate => Type == MethodType.Action ? "Action" : "Func";

        public string Target => Type == MethodType.Action ? "action" : "func";
    }
}
