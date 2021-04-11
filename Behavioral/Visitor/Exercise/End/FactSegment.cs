namespace Visitor.Exercise.End
{
    public class FactSegment : ISegment
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
