using System.Diagnostics;

namespace SCurry.Builders.Models
{
    [DebuggerDisplay("{" + nameof(HasArgument) + "}")]
    public sealed class Parameter
    {
        public Parameter(bool hasArgument, int number)
            : this(hasArgument, $"T{number}", $"arg{number}", $"gap{number}") { }

        private Parameter(bool hasArgument, string typeName, string argumentName, string gapName)
        {
            HasArgument = hasArgument;
            TypeName = typeName;
            ArgumentName = argumentName;
            GapName = gapName;
        }

        public string ArgumentName { get; }
        public string GapName { get; }
        public bool HasArgument { get; }
        public string TypeName { get; }
    }
}
