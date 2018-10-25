using SCurry.Builders.Converters.Curry;
using SCurry.Builders.Converters.Shared;
using ArgumentsConverter = SCurry.Builders.Converters.Uncurry.ArgumentsConverter;

namespace SCurry.Builders.Converters
{
    public static class MethodConverterFactory
    {
        static MethodConverterFactory()
        {
            TypeParametersConverterInstance = new TypeParametersConverter();
            BodyCallConverterInstance = new BodyCallConverter();
            DelegateWithTypesConverter = new DelegateWithTypesConverter(TypeParametersConverterInstance);
            ArgumentsConverter = new Shared.ArgumentsConverter(DelegateWithTypesConverter);
        }

        public static MethodConverter CurryMethodConverter => new MethodConverter(
            new ReturnTypeConverter(),
            new NameConverter("Curry", TypeParametersConverterInstance),
            ArgumentsConverter,
            new BodyConverter(BodyCallConverterInstance));

        public static MethodConverter PartialApplicationMethodConverter => new MethodConverter(
            new PartialApplication.ReturnTypeConverter(),
            new NameConverter("Partial", TypeParametersConverterInstance),
            ArgumentsConverter,
            new PartialApplication.BodyConverter(BodyCallConverterInstance));

        public static MethodConverter UncurryMethodConverter => new MethodConverter(
            DelegateWithTypesConverter,
            new NameConverter("Uncurry", TypeParametersConverterInstance),
            new ArgumentsConverter(TypeParametersConverterInstance),
            new Uncurry.BodyConverter(BodyCallConverterInstance));

        private static readonly TypeParametersConverter TypeParametersConverterInstance;
        private static readonly BodyCallConverter BodyCallConverterInstance;
        private static readonly Shared.ArgumentsConverter ArgumentsConverter;
        private static readonly DelegateWithTypesConverter DelegateWithTypesConverter;
    }
}
