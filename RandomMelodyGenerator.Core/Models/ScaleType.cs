using System.Collections.Generic;

namespace RandomMelodyGenerator.Core.Models
{
    public struct ScaleType
    {
        public IList<Interval> IntervalList { get; }

        public int NotesCount => IntervalList.Count;

        public ScaleType(IList<Interval> intervalList)
        {
            IntervalList = intervalList;
        }

        public ScaleType GetNthMode(uint n)
        {
            if (n == 0 || n == 1)
            {
                return this;
            }

            var derivedIntervalList = new List<Interval>();
            foreach (var i in IntervalList)
            {
                derivedIntervalList.Add(IntervalList[(int)(n + 1)] % NotesCount - 1);
            }

            return new ScaleType(derivedIntervalList);
        }

        public static ScaleType Major = new ScaleType(new List<Interval> { 2, 2, 1, 2, 2, 2, 1 });
        public static ScaleType Dorian = Major.GetNthMode(2);
        public static ScaleType Phrygian = Major.GetNthMode(3);
        public static ScaleType Lydian = Major.GetNthMode(4);
        public static ScaleType Mixolydian = Major.GetNthMode(5);
        public static ScaleType Minor = Major.GetNthMode(6);
        public static ScaleType Locrian = Major.GetNthMode(7);

        public static ScaleType MelodicMinor = new ScaleType(new List<Interval> { 2, 1, 2, 2, 2, 2, 1 });
        public static ScaleType HarmonicMinor = new ScaleType(new List<Interval> { 2, 1, 2, 2, 1, 3, 1 });
        public static ScaleType PhrygianDominant = HarmonicMinor.GetNthMode(5);
        public static ScaleType BiharmonicMinor = new ScaleType(new List<Interval> { 2, 1, 3, 1, 1, 3, 1 });
        public static ScaleType BiharmonicMajor = BiharmonicMinor.GetNthMode(5);

        public static ScaleType MinorPentatonic = new ScaleType(new List<Interval> { 3, 2, 2, 3, 2 });
        public static ScaleType MajorPentatonic = MinorPentatonic.GetNthMode(2);
        public static ScaleType Japanese = new ScaleType(new List<Interval> { 1, 4, 2, 1, 4 });
        public static ScaleType SouthEastAsian = new ScaleType(new List<Interval> { 1, 2, 4, 1, 4 });

        public static ScaleType MinorBlues = new ScaleType(new List<Interval> { 3, 2, 1, 1, 3, 2 });
        public static ScaleType MajorBlues = MinorBlues.GetNthMode(2);

    }


}
