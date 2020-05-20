using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.PartialApplication
{
    internal sealed class ReturnTypeConverter : IConverter
    {
        public string Convert(MethodDefinition definition)
        {
            if (definition.GappedParameters.Length == 0)
            {
                return definition.SimpleReturnType;
            }

            var take = definition.Type == MethodType.Function
                ? definition.GappedParameters.Length
                : definition.GappedParameters.Length - 1;

            return definition.GappedParameters
                             .Take(take)
                             .Select(x => x.TypeName)
                             .AppendIf(
                                 () => definition.Type == MethodType.Function,
                                 () => "TResult")
                             .AppendIf(
                                 () => definition.Type == MethodType.Action,
                                 () => $"{definition.GappedParameters.Last().TypeName}")
                             .Join(", ")
                             .MapIfExists(types => $"<{types}>")
                             .Map(types => $"{definition.Delegate}{types}");
        }
    }
}
