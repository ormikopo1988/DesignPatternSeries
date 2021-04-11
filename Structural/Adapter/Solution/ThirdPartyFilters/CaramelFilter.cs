using System;

namespace Adapter.Solution.ThirdPartyFilters
{
    // This code cannot be changed, it comes from a third-party library and we do not have access to the source code
    public class CaramelFilter
    {
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
