using System.Diagnostics;

namespace SCurry.Builders.Models
{
    [DebuggerDisplay("{" + nameof(IsArgument) + "}")]
    public sealed class Parameter
    {
        private readonly int _number;

        public Parameter(bool isArgument, int number)
            : this(isArgument, $"T{number}", $"arg{number}", number) { }

        private Parameter(bool isArgument, string typeName, string argumentName, int number)
        {
            IsArgument = isArgument;
            TypeName = typeName;
            ArgumentName = argumentName;
            _number = number;
        }

        public string ArgumentName { get; }
        public bool IsArgument { get; }
        public string TypeName { get; }
        public string CallArgument => IsArgument ? $"{TypeName} {ArgumentName}" : $"_ gap{_number}";
    }
}
