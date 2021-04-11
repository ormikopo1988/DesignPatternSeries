using System;
using TemplateMethod.Exercise.End;
using TemplateMethod.Solution;

namespace TemplateMethod
{
    /// <summary>
    /// Template Method is a behavioral design pattern that defines
    /// the skeleton of an algorithm in the superclass but lets
    /// subclasses override specific steps of the algorithm without
    /// changing its structure.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var auditTrail = new AuditTrail();

            var generateReportTask = new GenerateReportTask(auditTrail);
            generateReportTask.Execute();

            var transferMoneyTask = new TransferMoneyTask(auditTrail);
            transferMoneyTask.Execute();

            Console.WriteLine("--- Exercise ---");

            var chatWindow = new ChatWindow();
            chatWindow.Close();

            Console.ReadLine();
        }
    }
}
