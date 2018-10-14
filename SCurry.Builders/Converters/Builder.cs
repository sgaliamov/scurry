using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters
{
    public sealed class Builder : IConverter
    {
        private readonly string _name;
        private readonly TypeParametersConverter _parameters = new TypeParametersConverter();
        private readonly IConverter _body;
        private readonly IConverter _result;

        public Builder(string name, IConverter result, IConverter body)
        {
            _result = result;
            _body = body;
            _name = name;
        }

        public string Convert(MarkerFlags markers)
        {
            var types = _parameters.Convert(markers);
            var result = _result.Convert(markers);
            var body = _body.Convert(markers);

            return $"public static {result} {_name}<{types}>"
                   + $"(this {markers.Delegate}<{types}> {markers.Target}) => {body}";
        }
    }
}
