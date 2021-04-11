using System;
using System.Collections.Generic;

namespace Composite.Solution
{
    public class Group : IComponent
    {
        private readonly List<IComponent> components = new List<IComponent>();
        private readonly string name;

        public Group(string name)
        {
            this.name = name;
        }

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Render()
        {
            Console.WriteLine($"Start rendering {name}: ");

            foreach (var component in components)
            {
                component.Render();
            }
        }
    }
}
