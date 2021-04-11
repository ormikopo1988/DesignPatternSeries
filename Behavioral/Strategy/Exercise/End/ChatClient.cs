using System;

namespace Strategy.Exercise.End
{
    public class ChatClient
    {
        private readonly IEncryptionStrategy encryptionAlgorithm;

        public ChatClient(IEncryptionStrategy encryptionAlgorithm)
        {
            this.encryptionAlgorithm = encryptionAlgorithm;
        }

        public void Send(string message)
        {
            var encryptedMessage = encryptionAlgorithm.Encrypt(message);

            Console.WriteLine($"Sending the encrypted message: {encryptedMessage}.");
        }
    }
}
