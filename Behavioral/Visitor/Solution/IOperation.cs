namespace Visitor.Solution
{
    /// <summary>
    /// This is the Visitor interface.
    /// Here we need to overload the apply method.
    /// Each Apply method will take one object from the current object structure we need to support new operations from.
    /// Once again, we should use this pattern if our object structure is fairly stable, but we want to frequently
    /// support new operations to it. If we needed to support a new type of IHtmlNode then we again need to come
    /// back here and add a new Apply method.
    /// </summary>
    public interface IOperation
    {
        void Apply(HeadingNode headingNode);
        void Apply(AnchorNode anchorNode);
    }
}
