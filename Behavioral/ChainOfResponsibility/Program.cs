using ChainOfResponsibility.Exercise.End;
using ChainOfResponsibility.Solution;
using System;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Also known as: CoR, Chain of Command
    /// Chain of Responsibility is a behavioral design pattern that lets
    /// you pass requests along a chain of handlers. Upon receiving a
    /// request, each handler decides either to process the request or
    /// to pass it to the next handler in the chain.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var webServer = new WebServer(new Authenticator(new Logger(new Compressor(null))));

            webServer.Handle(new HttpRequest("admin", "1234"));
            webServer.Handle(new HttpRequest("admin", "1235"));

            Console.WriteLine("--- Exercise ---");

            var excelFormatter = new WindowsExcelFormatter();
            var numberFormatter = new MacNumberFormatter();
            var quickBookFormatter = new QuickBookWorkbookFormatter();

            excelFormatter.SetNext(numberFormatter);
            numberFormatter.SetNext(quickBookFormatter);

            var dataReader = new DataReader(excelFormatter);
            
            dataReader.Read("test.xls");
            dataReader.Read("test.numbers");
            dataReader.Read("test.qbw");
            try
            {
                dataReader.Read("test.docx");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
