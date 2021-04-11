namespace Decorator.Problem
{
    public class CompressedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            var compressedData = Compress(data);

            base.Write(compressedData);
        }

        private string Compress(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
