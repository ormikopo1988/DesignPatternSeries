using System;

namespace Observer.Solution.PushStyle
{
    public class SpreadSheet : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine($"SpreadSheet object notified about new value: {value}");
        }
    }
}
