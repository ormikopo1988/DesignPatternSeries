namespace Facade.Solution
{
    public class NotificationService
    {
        public void Send(string message, string target)
        {
            var notificationServer = new NotificationServer();
            var connection = notificationServer.Connect("ip");
            var authToken = notificationServer.Authenticate("appId", "appKey");
            notificationServer.Send(authToken, new Message(message), target);
            connection.Disconnect();
        }
    }
}
