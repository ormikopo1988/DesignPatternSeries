using System;

namespace Observer.Solution.PushStyle
{
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"Chart object notified about new value: {value}");
        }
    }
}
