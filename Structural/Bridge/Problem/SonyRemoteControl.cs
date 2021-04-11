using System;

namespace Bridge.Problem
{
    public class SonyRemoteControl : RemoteControl
    {
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
