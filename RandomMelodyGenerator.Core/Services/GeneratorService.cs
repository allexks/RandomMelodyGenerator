using System.Collections.Generic;
using RandomMelodyGenerator.Core.Models;
using RandomMelodyGenerator.Core.Services.Interfaces;

namespace RandomMelodyGenerator.Core.Services
{
    public class GeneratorService : IGeneratorService
    {
        public TimeSignature TimeSignature { get; set; } = TimeSignature.Common;

        public Measure GenerateRandomMelody(Measure measure, Scale scale)
        {
            // TODO: Melody generation goes here

            return measure;
        }

        public Measure GenerateRandomMelody(Scale scale)
        {
            return GenerateRandomMelody(GenerateRandomRhythm(), scale);
        }

        public Measure GenerateRandomRhythm()
        {
            var result = new List<Note>();

            // TODO: Rhythm generation algorithm goes here

            return new Measure
            {
                Notes = result,
                TimeSignature = TimeSignature
            };
        }
    }
}
