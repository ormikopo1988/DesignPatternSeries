using Command.Solution.Framework;
using System;

namespace Command.Solution.CompositeCommands
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Black and white");
        }
    }
}
