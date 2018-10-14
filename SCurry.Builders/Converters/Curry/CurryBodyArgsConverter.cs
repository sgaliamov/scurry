using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters
{
    internal sealed class CurryBodyArgsConverter : IConverter
    {
        public string Convert(MarkerFlags markers) => markers.Flags
            .Where(x => x)
            .Select((i, x) => $"arg{i} => ")
            .Join();
    }
}
