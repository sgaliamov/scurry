using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Converters;
using SCurry.Builders.Models;

namespace SCurry.Builders
{
    public sealed class DefaultBuilder
    {
        private readonly IMethodDefinitionsBuilder _definitionsBuilder;
        private readonly IConverter _methodMethodConverter;

        public DefaultBuilder(IConverter methodConverter, IMethodDefinitionsBuilder definitionsBuilder)
        {
            _methodMethodConverter = methodConverter;
            _definitionsBuilder = definitionsBuilder;
        }

        public IEnumerable<string> GenerateFuncExtensions(int maxArgsCount, int gapsCount, int limitPartial) =>
            Generate(MethodType.Function, maxArgsCount, gapsCount, limitPartial);

        public IEnumerable<string> GenerateActionExtensions(int maxArgsCount, int gapsCount, int limitPartial) =>
            Generate(MethodType.Action, maxArgsCount, gapsCount, limitPartial);

        private IEnumerable<string> Generate(
            MethodType methodType,
            int maxArgsCount,
            int gapsCount,
            int limitPartial)
        {
            for (var argsCount = 0; argsCount <= maxArgsCount; argsCount++) {
                var extensions = _definitionsBuilder
                    .Build(methodType, argsCount, gapsCount, limitPartial)
                    .Select(_methodMethodConverter.Convert);

                foreach (var item in extensions) {
                    yield return item;
                }
            }
        }
    }
}
