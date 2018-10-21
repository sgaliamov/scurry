using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    internal sealed class CurryBodyArgsConverter : IConverter
    {
        public string Convert(MethodDefinition markers) => markers.Parameters
            .Where(x => x.HasArgument)
            .Select(x => x.ArgumentName)
            .Join();
    }
}
