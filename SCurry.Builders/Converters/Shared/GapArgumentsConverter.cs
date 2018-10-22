using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    internal sealed class GapArgumentsConverter : IConverter
    {
        public string Convert(MethodDefinition definition) => definition
            .Parameters
            .Where(x => !x.HasArgument)
            .Select(x => x.ArgumentName)
            .Join(", ");
    }
}
