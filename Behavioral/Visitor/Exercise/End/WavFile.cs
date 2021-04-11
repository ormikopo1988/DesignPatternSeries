using System.Collections.Generic;

namespace Visitor.Exercise.End
{
    public class WavFile
    {
        private readonly List<ISegment> segments = new List<ISegment>();

        public void AddSegment(ISegment segment)
        {
            segments.Add(segment);
        }

        public void Execute(IOperation operation)
        {
            foreach(var segment in segments)
            {
                segment.Execute(operation);
            }
        }
    }
}
