using SCurry.Builders.Converters;
using SCurry.Builders.Models;

namespace SCurry.Builders
{
    public sealed class PartialApplicationBuilder : DefaultBuilder
    {
        public PartialApplicationBuilder() : base(
            MethodConverterFactory.PartialApplicationMethodConverter,
            new MethodDefinitionsBuilder()) { }
    }
}
