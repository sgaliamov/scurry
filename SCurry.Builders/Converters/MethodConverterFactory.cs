using SCurry.Builders.Converters.Curry;
using SCurry.Builders.Converters.Shared;

namespace SCurry.Builders.Converters
{
    public static class MethodConverterFactory
    {
        public static MethodConverter CurryMethodConverter => new MethodConverter(
            new ReturnTypeConverter(),
            new NameConverter("Curry", TypeParametersConverterInstance),
            new ArgumentsConverter(TypeParametersConverterInstance),
            new BodyConverter(BodyCallConverterInstance));

        public static MethodConverter PartialApplicationMethodConverter => new MethodConverter(
            new PartialApplication.ReturnTypeConverter(),
            new NameConverter("Partial", TypeParametersConverterInstance),
            new PartialApplication.ArgumentsConverter(TypeParametersConverterInstance),
            new PartialApplication.BodyConverter(BodyCallConverterInstance));

        private static readonly TypeParametersConverter TypeParametersConverterInstance
            = new TypeParametersConverter();

        private static readonly BodyCallConverter BodyCallConverterInstance
            = new BodyCallConverter();
    }
}
