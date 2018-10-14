using SCurry.Builders.Converters;

namespace SCurry.Builders
{
    public sealed class MarkerFlags
    {
        public MarkerFlags(MarkersType type, bool[] flags)
        {
            Flags = flags;
            Type = type;
        }

        public bool[] Flags { get; }

        public MarkersType Type { get; }

        public string Apply(IConverter converter) => converter.Convert(this);
    }
}
