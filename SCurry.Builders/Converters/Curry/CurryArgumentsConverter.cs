using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    public sealed class CurryArgumentsConverter : IConverter
    {
        private readonly TypeParametersConverter _typeParameters;

        public CurryArgumentsConverter(TypeParametersConverter typeParameters) => _typeParameters = typeParameters;

        public string Convert(MarkerFlags markers)
        {
            var types = _typeParameters.Convert(markers);

            return $"{markers.Delegate}{types} {markers.Target}";
        }
    }
}
