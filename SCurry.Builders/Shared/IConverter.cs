using SCurry.Builders.Models;

namespace SCurry.Builders.Shared
{
    public interface IConverter
    {
        string Convert(MethodDefinition definition);
    }
}
