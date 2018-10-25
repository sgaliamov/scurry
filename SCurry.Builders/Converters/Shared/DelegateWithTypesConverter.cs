using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    internal sealed class DelegateWithTypesConverter : IConverter
    {
        private readonly TypeParametersConverter _typesConverter;

        public DelegateWithTypesConverter(TypeParametersConverter typesConverter) => _typesConverter = typesConverter;

        public string Convert(MethodDefinition definition) =>
            _typesConverter
                .Convert(definition)
                .Map(types => $"{definition.Delegate}{types}");
    }
}
