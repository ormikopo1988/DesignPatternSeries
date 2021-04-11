using System;

namespace Visitor.Problem
{
    public class HeadingNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlighting heading node.");
        }
    }
}
