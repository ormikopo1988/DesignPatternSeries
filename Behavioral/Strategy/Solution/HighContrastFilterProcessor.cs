using System;

namespace Strategy.Solution
{
    public class HighContrastFilterProcessor : IFilterStrategy
    {
        public void ApplyFilter(string fileName)
        {
            Console.WriteLine($"Applying high contrast filter to file with name {fileName}.");
        }
    }
}
