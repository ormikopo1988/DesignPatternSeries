using System;

namespace Bridge.Solution
{
    public class SonyTv : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine($"Set channel to {number} on Sony TV.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off Sony TV.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn on Sony TV.");
        }
    }
}
