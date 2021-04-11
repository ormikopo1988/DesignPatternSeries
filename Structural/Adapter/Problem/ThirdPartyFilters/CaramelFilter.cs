using System;

namespace Adapter.Problem.ThirdPartyFilters
{
    /// <summary>
    /// If we try to use this class inside Apply(IFilter filter) method of ImageView class we will have a compilation error.
    /// The Apply method expects an interface of type IFilter while this third party CaramelFilter has a different interface
    /// than the one expected. This is where we should apply the Adapter pattern.
    /// </summary>
    public class CaramelFilter
    {
        // This third party library has a requirement of always calling this Init method whenever we are about to use one of its provided filters.
        public void Init()
        {
            Console.WriteLine("Initializing caramel filter.");
        }

        public void Render(Image image)
        {
            Console.WriteLine("Applying caramel filter to image.");
        }
    }
}
