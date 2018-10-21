using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders.Models
{
    public sealed class MethodsCollection
    {
        public static MethodsCollection Create(MethodType type, int gapsCount, int maxCount) =>
            new MethodsCollection(GetMarkers(type, gapsCount, maxCount));

        public MethodsCollection(MethodDefinition[] markers) => Markers = markers;

        public MethodDefinition[] Markers { get; }

        private static MethodDefinition[] GetMarkers(MethodType type, int gapsCount, int maxCount)
        {
            if (maxCount > Constants.MaxInputArgumentsCount)
            {
                throw new ArgumentOutOfRangeException(nameof(maxCount));
            }

            if (gapsCount < 0 || gapsCount > maxCount)
            {
                throw new ArgumentOutOfRangeException(nameof(gapsCount));
            }

            var gapped = GetMarkersWithGaps(type, gapsCount, maxCount);

            var rest = GetMarkersWithoutGaps(type, gapsCount + 1, maxCount);

            return gapped.Concat(rest).ToArray();
        }

        private static IEnumerable<MethodDefinition> GetMarkersWithGaps(
            MethodType type,
            int gapsCount,
            int argsCount)
        {
            var max = (1 << gapsCount) - 1;

            return Enumerable.Range(1, max)
                .Select(index => new MethodDefinition(type, ValueToMarkers(index, argsCount)));
        }

        private static IEnumerable<MethodDefinition> GetMarkersWithoutGaps(
            MethodType type,
            int startCount,
            int argsCount)
        {
            do
            {
                var min = (1 << startCount) - 1;
                var flags = ValueToMarkers(min, startCount);

                yield return new MethodDefinition(type, flags);
            } while (++startCount <= argsCount);
        }

        private static Parameter[] ValueToMarkers(int value, int length) =>
            new BitArray(new[] { value })
                .OfType<bool>()
                .Take(length)
                .Select((hasArg, index) => new Parameter(hasArg, index + 1))
                .ToArray();
    }
}
