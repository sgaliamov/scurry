using SCurry.Builders.Converters;

namespace SCurry.Builders.Builders
{
    public sealed class CurryBuilder : DefaultBuilder
    {
        public CurryBuilder() : base(MethodConverterFactory.CurryMethodConverter) { }
    }
}
