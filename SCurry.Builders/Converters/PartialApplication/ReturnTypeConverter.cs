using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.PartialApplication
{
    internal sealed class ReturnTypeConverter : IConverter
    {
        public string Convert(MethodDefinition definition) => definition
            .Parameters
            .Where(x => !x.IsArgument)
            .Select(x => x.TypeName)
            .AppendIf(() => definition.Type == MethodType.Function, "TResult")
            .Join(", ")
            .MapIfExists(types => $"<{types}>")
            .Map(types => $"{definition.Delegate}{types}");
    }
}
