using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    internal sealed class CurryBodyCallConverter : IConverter
    {
        public string Convert(MethodDefinition markers)
        {
            var args = markers.Parameters.Select((i, x) => $"arg{i}").Join(", ");

            return $"{markers.Target}({args});";
        }
    }
}
