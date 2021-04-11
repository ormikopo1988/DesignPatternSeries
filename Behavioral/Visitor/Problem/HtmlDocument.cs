using System.Collections.Generic;

namespace Visitor.Problem
{
    public class HtmlDocument 
    {
        private readonly List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void HighLight()
        {
            foreach (var node in nodes)
            {
                node.Highlight();
            }
        }
    }
}
