using System;
namespace RandomMelodyGenerator.Core.Models
{
    public class Note
    {
        // TODO
        public Tone Tone { get; set; }
        public Duration Duration { get; }
        public bool IsPause { get; set; }
        public Note(Tone tone, Duration duration, bool isPause)
        {
            Tone = tone;
            Duration = duration;
            IsPause = isPause;
        }
    }

    public struct Duration
    {
        // TODO
        public float Number { get; }

        public Duration(float number)
        {
            Number = number;
        }

        public static implicit operator Duration(int number)
        {
            return new Duration(number);
        }

        public static implicit operator Duration(float number)
        {
            return new Duration(number);
        }
    }
}
