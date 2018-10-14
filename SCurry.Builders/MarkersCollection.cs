using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SCurry.Builders
{
    public sealed class MarkersCollection
    {
        public enum MarkersType : byte
        {
            Function = 0,
            Action = 1
        }

        public const int MaxInputArgumentsCount = 16;
        public const int DefaultGapsCount = 6;

        public readonly MarkersType Type;
        public MarkerFlags[] Markers;

        public MarkersCollection(MarkersType type, MarkerFlags[] markers)
        {
            Type = type;
            Markers = markers;
        }

        public MarkersCollection(MarkersType type, int gapsCount, int maxCount)
            : this(type, GetMarkers(gapsCount, maxCount)) { }

        private static MarkerFlags[] GetMarkers(int gapsCount, int maxCount)
        {
            var gapped = GetMarkersWithGaps(gapsCount, maxCount);

            var rest = GetMarkersWithoutGaps(gapsCount + 1, maxCount);

            return gapped.Concat(rest).ToArray();
        }

        private static IEnumerable<MarkerFlags> GetMarkersWithGaps(int gapsCount, int argsCount)
        {
            var max = (1 << gapsCount) - 1;

            return Enumerable.Range(1, max)
                .Select(index => new MarkerFlags(ValueToMarkers(index, argsCount)));
        }

        private static IEnumerable<MarkerFlags> GetMarkersWithoutGaps(int startCount, int argsCount)
        {
            do
            {
                var min = (1 << startCount) - 1;
                var flags = ValueToMarkers(min, startCount);

                yield return new MarkerFlags(flags);
            } while (++startCount <= argsCount);
        }

        private static bool[] ValueToMarkers(int value, int length) =>
            new BitArray(new[] { value })
                .OfType<bool>()
                .Take(length)
                .ToArray();

        public sealed class MarkerFlags
        {
            public readonly bool[] Flags;

            public MarkerFlags(bool[] flags) => Flags = flags;
        }
    }
}
