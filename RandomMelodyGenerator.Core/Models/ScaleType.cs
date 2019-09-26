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
            if (n == 0)
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

        public static ScaleType Major = new ScaleType(new List<Interval>{2,2,1,2,2,2,1});
        // TODO: Add all
    }


}
