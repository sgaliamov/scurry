using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters
{
    public sealed class CurryBodyConverter : IConverter
    {
        public string Convert(MarkerFlags markers)
        {
            new CurryBodyArgsConverter();

            return markers.Flags
                .Where(x => x)
                .Select((i, x) => $"arg{i}")
                .Join(" => ");
        }
    }
}
