using System.Linq;
using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Uncurry
{
    internal sealed class ArgumentsConverter : IConverter
    {
        private readonly TypeParametersConverter _typeParameters;

        public ArgumentsConverter(TypeParametersConverter typeParameters) => _typeParameters = typeParameters;

        public string Convert(MethodDefinition definition)
        {
            return null;
        }
    }
}
