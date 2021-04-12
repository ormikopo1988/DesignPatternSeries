using System;

namespace FactoryMethod
{
    /// <summary>
    /// Concrete products provide various implementations of the
    /// product interface.
    /// </summary>
    public class HTMLButton : IButton
    {
        public void OnClick(string eventName)
        {
            Console.WriteLine($"Bind a web browser click event with name {eventName}");
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Rendering a button at ({x}, {y}) in HTML representation style.");
        }
    }
}
