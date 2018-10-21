using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    public sealed class CurryBodyConverter : IConverter
    {
        public string Convert(MethodDefinition markers)
        {
            new CurryBodyArgsConverter();

            return markers.Parameters
                .Where(x => x.HasArgument)
                .Select(x => x.ArgumentName)
                .Join(" => ");
        }
    }
}
