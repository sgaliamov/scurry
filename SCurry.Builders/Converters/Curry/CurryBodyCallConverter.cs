using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters
{
    internal sealed class CurryBodyCallConverter : IConverter
    {
        public string Convert(MarkerFlags markers)
        {
            var args = markers.Flags.Select((i, x) => $"arg{i}").Join(", ");

            return $"{markers.Target}({args});";
        }
    }
}
