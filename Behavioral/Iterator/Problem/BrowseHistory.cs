using System.Collections.Generic;

namespace Iterator.Problem
{
    public class BrowseHistory
    {
        /// <summary>
        /// If we expose the internals of the data structure we are using to the outside world,
        /// we will face a problem in the future if we decide to change the structure we are using
        /// for storing the urls. Our clients that use the Stack here to iterate over the things 
        /// inside the Urls collection will break if we change the data structure. The way the clients
        /// of this class would iterate over its elements should not be directly dependent on the
        /// internals of the data structure the BrowseHistory is using to store its elements.
        /// Changing the internals of this object should not affect its consumer.
        /// </summary>
        public Stack<string> Urls { get; private set; } = new Stack<string>();

        public void Push(string url)
        {
            Urls.Push(url);
        }

        public string Pop()
        {
            return Urls.Pop();
        }
    }
}
