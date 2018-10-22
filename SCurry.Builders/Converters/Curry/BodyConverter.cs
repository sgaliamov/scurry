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
            var call = _callConverter.Convert(definition);

            var chain = definition.Parameters
                .Where(x => x.HasArgument)
                .Select(x => x.ArgumentName)
                .Join(" => ");

            return $"{chain} => {call}";
        }
    }
}
