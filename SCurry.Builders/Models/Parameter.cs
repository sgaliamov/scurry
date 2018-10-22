using System.Diagnostics;

namespace SCurry.Builders.Models
{
    [DebuggerDisplay("{" + nameof(IsArgument) + "}")]
    public sealed class Parameter
    {
        public Parameter(bool isArgument, int number)
            : this(isArgument, $"T{number}", $"arg{number}") { }

        private Parameter(bool isArgument, string typeName, string argumentName)
        {
            IsArgument = isArgument;
            TypeName = typeName;
            ArgumentName = argumentName;
        }

        public string ArgumentName { get; }
        public bool IsArgument { get; }
        public string TypeName { get; }
        public string CallArgument => IsArgument ? $"{TypeName} {ArgumentName}" : $"_ {ArgumentName}gap";
    }
}
