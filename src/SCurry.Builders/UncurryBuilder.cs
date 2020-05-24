using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Converters;
using SCurry.Builders.Models;

namespace SCurry.Builders
{
    public sealed class UncurryBuilder
    {
        private readonly IMethodDefinitionsBuilder _definitionsBuilder;
        private readonly IConverter _methodConverter;

        public UncurryBuilder(IConverter converter, IMethodDefinitionsBuilder definitionsBuilder)
        {
            _methodConverter = converter;
            _definitionsBuilder = definitionsBuilder;
        }

        public IEnumerable<string> GenerateFuncExtensions(int maxArgsCount) =>
            Generate(MethodType.Function, maxArgsCount);

        public IEnumerable<string> GenerateActionExtensions(int maxArgsCount) =>
            Generate(MethodType.Action, maxArgsCount);

        private IEnumerable<string> Generate(MethodType methodType, int maxArgsCount)
        {
            for (var argsCount = 0; argsCount <= maxArgsCount; argsCount++) {
                var definition = _definitionsBuilder
                                 .Build(methodType, argsCount, 0, 0)
                                 .Select(_methodConverter.Convert)
                                 .Single();

                yield return definition;
            }
        }
    }
}
