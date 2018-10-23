using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Curry
{
    internal sealed class ReturnTypeConverter : IConverter
    {
        public string Convert(MethodDefinition definition)
        {
            var parameters = definition.Parameters
                                       .Where(x => !x.IsArgument)
                                       .ToArray();

            var argsCount = parameters.Length;

            if (argsCount == 0)
            {
                return definition.SimpleReturnType;
            }

            var take = definition.Type == MethodType.Function
                ? argsCount
                : argsCount - 1;

            return parameters.Take(take)
                             .Select(x => $"Func<{x.TypeName}, ")
                             .AppendIf(
                                 () => definition.Type == MethodType.Action,
                                 $"Action<T{argsCount}>")
                             .AppendIf(
                                 () => definition.Type == MethodType.Function,
                                 "TResult")
                             .Concat(Enumerable.Range(0, take).Select(_ => ">"))
                             .Join();
        }
    }
}
