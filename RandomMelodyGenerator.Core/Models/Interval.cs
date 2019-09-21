using System;

namespace RandomMelodyGenerator.Core.Models
{
    public class Interval
    {
        public IntervalNumber? Number { get; private set; }
        public IntervalQuality? Quality { get; private set; }
        public int Semitones { get; private set; }

        public Interval(IntervalQuality quality, IntervalNumber number)
        {
            Quality = quality;
            Number = number;
            Semitones = CalculateIntervalSemitones(quality, number);
        }

        public Interval(int semitones)
        {
            Number = null;
            Quality = null;
            Semitones = semitones;
        }

        // Helpers
        private int GetSemitonesToPerfectOrMajor(IntervalNumber number)
        {
            switch (number)
            {
                case IntervalNumber.Unison:
                    return 0;
                case IntervalNumber.Second:
                    return 2;
                case IntervalNumber.Third:
                    return 4;
                case IntervalNumber.Fourth:
                    return 5;
                case IntervalNumber.Fifth:
                    return 7;
                case IntervalNumber.Sixth:
                    return 9;
                case IntervalNumber.Seventh:
                    return 11;
                case IntervalNumber.Octave:
                    return 12;
                default:
                    throw new NotImplementedException();
            }
        }

        private int GetOffsetToPerfectOrMajorInSemitones(IntervalQuality quality)
        {
            switch (quality)
            {
                case IntervalQuality.Diminished:
                    return -2;
                case IntervalQuality.Minor:
                    return -1;
                case IntervalQuality.Perfect:
                case IntervalQuality.Major:
                    return 0; ;
                case IntervalQuality.Augmented:
                    return +1;
                default:
                    throw new NotImplementedException();
            }
        }

        private int CalculateIntervalSemitones(IntervalQuality quality, IntervalNumber number)
        {
            return GetSemitonesToPerfectOrMajor(number) + GetOffsetToPerfectOrMajorInSemitones(quality);
        }
    }

    public enum IntervalQuality
    {
        Diminished,
        Minor,
        Perfect,
        Major,
        Augmented
    }

    public enum IntervalNumber
    {
        Unison = 1,
        Second = 2,
        Third = 3,
        Fourth = 4,
        Fifth = 5,
        Sixth = 6,
        Seventh = 7,
        Octave = 8
    }
}
