using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    internal sealed class AllArgumentsConverter : IConverter
    {
        public string Convert(MethodDefinition definition) => definition
            .TrimmedParameters
            .Select(x => x.ArgumentName)
            .Join(", ");
    }
}
