using System;

namespace Facade.Problem
{
    /// <summary>
    /// This class contains the necessary steps we need in order to send a message as a push notification to mobile devices.
    /// </summary>
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
