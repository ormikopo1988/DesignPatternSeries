using Memento.Exercise.End;
using Memento.Solution;
using System;

namespace Memento
{
    /// <summary>
    /// Also known as: Snapshot
    /// Memento is a behavioral design pattern that lets you save and
    /// restore the previous state of an object without revealing the
    /// details of its implementation.
    /// We use the Memento pattern for implementing undo mechanisms.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new Solution.History();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());
            
            editor.Content = "c";
            
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

            Console.WriteLine("--- Exercise ---");

            var document = new Document();
            var docHistory = new Exercise.End.History();

            document.Content = "a";
            document.FontName = "f1";
            document.FontSize = 1;
            docHistory.Push(document.CreateState());

            document.Content = "b";
            document.FontName = "f2";
            document.FontSize = 2;
            docHistory.Push(document.CreateState());

            document.Content = "c";
            document.FontName = "f3";
            document.FontSize = 3;

            document.Restore(docHistory.Pop());
            Console.WriteLine(document);
            document.Restore(docHistory.Pop());
            Console.WriteLine(document);

            Console.ReadLine();
        }
    }
}
