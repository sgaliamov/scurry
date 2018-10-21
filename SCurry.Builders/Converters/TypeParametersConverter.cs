using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters
{
    public sealed class TypeParametersConverter : IConverter
    {
        public string Convert(MethodDefinition markers)
        {
            var types = markers.Parameters
                .Where(x => x.HasArgument)
                .Select(x => x.TypeName);

            if (markers.Type == MethodType.Function)
            {
                types = types.Append("TResult");
            }

            var result = types.Join(", ");

            return string.IsNullOrWhiteSpace(result) ? "" : $"<{result}>";
        }
    }
}
