using System;

namespace Visitor.Exercise.End
{
    public class Normalize : IOperation
    {
        public void Apply(FactSegment factSegment)
        {
            Console.WriteLine("Normalizing fact segment.");
        }

        public void Apply(FormatSegment formatSegment)
        {
            Console.WriteLine("Normalizing format segment.");
        }
    }
}
