using RandomMelodyGenerator.Core.Models;
using System.Collections.Generic;

namespace RandomMelodyGenerator.Core.Services.Interfaces
{
    public interface IGeneratorService
    {
        public IEnumerable<Note> GenerateRandomRhythm(Tempo tempo, uint numberOfMeasures = 1, TimeSignature timeSignature = TimeSignature.FourFour);
        public IEnumerable<Note> GenerateRandomMelody(IEnumerable<Note> notes);
        public IEnumerable<Note> GenerateRandomMelody(Scale scale, Tempo tempo, uint numberOfMeasures = 1, TimeSignature timeSignature = TimeSignature.FourFour);
    }
}
