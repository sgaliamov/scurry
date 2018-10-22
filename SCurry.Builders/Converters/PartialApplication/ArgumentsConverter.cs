using System.Linq;
using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.PartialApplication
{
    internal sealed class ArgumentsConverter : IConverter
    {
        private readonly TypeParametersConverter _typeParameters;

        public ArgumentsConverter(TypeParametersConverter typeParameters) => _typeParameters = typeParameters;

        public string Convert(MethodDefinition definition)
        {
            var types = _typeParameters.Convert(definition);

            var args = definition
                .Parameters
                .Select(x => x.CallArgument)
                .Join(", ");

            return $"this {definition.Delegate}{types} {definition.Target}, {args}";
        }
    }
}
