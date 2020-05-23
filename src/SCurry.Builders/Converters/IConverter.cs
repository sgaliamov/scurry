using SCurry.Builders.Models;

namespace SCurry.Builders.Converters
{
    public interface IConverter
    {
        string Convert(MethodDefinition definition);
    }
}
