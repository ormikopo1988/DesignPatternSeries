using Facade.Exercise.End;
using Facade.Solution;
using System;

namespace Facade
{
    /// <summary>
    /// Facade is a structural design pattern that provides a simplified
    /// interface to a library, a framework, or any other complex set
    /// of classes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Problem - Send a message as a push notification to a user device
            var server = new Problem.NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Authenticate("appId", "appKey");
            var message = new Problem.Message("Hello World!");
            server.Send(authToken, message, "targetDevice");
            connection.Disconnect();

            // Solution - Using the Facade pattern
            var notificationService = new NotificationService();
            notificationService.Send("Hello World!", "targetDevice");

            Console.WriteLine("--- Exercise ---");

            var twitterService = new TwitterService("clientId", "clientSecret");
            var recentTweets = twitterService.GetRecentTweets();

            foreach (var tweet in recentTweets)
            {
                Console.WriteLine(tweet.Message);
            }

            Console.ReadLine();
        }
    }
}
