using Command.Exercise.End;
using Command.Solution;
using Command.Solution.CompositeCommands;
using Command.Solution.Framework;
using Command.Solution.UndoableCommands;
using System;

namespace Command
{
    /// <summary>
    /// Also known as: Action, Transaction
    /// Command is a behavioral design pattern that turns a request
    /// into a stand-alone object that contains all information about
    /// the request. This transformation lets you parameterize
    /// methods with different requests, delay or queue a request’s
    /// execution, and support undoable operations.
    /// Difference between the Command and the Memento pattern in regard to undoable operations:
    /// With the Memento pattern, we store the changes in the state of an object, so we store multiple snapshots over time.
    /// Sometimes storing all those snapshots in the object's state can potentially be an expensive operation (e.g wasting videos inside a video editor app
    /// in snapshots in the object's state is going to waste a lot of memory.
    /// In those situations it is better to use the Command pattern, because every command knows how to undo itself, so we do not have to
    /// store multiple snapshots of an object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var addCustomerCommand = new AddCustomerCommand(new CustomerService());
            var button = new Button(addCustomerCommand);

            button.Click();

            // Because we are representing each individual task using a command object, 
            // we can combine these commands inside a composite object and re-execute them later on.
            var compositeCommand = new CompositeCommand();
            compositeCommand.Add(new ResizeCommand());
            compositeCommand.Add(new BlackAndWhiteCommand());

            compositeCommand.Execute();

            var history = new Solution.UndoableCommands.History();
            var htmlDocument = new HtmlDocument();
            htmlDocument.Content = "Hello World!";

            var boldCommand = new BoldCommand(htmlDocument, history);
            boldCommand.Execute();

            Console.WriteLine(htmlDocument.Content);

            //boldCommand.Unexecute();
            var undoCommand = new Solution.UndoableCommands.UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(htmlDocument.Content);

            Console.WriteLine("--- Exercise ---");

            var exeHistory = new Exercise.End.History();
            var videoEditor = new VideoEditor();

            var setTextCommand = new SetTextCommand("Hello World!", videoEditor, exeHistory);
            setTextCommand.Execute();

            Console.WriteLine(videoEditor.Text);

            //setTextCommand.Undo();
            var exeUndoCommand = new Exercise.End.UndoCommand(exeHistory);
            exeUndoCommand.Execute();

            Console.WriteLine(videoEditor.Text);

            Console.ReadLine();
        }
    }
}
