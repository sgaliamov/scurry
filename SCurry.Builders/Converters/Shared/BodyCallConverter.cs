using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    internal sealed class BodyCallConverter : IConverter
    {
        private readonly AllArgumentsConverter _argumentsConverter;

        public BodyCallConverter(AllArgumentsConverter argumentsConverter) 
            => _argumentsConverter = argumentsConverter;

        public string Convert(MethodDefinition definition)
        {
            var args = _argumentsConverter.Convert(definition);

            return $"{definition.Target}({args});";
        }
    }
}
