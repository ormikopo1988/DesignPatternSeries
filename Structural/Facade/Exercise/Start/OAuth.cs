using System;

namespace Facade.Exercise.Start
{
    /// <summary>
    /// We’re building a social media management tool. 
    /// On a few screens, we need to display the recent tweets of a given user. 
    /// The steps required to talk to the Twitter API are:
    ///     - We need to get a request token first. 
    ///     - We’ll then exchange the request token with an access token. 
    ///     - To get the recent tweets, we need to send the access token to Twitter API.  
    /// We have to repeat similar steps for other operations such as composing a new tweet, liking a tweet, etc. 
    /// What are the problems with the current implementation? 
    /// Use the facade pattern to solve these problems. 
    /// </summary>
    public class OAuth
    {
        public string RequestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a request token");

            return "requestToken";
        }

        public string GetAccessToken(string requestToken)
        {
            Console.WriteLine("Get an access token");

            return "accessToken";
        }
    }
}
