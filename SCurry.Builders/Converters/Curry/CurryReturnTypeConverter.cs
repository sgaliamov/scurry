using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    public sealed class CurryReturnTypeConverter : IConverter
    {
        public string Convert(MethodDefinition markers)
        {
            var argsCount = markers.Parameters.Length;

            if (argsCount == 1 && markers.Type == MethodType.Action)
            {
                return "Action<T1>";
            }

            var result = markers.Type == MethodType.Action
                ? $"Action<T{argsCount}>"
                : "TResult";

            return markers.Parameters
                .Select(x => $"Func<T{x}, ")
                .Append(result)
                .Concat(Enumerable.Range(0, argsCount).Select(_ => ">"))
                .Join();
        }
    }
}
