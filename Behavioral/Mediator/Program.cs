using Mediator.Exercise.End;
using Mediator.Solution;
using System;

namespace Mediator
{
    /// <summary>
    /// Also known as: Intermediary, Controller
    /// Mediator is a behavioral design pattern that lets you reduce
    /// chaotic dependencies between objects. The pattern restricts
    /// direct communications between the objects and forces them
    /// to collaborate only via a mediator object.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var articlesDialogBox = new ArticlesDialogBox();
            articlesDialogBox.SimulateUserInteraction();

            var articlesDialogBoxUsingObserver = new Solution.UsingObserver.ArticlesDialogBox();
            articlesDialogBoxUsingObserver.SimulateUserInteraction();

            Console.WriteLine("--- Exercise ---");

            var signUpDialogBox = new SignUpDialogBox();
            signUpDialogBox.SimulateUserInteraction();

            Console.ReadLine();
        }
    }
}
