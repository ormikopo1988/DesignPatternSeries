using System;

namespace Strategy.Solution
{
    public class ImageStorage
    {
        private readonly ICompressorStrategy compressor;
        private readonly IFilterStrategy filter;

        public ImageStorage(ICompressorStrategy compressor, IFilterStrategy filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void Store(string fileName)
        {
            compressor.ApplyCompression(fileName);

            filter.ApplyFilter(fileName);

            Console.WriteLine($"Store image with name {fileName}.");
        }

        // We can also pass the strategy implementation objects in the method
        // and not in the constructor to apply different behaviors to the same image.
        public void Store(string fileName, ICompressorStrategy compressor, IFilterStrategy filter)
        {
            compressor.ApplyCompression(fileName);

            filter.ApplyFilter(fileName);

            Console.WriteLine($"Store image with name {fileName}.");
        }
    }
}
