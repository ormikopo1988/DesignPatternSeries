using System;

namespace Visitor.Solution
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("Extracting plain text from heading node.");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("Extracting plain text from anchor node.");
        }
    }
}
