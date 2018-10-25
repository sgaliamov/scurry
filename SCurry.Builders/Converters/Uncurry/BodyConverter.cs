using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;

namespace SCurry.Builders.Converters.Uncurry
{
    internal sealed class BodyConverter : IConverter
    {
        private readonly BodyCallConverter _callConverter;

        public BodyConverter(BodyCallConverter callConverter) => _callConverter = callConverter;

        public string Convert(MethodDefinition definition) => null;
    }
}
