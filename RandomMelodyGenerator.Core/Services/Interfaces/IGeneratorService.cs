using RandomMelodyGenerator.Core.Models;
using System.Collections.Generic;

namespace RandomMelodyGenerator.Core.Services.Interfaces
{
    public interface IGeneratorService
    {
        public TimeSignature TimeSignature { get; set; }
        public Measure GenerateRandomRhythm();
        public Measure GenerateRandomMelody(Measure measure);
        public Measure GenerateRandomMelody(Scale scale);
    }
}
