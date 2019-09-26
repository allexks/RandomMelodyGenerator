using System.Collections.Generic;
using RandomMelodyGenerator.Core.Models;
using RandomMelodyGenerator.Core.Services.Interfaces;

namespace RandomMelodyGenerator.Core.Services
{
    public class GeneratorService : IGeneratorService
    {
        // TODO: Implement interface and create algorithm

        public TimeSignature TimeSignature { get; set; } = TimeSignature.Common;

        public Measure GenerateRandomMelody(Measure measure)
        {
            throw new System.NotImplementedException();
        }

        public Measure GenerateRandomMelody(Scale scale)
        {
            throw new System.NotImplementedException();
        }

        public Measure GenerateRandomRhythm()
        {
            throw new System.NotImplementedException();
        }
    }
}
