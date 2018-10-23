using SCurry.Builders.Converters;
using SCurry.Builders.Converters.PartialApplication;
using SCurry.Builders.Converters.Shared;

namespace SCurry.Builders.Builders
{
    public sealed class PartialApplicationBuilder : DefaultBuilder
    {
        public PartialApplicationBuilder()
            : base(new MethodConverter(
                new ReturnTypeConverter(),
                new NameConverter("Partial", TypeParametersConverter.Instance),
                new ArgumentsConverter(TypeParametersConverter.Instance),
                new BodyConverter(new BodyCallConverter()))) { }
    }
}
