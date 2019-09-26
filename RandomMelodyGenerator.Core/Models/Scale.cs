namespace RandomMelodyGenerator.Core.Models
{
    public struct Scale
    {
        public Tone Tonic { get; }
        public ScaleType Type { get; }

        public Scale(ScaleType type, Tone tonic)
        {
            Tonic = tonic;
            Type = type;
        }
    }
}
