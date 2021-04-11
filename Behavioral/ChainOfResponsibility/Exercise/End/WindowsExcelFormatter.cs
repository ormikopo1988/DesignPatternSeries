using System;

namespace ChainOfResponsibility.Exercise.End
{
    public class WindowsExcelFormatter : Handler
    {
        protected override bool DoHandle(string fileName)
        {
            if (fileName.EndsWith(".xls"))
            {
                Console.WriteLine("Reading data from an Excel spreadsheet.");

                return true;
            }

            return false;
        }
    }
}
