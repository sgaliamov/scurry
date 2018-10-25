using SCurry.Builders.Converters.Curry;
using SCurry.Builders.Models;

namespace SCurry.Builders.Converters.Uncurry
{
    internal sealed class ArgumentsConverter : IConverter
    {
        private readonly ReturnTypeConverter _returnTypeConverter;

        public ArgumentsConverter(ReturnTypeConverter returnTypeConverter) =>
            _returnTypeConverter = returnTypeConverter;

        public string Convert(MethodDefinition definition)
        {
            var type = _returnTypeConverter.Convert(definition);

            return $"this {type} curry";
        }
    }
}
