using System;
using System.Collections.Generic;

namespace Facade.Exercise.Start
{
    public class TwitterClient
    {
        public List<Tweet> GetRecentTweets(string accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return new List<Tweet> { new Tweet("Hello Twitter!") };
        }
    }
}
