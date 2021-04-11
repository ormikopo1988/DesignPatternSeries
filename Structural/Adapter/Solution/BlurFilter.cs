using System;

namespace Adapter.Solution
{
    public class BlurFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying blur filter.");
        }
    }
}
