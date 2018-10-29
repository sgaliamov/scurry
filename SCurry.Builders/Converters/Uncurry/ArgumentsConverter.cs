using SCurry.Builders.Converters.Curry;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Uncurry
{
    internal sealed class ArgumentsConverter : IConverter
    {
        private readonly ReturnTypeConverter _returnTypeConverter;

        public ArgumentsConverter(ReturnTypeConverter returnTypeConverter) =>
            _returnTypeConverter = returnTypeConverter;

        public string Convert(MethodDefinition definition) =>
            _returnTypeConverter.Convert(definition)
                                .Map(type => $"this {type} curry");
    }
}
