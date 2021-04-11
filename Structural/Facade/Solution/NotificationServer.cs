using System;

namespace Facade.Solution
{
    public class NotificationServer
    {
        public Connection Connect(string ipAddressOfNotificationServer)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string appId, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken, Message message, string targetDevice)
        {
            Console.WriteLine("Sending a message as push notification.");
        }
    }
}
