using Bridge.Solution;
using System;

namespace Bridge
{
    /// <summary>
    /// Bridge is a structural design pattern that lets you split a large
    /// class or a set of closely related classes into two separate
    /// hierarchies — abstraction and implementation — which can be
    /// developed independently of each other.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl1 = new RemoteControl(new SamsungTv());
            remoteControl1.TurnOn();
            remoteControl1.TurnOff();

            var remoteControl2 = new AdvancedRemoteControl(new SonyTv());
            remoteControl2.TurnOn();
            remoteControl2.SetChannel(2);
            remoteControl2.TurnOff();

            Console.ReadLine();
        }
    }
}
