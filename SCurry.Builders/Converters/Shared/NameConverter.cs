using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    public sealed class NameConverter : IConverter
    {
        private readonly string _name;
        private readonly TypeParametersConverter _types;

        public NameConverter(string name, TypeParametersConverter types)
        {
            _name = name;
            _types = types;
        }

        public string Convert(MethodDefinition definition)
        {
            var types = _types.Convert(definition);

            return $"{_name}{types}";
        }

       
    }
}
