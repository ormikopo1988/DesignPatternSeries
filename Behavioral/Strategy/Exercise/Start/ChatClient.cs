using System;

namespace Strategy.Exercise.Start
{
    /// <summary>
    /// This class uses an encryption algorithm to encrypt a message before sending it out.  
    /// What are the problems in this implementation? Refactor the code using the strategy pattern. 
    /// What are the benefits of the new implementation?  
    /// </summary>
    public class ChatClient
    {
        private readonly string encryptionAlgorithm;

        public ChatClient(string encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;
        }

        public void Send(string message)
        {
            if (encryptionAlgorithm == "DES")
            {
                Console.WriteLine($"Encrypting '{message}' using DES.");
            }
            else if (encryptionAlgorithm == "AES")
            {
                Console.WriteLine($"Encrypting '{message}' using AES.");
            }
            else
            {
                throw new InvalidOperationException("Unsupported encryption algorithm");
            }

            Console.WriteLine($"Sending the encrypted message: {message}.");
        }
    }
}
