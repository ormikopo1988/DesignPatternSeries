using System;

namespace State.Solution
{
    public class Brush : ICanvasTool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
