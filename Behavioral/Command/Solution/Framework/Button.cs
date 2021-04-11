using System;

namespace Command.Solution.Framework
{
    public class Button
    {
        public string Label { get; set; }
        private readonly ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public void Click()
        {
            Console.WriteLine("Button clicked. About to delegate work to the ICommand implementation object.");

            command.Execute();
        }
    }
}
