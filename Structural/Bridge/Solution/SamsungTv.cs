using System;

namespace Bridge.Solution
{
    public class SamsungTv : IDevice
    {
        public void SetChannel(int number)
        {
            Console.WriteLine($"Set channel to {number} on Samsung TV.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Turn off Samsung TV.");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turn on Samsung TV.");
        }
    }
}
