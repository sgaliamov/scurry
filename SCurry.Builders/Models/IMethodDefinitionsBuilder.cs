namespace SCurry.Builders.Models
{
    public interface IMethodDefinitionsBuilder
    {
        MethodDefinition[] Build(MethodType type, int gapsCount, int argsCount);
    }
}