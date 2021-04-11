using System;

namespace Strategy.Solution
{
    public class BlackAndWhiteFilterProcessor : IFilterStrategy
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine($"Applying B&W filter to file with name {fileName}.");
        }
    }
}
