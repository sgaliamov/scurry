using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Converters;
using SCurry.Builders.Models;

namespace SCurry.Builders
{
    public class DefaultBuilder
    {
        private readonly IMethodDefinitionsBuilder _definitionsBuilder;
        private readonly IConverter _methodConverter;

        public DefaultBuilder(IConverter converter, IMethodDefinitionsBuilder definitionsBuilder)
        {
            _methodConverter = converter;
            _definitionsBuilder = definitionsBuilder;
        }

        public IEnumerable<string> GenerateFuncExtentions(int gapsCount, int maxArgsCount) =>
            Generate(MethodType.Function, gapsCount, maxArgsCount);

        public IEnumerable<string> GenerateActionExtentions(int gapsCount, int maxArgsCount) =>
            Generate(MethodType.Action, gapsCount, maxArgsCount);

        private IEnumerable<string> Generate(
            MethodType methodType,
            int gapsCount,
            int maxArgsCount)
        {
            for (var argsCount = 0; argsCount <= maxArgsCount; argsCount++)
            {
                var definitions = _definitionsBuilder
                                  .Build(methodType, gapsCount, argsCount)
                                  .Select(_methodConverter.Convert);

                foreach (var definition in definitions)
                {
                    yield return definition;
                }
            }
        }
    }
}
