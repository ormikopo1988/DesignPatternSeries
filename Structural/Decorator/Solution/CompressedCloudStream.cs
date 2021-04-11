namespace Decorator.Solution
{
    public class CompressedCloudStream : IStream
    {
        private readonly IStream innerStream;

        public CompressedCloudStream(IStream innerStream)
        {
            this.innerStream = innerStream;
        }

        public void Write(string data)
        {
            var compressedData = Compress(data);

            innerStream.Write(compressedData);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
