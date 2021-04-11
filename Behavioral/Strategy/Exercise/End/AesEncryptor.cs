using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Strategy.Exercise.End
{
    public class AesEncryptor : IEncryptionStrategy
    {
        public string Encrypt(string text)
        {
            Console.WriteLine($"Encrypting '{text}' using AES.");

            return EncryptAes(text);
        }

        private string EncryptAes(string raw)
        {
            // Create Aes that generates a new key and initialization vector (IV).    
            // Same key must be used in encryption and decryption    
            using (var aes = new AesManaged())
            {
                // Encrypt string    
                var encrypted = Encrypt(raw, aes.Key, aes.IV);

                return Encoding.UTF8.GetString(encrypted);
            }
        }

        private byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;

            // Create a new AesManaged.    
            using (var aes = new AesManaged())
            {
                // Create encryptor    
                var encryptor = aes.CreateEncryptor(Key, IV);

                // Create MemoryStream    
                using (var ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        
                        encrypted = ms.ToArray();
                    }
                }
            }

            // Return encrypted data    
            return encrypted;
        }
    }
}
