using System;

namespace Composite.Exercise.Start
{
    public class HumanResource
    {
        private readonly string name;

        public HumanResource(string name)
        {
            this.name = name;
        }

        public void Deploy()
        {
            Console.WriteLine($"Deploying a human resource with name {name}");
        }
    }
}
