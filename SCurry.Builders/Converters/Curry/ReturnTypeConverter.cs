using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    public sealed class ReturnTypeConverter : IConverter
    {
        public string Convert(MethodDefinition definition)
        {
            var argsCount = definition.TrimmedParameters.Length;

            var result = definition.Type == MethodType.Action
                ? $"Action<T{argsCount}>"
                : "TResult";

            var take = definition.Type == MethodType.Function
                ? argsCount
                : argsCount - 1;

            return definition.TrimmedParameters
                .Take(take)
                .Select(x => $"Func<{x.TypeName}, ")
                .Append(result)
                .Concat(Enumerable.Range(0, take).Select(_ => ">"))
                .Join();
        }
    }
}
