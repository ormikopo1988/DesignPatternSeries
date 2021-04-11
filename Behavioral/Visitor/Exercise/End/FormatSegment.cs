namespace Visitor.Exercise.End
{
    public class FormatSegment : ISegment
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
