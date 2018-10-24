using System.Linq;
using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.PartialApplication
{
    internal sealed class BodyConverter : IConverter
    {
        private readonly BodyCallConverter _callConverter;

        public BodyConverter(BodyCallConverter callConverter) => _callConverter = callConverter;

        public string Convert(MethodDefinition definition)
        {
            if (definition.Parameters.Length == 0 || definition.TrimmedParameters.Length == 0)
            {
                return definition.Target;
            }

            var call = _callConverter.Convert(definition);

            var chain = definition.GappedParameters
                                  .Select(x => x.ArgumentName)
                                  .Join(", ");

            return $"({chain}) => {call}";
        }
    }
}
