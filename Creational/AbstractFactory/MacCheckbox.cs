using System;

namespace AbstractFactory
{
    /// <summary>
    /// Concrete products are created by corresponding concrete
    /// factories.
    /// </summary>
    public class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Render a checkbox in MacOS style.");
        }
    }
}
