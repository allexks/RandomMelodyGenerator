namespace RandomMelodyGenerator.Core.Models
{
    public struct Tempo
    {
        public uint BeatsPerMinute { get; }

        public Tempo(uint beatsPerMinute)
        {
            BeatsPerMinute = beatsPerMinute;
        }
    }
}
