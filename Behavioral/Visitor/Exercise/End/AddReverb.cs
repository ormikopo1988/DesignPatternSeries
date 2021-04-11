using System;

namespace Visitor.Exercise.End
{
    public class AddReverb : IOperation
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Adding reverb in fact segment.");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Adding reverb in format segment.");
        }
    }
}
