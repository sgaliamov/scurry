using System.Linq;
using SCurry.Builders.Models;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Converters.Shared
{
    internal sealed class TypeParametersConverter : IConverter
    {
        public string Convert(MethodDefinition definition) =>
            definition.Parameters
                      .Select(x => x.TypeName)
                      .AppendIf(() => definition.Type == MethodType.Function, () => "TResult")
                      .Join(", ")
                      .MapIfExists(s => $"<{s}>");
    }
}
