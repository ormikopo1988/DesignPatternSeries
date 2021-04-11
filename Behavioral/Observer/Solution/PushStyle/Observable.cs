using System.Collections.Generic;

namespace Observer.Solution.PushStyle
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

        public void Notify(int value)
        {
            foreach (var observer in observers)
            {
                observer.Update(value);
            }
        }
    }
}
