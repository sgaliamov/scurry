using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Models
{
    public sealed class MethodDefinitionsBuilder : IMethodDefinitionsBuilder
    {
        public MethodDefinition[] Build(MethodType type, int gapsCount, int argsCount, int limitPartial)
        {
            if (argsCount < 0 || argsCount > Constants.MaxInputArgumentsCount)
            {
                throw new ArgumentOutOfRangeException(nameof(argsCount));
            }

            if (gapsCount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(gapsCount));
            }

            return Generate(type, gapsCount, argsCount, limitPartial).ToArray();
        }

        private static IEnumerable<MethodDefinition> Generate(MethodType type, int gapsCount, int argsCount, int limitPartial)
        {
            yield return new MethodDefinition(type, ValueToParameters(0, argsCount));

            if (argsCount == 0)
            {
                yield break;
            }

            if (gapsCount > argsCount)
            {
                gapsCount = argsCount;
            }

            foreach (var item in GenerateGaps(type, gapsCount, argsCount))
            {
                yield return item;
            }

            foreach (var item in GeneratePartials(type, gapsCount, argsCount, limitPartial))
            {
                yield return item;
            }
        }

        private static IEnumerable<MethodDefinition> GenerateGaps(
            MethodType type,
            int gapsCount,
            int argsCount)
        {
            if (gapsCount < argsCount)
            {
                return Enumerable.Empty<MethodDefinition>();
            }

            var max = (1 << gapsCount) - 2;

            return Enumerable.Range(1, max)
                             .Select(index => new MethodDefinition(type, ValueToParameters(index, argsCount)));
        }

        private static IEnumerable<MethodDefinition> GeneratePartials(MethodType type,
            int gapsCount,
            int argsCount,
            int limitPartial)
        {
            if (limitPartial < argsCount)
            {
                yield break;
            }

            var startCount = gapsCount < argsCount
                ? 1
                : gapsCount + 1;

            do
            {
                var min = (1 << startCount) - 1;
                var flags = ValueToParameters(min, argsCount);

                yield return new MethodDefinition(type, flags);
            } while (++startCount <= argsCount);
        }

        private static Parameter[] ValueToParameters(int value, int length) =>
            new BitArray(new[] { value }).OfType<bool>()
                                         .Take(length)
                                         .Select((isArg, index) => new Parameter(isArg, index + 1))
                                         .ToArray();
    }
}
