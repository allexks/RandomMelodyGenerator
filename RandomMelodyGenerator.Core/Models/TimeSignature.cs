namespace RandomMelodyGenerator.Core.Models
{
    public struct TimeSignature
    {
        public uint UpperNumber { get; }
        public uint LowerNumber { get; }

        public TimeSignature(uint upperNumber = 4, uint lowerNumber = 4)
        {
            UpperNumber = upperNumber;
            LowerNumber = lowerNumber;
        }

        public static TimeSignature Common = new TimeSignature();
        public static TimeSignature CutCommon = new TimeSignature(2, 2);

        public static TimeSignature TwoTwo = new TimeSignature(2, 2);

        public static TimeSignature TwoFour = new TimeSignature(2, 4);
        public static TimeSignature ThreeFour = new TimeSignature(3, 4);
        public static TimeSignature FourFour = new TimeSignature();
        public static TimeSignature FiveFour = new TimeSignature(5, 4);
        public static TimeSignature SixFour = new TimeSignature(6, 4);
        public static TimeSignature SevenFour = new TimeSignature(7, 4);

        public static TimeSignature FiveEight = new TimeSignature(5, 8);
        public static TimeSignature SixEight = new TimeSignature(6, 8);
        public static TimeSignature SevenEight = new TimeSignature(7, 8);
        public static TimeSignature EightEight = new TimeSignature(8, 8);
        public static TimeSignature NineEight = new TimeSignature(9, 8);
        public static TimeSignature TenEight = new TimeSignature(10, 8);
        public static TimeSignature ElevenEight = new TimeSignature(11, 8);
        public static TimeSignature TwelveEight = new TimeSignature(12, 8);
        public static TimeSignature ThirteenEight = new TimeSignature(13, 8);
        public static TimeSignature FifteenEight = new TimeSignature(15, 8);

        public static TimeSignature ElevenSixteen = new TimeSignature(11, 16);
        public static TimeSignature ThirteenSixteen = new TimeSignature(13, 16);
        public static TimeSignature FifteenSixteen = new TimeSignature(15, 16);
    }
}
