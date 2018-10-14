using System.Globalization;
using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters
{
    public sealed class TypeParametersConverter : IConverter
    {
        public string Convert(MarkerFlags markers)
        {
            var types = markers.Flags
                .Where(x => x)
                .Select(x => $"T{x.ToString(CultureInfo.InvariantCulture)}");

            if (markers.Type == MarkersType.Function)
            {
                types = types.Append("TResult");
            }

            var result = types.Join(", ");

            return string.IsNullOrWhiteSpace(result) ? "" : $"<{result}>";
        }
    }
}
