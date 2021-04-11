using System;

namespace Composite.Exercise.End
{
    public class Truck : IComponent
    {
        private readonly string name;

        public Truck(string name)
        {
            this.name = name;
        }

        public void Deploy()
        {
            Console.WriteLine($"Deploying a truck with name {name}");
        }
    }
}
