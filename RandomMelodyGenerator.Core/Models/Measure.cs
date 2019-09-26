using System.Collections.Generic;

namespace RandomMelodyGenerator.Core.Models
{
    public class Measure
    {
        public IEnumerable<Note> Notes { get; set; }
        public TimeSignature TimeSignature { get; set; }
    }
}
