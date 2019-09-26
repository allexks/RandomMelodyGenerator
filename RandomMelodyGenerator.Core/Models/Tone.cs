namespace RandomMelodyGenerator.Core.Models
{
    public struct Tone
    {
        public ToneName Name { get; }
        public Octave Octave { get; }

        public Tone(ToneName name, Octave octave)
        {
            Name = name;
            Octave = octave;
        }

        public double PitchInHertz
        {
            get
            {
                // TODO
                return 0;
            }
        }
    }
}
