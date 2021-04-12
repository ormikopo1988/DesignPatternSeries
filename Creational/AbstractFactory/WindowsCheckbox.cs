using System;

namespace AbstractFactory
{
    /// <summary>
    /// Concrete products are created by corresponding concrete
    /// factories.
    /// </summary>
    public class WindowsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Render a checkbox in Windows style.");
        }
    }
}
