using System;

namespace ChainOfResponsibility.Exercise.End
{
    public class QuickBookWorkbookFormatter : Handler
    {
        protected override bool DoHandle(string fileName)
        {
            if (fileName.EndsWith(".qbw"))
            {
                Console.WriteLine("Reading data from a QuickBooks file.");

                return true;
            }

            return false;
        }
    }
}
