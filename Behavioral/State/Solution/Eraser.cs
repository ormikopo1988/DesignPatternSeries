using System;

namespace State.Solution
{
    public class Eraser : ICanvasTool
    {
        public void MouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
