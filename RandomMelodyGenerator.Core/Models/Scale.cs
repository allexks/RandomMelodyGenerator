using System;
using System.Collections.Generic;

namespace RandomMelodyGenerator.Core.Models
{
    public struct Scale
    {
        public ToneName TonicName { get; }
        public Tone? Tonic { get; }
        public ScaleType Type { get; }
        public IList<ToneName> ToneNames { get; }
        public IList<Tone> Tones { get; }

        public Scale(ScaleType type, ToneName tonic)
        {
            TonicName = tonic;
            Tonic = null;
            Type = type;
            ToneNames = CalculateScaleToneNames(type, tonic);
            Tones = null;
        }

        public Scale (ScaleType type, Tone tonic)
        {
            TonicName = tonic.Name;
            Tonic = tonic;
            Type = type;
            ToneNames = CalculateScaleToneNames(type, tonic.Name);
            Tones = CalculateTones(type, tonic);
        }

        private static IList<ToneName> CalculateScaleToneNames(ScaleType type, ToneName tonic)
        {
            var result = new List<ToneName> { tonic };
            var lastTone = tonic;
            foreach (var interval in type.IntervalList)
            {
                lastTone = Tone.TransposeUp(lastTone, interval);
                if (lastTone == tonic) break;
                result.Add(lastTone);
            }
            return result;
        }


        private static IList<Tone> CalculateTones(ScaleType type, Tone tonic)
        {
            var result = new List<Tone> { tonic };
            var lastTone = tonic;
            foreach (var interval in type.IntervalList)
            {
                lastTone = lastTone.TransposeUp(interval);
                result.Add(lastTone);
            }
            return result;
        }
    }
}
