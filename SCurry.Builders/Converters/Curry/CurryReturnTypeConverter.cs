using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    public sealed class CurryReturnTypeConverter : IConverter
    {
        public string Convert(MarkerFlags markers)
        {
            var argsCount = markers.Flags.Length;

            if (argsCount == 1 && markers.Type == MarkersType.Action)
            {
                return "Action<T1>";
            }

            var result = markers.Type == MarkersType.Action
                ? $"Action<T{argsCount}>"
                : "TResult";

            return markers.Flags
                .Select(x => $"Func<T{x}, ")
                .Append(result)
                .Concat(Enumerable.Range(0, argsCount).Select(_ => ">"))
                .Join();
        }
    }
}
