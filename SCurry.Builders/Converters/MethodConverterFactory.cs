using SCurry.Builders.Converters.Curry;
using SCurry.Builders.Converters.Shared;
using ArgumentsConverter = SCurry.Builders.Converters.Uncurry.ArgumentsConverter;
using ReturnTypeConverter = SCurry.Builders.Converters.PartialApplication.ReturnTypeConverter;

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
            CurryReturnTypeConverter = new Curry.ReturnTypeConverter();
        }

        public static MethodConverter CurryMethodConverter => new MethodConverter(
            CurryReturnTypeConverter,
            new NameConverter("Curry", TypeParametersConverterInstance),
            ArgumentsConverter,
            new BodyConverter(BodyCallConverterInstance));

        public static MethodConverter PartialApplicationMethodConverter => new MethodConverter(
            new ReturnTypeConverter(),
            new NameConverter("Partial", TypeParametersConverterInstance),
            ArgumentsConverter,
            new PartialApplication.BodyConverter(BodyCallConverterInstance));

        public static MethodConverter UncurryMethodConverter => new MethodConverter(
            DelegateWithTypesConverter,
            new NameConverter("Uncurry", TypeParametersConverterInstance),
            new ArgumentsConverter(CurryReturnTypeConverter),
            new Uncurry.BodyConverter(BodyCallConverterInstance));

        private static readonly TypeParametersConverter TypeParametersConverterInstance;
        private static readonly BodyCallConverter BodyCallConverterInstance;
        private static readonly Shared.ArgumentsConverter ArgumentsConverter;
        private static readonly DelegateWithTypesConverter DelegateWithTypesConverter;
        private static readonly Curry.ReturnTypeConverter CurryReturnTypeConverter;
    }
}
