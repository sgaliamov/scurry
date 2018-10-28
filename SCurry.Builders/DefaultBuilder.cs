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

        public IEnumerable<string> GenerateFuncExtensions(int gapsCount, int maxArgsCount, int limitPartial) =>
            Generate(MethodType.Function, gapsCount, maxArgsCount, limitPartial);

        public IEnumerable<string> GenerateActionExtensions(int gapsCount, int maxArgsCount, int limitPartial) =>
            Generate(MethodType.Action, gapsCount, maxArgsCount, limitPartial);

        private IEnumerable<string> Generate(
            MethodType methodType,
            int gapsCount,
            int maxArgsCount,
            int limitPartial)
        {
            for (var argsCount = 0; argsCount <= maxArgsCount; argsCount++)
            {
                var extensions = _definitionsBuilder
                                 .Build(methodType, gapsCount, argsCount, limitPartial)
                                 .Select(_methodMethodConverter.Convert);

                foreach (var item in extensions)
                {
                    yield return item;
                }
            }
        }
    }
}
