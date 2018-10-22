using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.PartialApplication
{
    public sealed class ReturnTypeConverter : IConverter
    {
        public string Convert(MethodDefinition definition)
        {
            var types = definition
                .Parameters
                .Where(x => !x.IsArgument)
                .Select(x => x.TypeName);

            if (definition.Type == MethodType.Function)
            {
                types = types.Append("TResult");
            }

            return $"{definition.Delegate}{AddBrackets(types.Join(", "))}";
        }

        private static string AddBrackets(string types) =>
            string.IsNullOrWhiteSpace(types) ? types : $"<{types}>";
    }
}
