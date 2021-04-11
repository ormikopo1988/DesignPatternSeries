using System;

namespace State.Problem
{
    public class Canvas
    {
        public ToolType CurrentTool { get; set; }

        public void MouseDown()
        {
            if (CurrentTool == ToolType.SELECTION)
            {
                Console.WriteLine("Selection icon.");
            }
            else if (CurrentTool == ToolType.BRUSH)
            {
                Console.WriteLine("Brush icon.");
            }
            else if (CurrentTool == ToolType.ERASER)
            {
                Console.WriteLine("Eraser icon.");
            }
        }

        public void MouseUp()
        {
            if (CurrentTool == ToolType.SELECTION)
            {
                Console.WriteLine("Draw dashed rectangle.");
            }
            else if (CurrentTool == ToolType.BRUSH)
            {
                Console.WriteLine("Draw a line.");
            }
            else if (CurrentTool == ToolType.ERASER)
            {
                Console.WriteLine("Erase something.");
            }
        }
    }
}
