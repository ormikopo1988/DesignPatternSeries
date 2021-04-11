using System;

namespace Bridge.Problem
{
    public class SonyAdvancedRemoteControl : AdvancedRemoteControl
    {
        public override void SetChannel(int channel)
        {
            Console.WriteLine("Set channel on Sony device.");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turn off Sony device.");
        }

        public override void TurnOn()
        {
            Console.WriteLine("Turn on Sony device.");
        }
    }
}
