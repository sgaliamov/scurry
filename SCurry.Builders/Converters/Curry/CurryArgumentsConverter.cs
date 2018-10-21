using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    public sealed class CurryArgumentsConverter : IConverter
    {
        private readonly TypeParametersConverter _typeParameters;

        public CurryArgumentsConverter(TypeParametersConverter typeParameters) => _typeParameters = typeParameters;

        public string Convert(MethodDefinition markers)
        {
            var types = _typeParameters.Convert(markers);

            return $"this {markers.Delegate}{types} {markers.Target}";
        }
    }
}
