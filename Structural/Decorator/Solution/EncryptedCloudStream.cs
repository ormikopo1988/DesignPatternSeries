namespace Decorator.Solution
{
    public class EncryptedCloudStream : IStream
    {
        private readonly IStream innerStream;

        public EncryptedCloudStream(IStream innerStream)
        {
            this.innerStream = innerStream;
        }

        public void Write(string data)
        {
            var encryptedData = Encrypt(data);

            this.innerStream.Write(encryptedData);
        }

        private string Encrypt(string data)
        {
            return "!#$$#@##$$##$";
        }
    }
}
