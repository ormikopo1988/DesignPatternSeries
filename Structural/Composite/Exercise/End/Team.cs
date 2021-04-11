using System;
using System.Collections.Generic;

namespace Composite.Exercise.End
{
    public class Team : IComponent
    {
        private readonly List<IComponent> resources = new List<IComponent>();
        private readonly string name;

        public Team(string name)
        {
            this.name = name;
        }

        public void Add(IComponent resource)
        {
            resources.Add(resource);
        }

        public void Deploy()
        {
            Console.WriteLine($"Start deploying group with name {name}:");

            foreach(var resource in resources)
            {
                resource.Deploy();
            }
        }
    }
}
