using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Strategy.Exercise.End
{
    public class DesEncryptor : IEncryptionStrategy
    {
        public string Encrypt(string text)
        {
            Console.WriteLine($"Encrypting '{text}' using DES.");

            // Create a new DES object to generate a key
            // and initialization vector (IV).
            var desAlg = DES.Create();

            return EncryptDes(text, desAlg.Key, desAlg.IV);
        }

        private string EncryptDes(string data, byte[] key, byte[] iv)
        {
            // Create a MemoryStream.
            var mStream = new MemoryStream();

            // Create a new DES object.
            var desAlg = DES.Create();

            // Create a CryptoStream using the MemoryStream
            // and the passed key and initialization vector (IV).
            var cStream = new CryptoStream(mStream,
                desAlg.CreateEncryptor(key, iv),
                CryptoStreamMode.Write);

            // Convert the passed string to a byte array.
            var toEncrypt = new UTF8Encoding().GetBytes(data);

            // Write the byte array to the crypto stream and flush it.
            cStream.Write(toEncrypt, 0, toEncrypt.Length);
            cStream.FlushFinalBlock();

            // Get an array of bytes from the
            // MemoryStream that holds the
            // encrypted data.
            var encrypted = mStream.ToArray();

            // Close the streams.
            cStream.Close();
            mStream.Close();

            // Return the encrypted buffer.
            return Encoding.UTF8.GetString(encrypted);
        }
    }
}
