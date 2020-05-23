using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    internal sealed class ArgumentsConverter : IConverter
    {
        private readonly DelegateWithTypesConverter _delegateWithTypes;

        public ArgumentsConverter(DelegateWithTypesConverter delegateWithTypesConverter) => _delegateWithTypes = delegateWithTypesConverter;

        public string Convert(MethodDefinition definition)
        {
            var type = _delegateWithTypes.Convert(definition);

            var args = definition
                       .TrimmedParameters
                       .Select(x => x.CallArgument)
                       .Join(", ")
                       .MapIfExists(x => ", " + x);

            return $"this {type} {definition.Target}{args}";
        }
    }
}
