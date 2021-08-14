using System.Collections.Generic;

namespace Iterator.Solution
{
    public class BrowseHistory<T> : IIterableCollection<T>
    {
        private readonly List<T> urls = new List<T>();
        public void Push(T url) => urls.Add(url);

        public T Pop()
        {
            var lastIndex = urls.Count - 1;
            var lastUrl = urls[lastIndex];
            urls.RemoveAt(lastIndex);
            return lastUrl;
        }

        public IElementIterator<T> CreateIterator() => new ListIterator(this);

        public class ListIterator : IElementIterator<T>
        {
            private readonly BrowseHistory<T> browseHistory;
            private int currentIndex;

            public ListIterator(BrowseHistory<T> browseHistory) => this.browseHistory = browseHistory;

            public T Current() => browseHistory.urls[currentIndex];

            public bool HasNext() => currentIndex < browseHistory.urls.Count;

            public void Next() => currentIndex++;
        }
    }

    //public class BrowseHistory<T> : IIterableCollection<T>
    //{
    //    private readonly Queue<T> urls = new Queue<T>();

    //    public void Push(T url) => urls.Enqueue(url);

    //    public T Pop() => urls.Dequeue();

    //    public IElementIterator<T> CreateIterator() => new QueueIterator(this);

    //    public class QueueIterator : IElementIterator<T>
    //    {
    //        private readonly BrowseHistory<T> browseHistory;

    //        public QueueIterator(BrowseHistory<T> browseHistory) => this.browseHistory = browseHistory;

    //        public T Current() => browseHistory.urls.Peek();

    //        public bool HasNext() => browseHistory.urls.Count > 0;

    //        public void Next() => browseHistory.urls.Dequeue();
    //    }
    //}
}
