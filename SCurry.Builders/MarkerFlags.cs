namespace SCurry.Builders
{
    public sealed class MarkerFlags
    {
        public MarkerFlags(MarkersType type, bool[] flags)
        {
            Flags = flags;
            Type = type;
        }

        public string Delegate => Type == MarkersType.Action ? "Action" : "Func";

        public bool[] Flags { get; }

        public string Target => Type == MarkersType.Action ? "action" : "func";

        public MarkersType Type { get; }
    }
}
