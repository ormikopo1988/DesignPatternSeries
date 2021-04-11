using Command.Solution.Framework;
using System;

namespace Command.Solution.CompositeCommands
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }
}
