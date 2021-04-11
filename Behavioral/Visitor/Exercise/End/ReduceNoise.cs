using System;

namespace Visitor.Exercise.End
{
    public class ReduceNoise : IOperation
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Reducing noise in fact segment.");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Reducing noise in format segment.");
        }
    }
}
