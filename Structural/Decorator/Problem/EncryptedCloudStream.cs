namespace Decorator.Problem
{
    public class EncryptedCloudStream : CloudStream
    {
        public override void Write(string data)
        {
            var encryptedData = Encrypt(data);

            base.Write(encryptedData);
        }

        private string Encrypt(string data)
        {
            return "!#$$#@##$$##$";
        }
    }
}
