using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    internal sealed class BodyCallConverter : IConverter
    {
        public string Convert(MethodDefinition definition)
        {
            var args = definition
                .Parameters
                .Select(x => x.ArgumentName)
                .Join(", ");

            return $"{definition.Target}({args})";
        }
    }
}
