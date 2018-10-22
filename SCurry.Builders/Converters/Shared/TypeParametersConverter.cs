using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    public sealed class TypeParametersConverter : IConverter
    {
        public string Convert(MethodDefinition definition)
        {
            var types = definition
                .Parameters
                .Select(x => x.TypeName);

            if (definition.Type == MethodType.Function)
            {
                types = types.Append("TResult");
            }

            return AddBrackets(types.Join(", "));
        }

        private static string AddBrackets(string types) =>
            string.IsNullOrWhiteSpace(types) ? types : $"<{types}>";
    }
}
