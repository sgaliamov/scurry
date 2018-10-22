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
                new BodyConverter(new BodyCallConverter(new AllArgumentsConverter())));
        }

        public IEnumerable<string> GenerateFuncExtentions(int gapsCount, int argsCount)
        {
            yield return "public static Func<TResult> Curry<TResult>(this Func<TResult> func) => func;";
            yield return "public static Func<T1, TResult> Curry<T1, TResult>(this Func<T1, TResult> func) => func;";

            var functions = MethodDefinitionsBuilder
                .Build(MethodType.Function, gapsCount, 2, argsCount)
                .Select(_builder.Convert);

            foreach (var definition in functions)
            {
                yield return definition;
            }
        }

        public IEnumerable<string> GenerateActionExtentions(int gapsCount, int argsCount)
        {
            yield return "public static Action Curry(this Action action) => action;";
            yield return "public static Action<T1> Curry<T1>(this Action<T1> action) => action;";

            var actions = MethodDefinitionsBuilder
                .Build(MethodType.Action, gapsCount, 2, argsCount)
                .Select(_builder.Convert);

            foreach (var definition in actions)
            {
                yield return definition;
            }
        }
    }
}
