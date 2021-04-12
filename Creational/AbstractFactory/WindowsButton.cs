using System;

namespace AbstractFactory
{
    /// <summary>
    /// Concrete products are created by corresponding concrete
    /// factories.
    /// </summary>
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Render a button in Windows style.");
        }
    }
}
