using System;

namespace Visitor.Solution
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("Highlighting heading node.");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("Highlighting anchor node.");
        }
    }
}
