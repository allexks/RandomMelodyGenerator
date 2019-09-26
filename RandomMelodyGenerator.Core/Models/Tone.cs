using System;

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

        public double PitchInHertz => GetPitchInFirstOctaveInHertz(Name) * Math.Pow(2, Octave.First - Octave);

        public Tone TransposeUp(Interval interval)
        {
            var newToneName = (ToneName)(((int)Name + interval.Semitones) % 12);
            var newOctave = (Octave)((int)Octave + (interval.Semitones / 12));
            return new Tone(newToneName, newOctave);
        }

        public Tone TransposeDown(Interval interval)
        {
            var newToneName = (ToneName)(((int)Name - interval.Semitones) % 12);
            var newOctave = (Octave)((int)Octave - (interval.Semitones / 12));
            return new Tone(newToneName, newOctave);
        }

        public static ToneName TransposeUp(ToneName toneName, Interval interval)
        {
            return new Tone(toneName, Octave.First).TransposeUp(interval).Name;
        }

        public static ToneName TransposeDown(ToneName toneName, Interval interval)
        {
            return new Tone(toneName, Octave.First).TransposeDown(interval).Name;
        }

        private double GetPitchInFirstOctaveInHertz(ToneName tone)
        {
            switch (tone)
            {
                case ToneName.C:
                    return 261.63;
                case ToneName.Db:
                    return 277.18;
                case ToneName.D:
                    return 293.66;
                case ToneName.Eb:
                    return 311.13;
                case ToneName.E:
                    return 329.63;
                case ToneName.F:
                    return 349.23;
                case ToneName.Gb:
                    return 369.99;
                case ToneName.G:
                    return 392;
                case ToneName.Ab:
                    return 415.3;
                case ToneName.A:
                    return 440;
                case ToneName.Bb:
                    return 466.16;
                case ToneName.B:
                    return 493.88;
                default:
                    throw new Exception("You just invented a new tone.");
            }
        }
    }
}
