using System.Collections.Generic;

namespace Visitor.Solution
{
    public class HtmlDocument 
    {
        private readonly List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
