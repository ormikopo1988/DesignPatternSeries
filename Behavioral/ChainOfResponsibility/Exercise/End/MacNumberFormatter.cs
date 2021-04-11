using System;

namespace ChainOfResponsibility.Exercise.End
{
    public class MacNumberFormatter : Handler
    {
        protected override bool DoHandle(string fileName)
        {
            if (fileName.EndsWith(".numbers"))
            {
                Console.WriteLine("Reading data from a Numbers spreadsheet.");

                return true;
            }

            return false;
        }
    }
}
