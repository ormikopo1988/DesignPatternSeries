using System;

namespace Visitor.Problem
{
    /// <summary>
    /// An anchor is a hyperlink.
    /// </summary>
    public class AnchorNode : IHtmlNode
    {
        public void Highlight()
        {
            Console.WriteLine("Highlighting anchor node.");
        }
    }
}
