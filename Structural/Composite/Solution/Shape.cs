using System;

namespace Composite.Solution
{
    public class Shape : IComponent
    {
        private readonly string name;

        public Shape(string name)
        {
            this.name = name;
        }

        public void Render()
        {
            Console.WriteLine($"Rendering {name}.");
        }
    }
}
