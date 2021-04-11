namespace Visitor.Exercise.End
{
    public interface IOperation
    {
        void Apply(FactSegment factSegment);
        void Apply(FormatSegment formatSegment);
    }
}
