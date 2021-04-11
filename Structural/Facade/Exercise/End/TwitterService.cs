using System.Collections.Generic;

namespace Facade.Exercise.End
{
    public class TwitterService
    {
        private readonly string clientId;
        private readonly string clientSecret;

        public TwitterService(string clientId, string clientSecret)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
        }

        public List<Tweet> GetRecentTweets()
        {
            var twitterClient = new TwitterClient();

            return twitterClient.GetRecentTweets(GetAccessToken());
        }

        private string GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken(clientId, clientSecret);

            return oauth.GetAccessToken(requestToken);
        }
    }
}
