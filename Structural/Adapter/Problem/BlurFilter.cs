using System;

namespace Adapter.Problem
{
    public class BlurFilter : IFilter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying blur filter.");
        }
    }
}
