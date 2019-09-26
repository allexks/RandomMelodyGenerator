using System.Collections.Generic;
using RandomMelodyGenerator.Core.Models;
using RandomMelodyGenerator.Core.Services.Interfaces;

namespace RandomMelodyGenerator.Core.Services
{
    public class GeneratorService : IGeneratorService
    {
        // TODO: Implement interface and create algorithm
        public IEnumerable<Note> GenerateRandomMelody(IEnumerable<Note> notes)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Note> GenerateRandomMelody(Scale scale, Tempo tempo, uint numberOfMeasures = 1)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Note> GenerateRandomRhythm(Tempo tempo, uint numberOfMeasures = 1)
        {
            throw new System.NotImplementedException();
        }
    }
}
