using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Converters;
using SCurry.Builders.Converters.PartialApplication;
using SCurry.Builders.Converters.Shared;
using SCurry.Builders.Models;

namespace SCurry.Builders.Builders
{
    public sealed class PartialApplicationBuilder
    {
        private readonly Builder _builder;

        public PartialApplicationBuilder()
        {
            var typeParameters = new TypeParametersConverter();

            _builder = new Builder(
                new ReturnTypeConverter(),
                new NameConverter("Partial", typeParameters),
                new ArgumentsConverter(typeParameters),
                new BodyConverter(new BodyCallConverter(new AllArgumentsConverter())));
        }

        public IEnumerable<string> GenerateFuncExtentions(int gapsCount, int argsCount)
        {
            yield return "public static Func<TResult> Partial<TResult>(this Func<TResult> func) => func;";

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
            yield return "public static Action Partial(this Action action) => action;";

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
