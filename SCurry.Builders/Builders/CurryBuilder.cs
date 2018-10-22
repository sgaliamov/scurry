using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Converters;
using SCurry.Builders.Converters.Curry;
using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;

namespace SCurry.Builders.Builders
{
    public sealed class CurryBuilder
    {
        private readonly Builder _builder;

        public CurryBuilder()
        {
            var typeParameters = new TypeParametersConverter();

            _builder = new Builder(
                new ReturnTypeConverter(),
                new NameConverter("Curry", typeParameters),
                new ArgumentsConverter(typeParameters),
                new BodyConverter(new BodyCallConverter()));
        }

        public IEnumerable<string> GenerateFuncExtentions(int gapsCount, int argsCount)
        {
            var functions = MethodDefinitionsBuilder
                .Build(MethodType.Function, gapsCount, argsCount)
                .Select(_builder.Convert);

            foreach (var definition in functions)
            {
                yield return definition;
            }
        }

        public IEnumerable<string> GenerateActionExtentions(int gapsCount, int argsCount)
        {
            var actions = MethodDefinitionsBuilder
                .Build(MethodType.Action, gapsCount, argsCount)
                .Select(_builder.Convert);

            foreach (var definition in actions)
            {
                yield return definition;
            }
        }
    }
}
