namespace Visitor.Problem
{
    public interface IHtmlNode
    {
        void Highlight();
        // Let's suppose we want to introduce another functionality here, like
        // string PlainText();
        // For getting the plain text of an IHtmlNode.
        // We need to declare the new method in this interface and then
        // we have to implement it in our entire object structure (HeadingNode, AnchorNode, etc.)
        // that implements the IHtmlNode interface and also inside the HtmlDocument class itself.
        // In the HtmlDocument class we need to declare a similar method string PlainText() and 
        // iterate over all nodes inside the HtmlDocument and call the PlainText() method
        // in each one of them.
        // This is the problem the Visitor pattern tries to solve. It allows us to add new operations
        // an object structure without modifying it.
    }
}
