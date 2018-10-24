using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.PartialApplication
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
                             .Select(x => x.TypeName)
                             .AppendIf(
                                 () => definition.Type == MethodType.Function,
                                 () => "TResult")
                             .AppendIf(
                                 () => definition.Type == MethodType.Action,
                                 () => $"{parameters.Last().TypeName}")
                             .Join(", ")
                             .MapIfExists(types => $"<{types}>")
                             .Map(types => $"{definition.Delegate}{types}");
        }
    }
}
