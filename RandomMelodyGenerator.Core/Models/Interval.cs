using System;
using System.Collections.Generic;

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
            CheckForMusicalNonsense();
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
                    throw new IntervalNotValidException(this);
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
                    throw new IntervalNotValidException(this);
            }
        }

        private int CalculateIntervalSemitones(IntervalQuality quality, IntervalNumber number)
        {
            return GetSemitonesToPerfectOrMajor(number) + GetOffsetToPerfectOrMajorInSemitones(quality);
        }

        private static List<IntervalNumber> PerfectIntervals = new List<IntervalNumber> {
            IntervalNumber.Unison,
            IntervalNumber.Fourth,
            IntervalNumber.Fifth,
            IntervalNumber.Octave
        };

        private void CheckForMusicalNonsense()
        {
            if (Quality == null || Number == null)
            {
                return;
            }

            var number = Number.Value;
            var quality = Quality.Value;

            if ((PerfectIntervals.Contains(number) && (quality == IntervalQuality.Major || quality == IntervalQuality.Minor))
                || (!PerfectIntervals.Contains(number) && (quality == IntervalQuality.Perfect)))
            {
                throw new IntervalNotValidException(this);
            }
        }

        // Convenience static methods and definitions

        public static implicit operator int(Interval interval)
        {
            return interval.Semitones;
        }

        public static implicit operator Interval(int semitones)
        {
            return new Interval(semitones);
        }

        public static Interval Semitone = 1;
        public static Interval WholeTone = 2;
        public static Interval Tritone = 6;
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

    public class IntervalNotValidException: Exception
    {
        public IntervalNotValidException(Interval interval):
            base($"Interval {interval.ToString()} is not valid.")
        {
        }
    }
}
