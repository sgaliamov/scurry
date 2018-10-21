using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters
{
    public sealed class Builder : IConverter
    {
        private readonly IConverter _body;
        private readonly string _name;
        private readonly TypeParametersConverter _parameters = new TypeParametersConverter();
        private readonly IConverter _result;
        private readonly IConverter _targetArgs;

        public Builder(string name, IConverter result, IConverter body, IConverter targetArgs)
        {
            _targetArgs = targetArgs;
            _result = result;
            _body = body;
            _name = name;
        }

        public string Convert(MethodDefinition markers)
        {
            var result = _result.Convert(markers);
            var types = _parameters.Convert(markers);
            var args = _targetArgs.Convert(markers);
            var body = _body.Convert(markers);

            return $"public static {result} {_name}{types}({args}) => {body}";
        }
    }
}
