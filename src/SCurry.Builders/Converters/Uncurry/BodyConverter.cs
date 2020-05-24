using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Uncurry
{
    internal sealed class BodyConverter : IConverter
    {
        public string Convert(MethodDefinition definition)
        {
            if (definition.GappedParameters.Length <= 1) {
                return "curry";
            }

            var chain = definition.GappedParameters
                                  .Select(x => $"{x.TypeName} {x.ArgumentName}")
                                  .Join(", ");

            var calls = definition.GappedParameters
                                  .Select(x => $"({x.ArgumentName})")
                                  .Join();

            return $"({chain}) => curry{calls}";
        }
    }
}
