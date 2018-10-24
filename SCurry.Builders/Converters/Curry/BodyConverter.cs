using System.Linq;
using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    internal sealed class BodyConverter : IConverter
    {
        private readonly BodyCallConverter _callConverter;

        public BodyConverter(BodyCallConverter callConverter) => _callConverter = callConverter;

        public string Convert(MethodDefinition definition)
        {
            var onlyOneNormalParamter = definition.Parameters.Length == 1 && definition.TrimmedParameters.Length == 0;

            if (definition.Parameters.Length == 0 || onlyOneNormalParamter)
            {
                return definition.Target;
            }

            var call = _callConverter.Convert(definition);

            var chain = definition.GappedParameters
                                  .Select(x => x.ArgumentName)
                                  .Join(" => ")
                                  .IfEmpty("()");

            return $"{chain} => {call}";
        }
    }
}
