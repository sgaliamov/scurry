﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Models
{
    public static class MethodDefinitionsBuilder
    {
        public static MethodDefinition[] Build(MethodType type, int gapsCount, int startCount, int argsCount)
        {
            if (argsCount < 0 || argsCount > Constants.MaxInputArgumentsCount)
            {
                throw new ArgumentOutOfRangeException(nameof(argsCount));
            }

            if (gapsCount < 0 || gapsCount > argsCount)
            {
                throw new ArgumentOutOfRangeException(nameof(gapsCount));
            }

            if (gapsCount == 0)
            {
                return GenerateWithoutGaps(type, startCount, argsCount).ToArray();
            }

            var gapped = GenerateWithGaps(type, gapsCount, argsCount);

            var rest = GenerateWithoutGaps(type, startCount, argsCount);

            return gapped.Concat(rest).ToArray();
        }

        private static IEnumerable<MethodDefinition> GenerateWithGaps(MethodType type,
            int gapsCount,
            int argsCount)
        {
            var max = (1 << gapsCount) - 1;

            return Enumerable.Range(1, max)
                .Select(index => new MethodDefinition(type, ValueToParameters(index, argsCount)));
        }

        private static IEnumerable<MethodDefinition> GenerateWithoutGaps(
            MethodType type,
            int startCount,
            int argsCount)
        {
            do
            {
                var min = (1 << startCount) - 1;
                var flags = ValueToParameters(min, startCount);

                yield return new MethodDefinition(type, flags);
            } while (++startCount <= argsCount);
        }

        private static Parameter[] ValueToParameters(int value, int length) =>
            new BitArray(new[] { value })
                .OfType<bool>()
                .Take(length)
                .Select((hasArg, index) => new Parameter(hasArg, index + 1))
                .ToArray();
    }
}
