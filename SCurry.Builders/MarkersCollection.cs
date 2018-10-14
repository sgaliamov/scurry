using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using SCurry.Builders.Shared;

namespace SCurry.Builders
{
    public sealed class MarkersCollection
    {
        public MarkersCollection(MarkerFlags[] markers) => Markers = markers;

        public MarkersCollection(MarkersType type, int gapsCount, int maxCount)
            : this(GetMarkers(type, gapsCount, maxCount)) { }

        public MarkerFlags[] Markers { get; }

        private static MarkerFlags[] GetMarkers(MarkersType type, int gapsCount, int maxCount)
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

        private static IEnumerable<MarkerFlags> GetMarkersWithGaps(MarkersType type, int gapsCount, int argsCount)
        {
            var max = (1 << gapsCount) - 1;

            return Enumerable.Range(1, max)
                .Select(index => new MarkerFlags(type, ValueToMarkers(index, argsCount)));
        }

        private static IEnumerable<MarkerFlags> GetMarkersWithoutGaps(MarkersType type, int startCount, int argsCount)
        {
            do
            {
                var min = (1 << startCount) - 1;
                var flags = ValueToMarkers(min, startCount);

                yield return new MarkerFlags(type, flags);
            } while (++startCount <= argsCount);
        }

        private static bool[] ValueToMarkers(int value, int length) =>
            new BitArray(new[] { value })
                .OfType<bool>()
                .Take(length)
                .ToArray();
    }
}
