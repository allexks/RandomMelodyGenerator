namespace RandomMelodyGenerator.Core.Models
{
    public struct Tone
    {
        public ToneName name { get; }
        public Octave octave { get; }

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
