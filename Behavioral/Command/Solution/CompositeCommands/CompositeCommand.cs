using Command.Solution.Framework;
using System.Collections.Generic;

namespace Command.Solution.CompositeCommands
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> commands = new List<ICommand>();

        public void Add(ICommand command)
        {
            commands.Add(command);
        }

        public void Execute()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
        }
    }
}
