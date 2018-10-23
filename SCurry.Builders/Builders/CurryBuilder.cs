using SCurry.Builders.Converters;
using SCurry.Builders.Converters.Curry;
using SCurry.Builders.Converters.Shared;

namespace SCurry.Builders.Builders
{
    public sealed class CurryBuilder : DefaultBuilder
    {
        public CurryBuilder()
            : base(new MethodConverter(
                new ReturnTypeConverter(),
                new NameConverter("Curry", TypeParametersConverter.Instance),
                new ArgumentsConverter(TypeParametersConverter.Instance),
                new BodyConverter(new BodyCallConverter()))) { }
    }
}
