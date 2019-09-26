namespace RandomMelodyGenerator.Core.Models
{
    public class Note
    {
        public Tone? Tone { get; set; } = null;
        public ReversedNoteValue Duration { get; set; } = 1;
        public bool IsPause { get; set; } = true;
    }

    ///<summary>
    ///Models the note value of a note with repriprocal values.<br/>
    ///Examples:<br/>
    ///Whole note -> 1;<br/>
    ///Half note -> 2;<br/>
    ///Eight note -> 8.<br/>
    ///See https://en.wikipedia.org/wiki/Note_value
    ///</summary> 
    public struct ReversedNoteValue
    {
        public float Number { get; }

        public ReversedNoteValue(float number)
        {
            Number = number;
        }

        public static ReversedNoteValue Whole = 1;
        public static ReversedNoteValue Half = 2;
        public static ReversedNoteValue Quarter = 4;
        public static ReversedNoteValue Eight = 8;
        public static ReversedNoteValue Sixteenth = 16;
        public static ReversedNoteValue ThirtySecond = 32;
        public static ReversedNoteValue SixtyFourth = 64;

        public static ReversedNoteValue Triplet = 3;
        public static ReversedNoteValue Quintuplet = 5;
        public static ReversedNoteValue Septuplet = 7;
        public static ReversedNoteValue Ninetuplet = 9;
        public static ReversedNoteValue Eleventuplet = 11;

        public static implicit operator ReversedNoteValue(int number)
        {
            return new ReversedNoteValue(number);
        }

        public static implicit operator ReversedNoteValue(float number)
        {
            return new ReversedNoteValue(number);
        }

        public static explicit operator int(ReversedNoteValue noteValue)
        {
            return (int)noteValue.Number;
        }

        public static implicit operator float(ReversedNoteValue noteValue)
        {
            return noteValue.Number;
        }
    }
}
