using SCurry.Builders.Converters;

namespace SCurry.Builders.Builders
{
    public sealed class PartialApplicationBuilder : DefaultBuilder
    {
        public PartialApplicationBuilder() : base(MethodConverterFactory.PartialApplicationMethodConverter) { }
    }
}
