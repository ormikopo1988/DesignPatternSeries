using System;

namespace AbstractFactory
{
    /// <summary>
    /// Concrete products are created by corresponding concrete
    /// factories.
    /// </summary>
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Render a button in MacOS style.");
        }
    }
}
