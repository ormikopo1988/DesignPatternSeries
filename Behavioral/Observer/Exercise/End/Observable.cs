using System.Collections.Generic;

namespace Observer.Exercise.End
{
    public abstract class Observable
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Dettach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.PriceChanged();
            }
        }
    }
}
