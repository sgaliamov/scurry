using SCurry.Builders.Converters;
using SCurry.Builders.Models;

namespace SCurry.Builders.Builders
{
    public sealed class CurryBuilder : DefaultBuilder
    {
        public CurryBuilder() : base(
            MethodConverterFactory.CurryMethodConverter,
            new MethodDefinitionsBuilder()) { }
    }
}
