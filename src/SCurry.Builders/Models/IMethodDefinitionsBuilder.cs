namespace SCurry.Builders.Models
{
    public interface IMethodDefinitionsBuilder
    {
        MethodDefinition[] Build(MethodType type, int argsCount, int gapsCount, int limitPartial);
    }
}
