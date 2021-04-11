using System;

namespace State.Solution
{
    public class Selection : ICanvasTool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw dashed rectangle");
        }
    }
}
