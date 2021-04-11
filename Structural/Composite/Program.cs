using Composite.Exercise.End;
using Composite.Solution;
using System;

namespace Composite
{
    /// <summary>
    /// Also known as: Object Tree
    /// Composite is a structural design pattern that lets you compose
    /// objects into tree structures and then work with these
    /// structures as if they were individual objects.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var circle1 = new Shape("Circle1");
            var circle2 = new Shape("Circle2");
            var square1 = new Shape("Square1");
            var square2 = new Shape("Square2");

            var group1 = new Group("Group1");
            group1.Add(circle1);
            group1.Add(square1);

            var group2 = new Group("Group2");
            group2.Add(circle2);
            group2.Add(square2);

            var circle3 = new Shape("Circle3");
            var square3 = new Shape("Square3");

            group1.Render();
            group2.Render();
            circle3.Render();
            square3.Render();

            Console.WriteLine("--- Exercise ---");

            var truck1 = new Truck("Truck1");
            var truck2 = new Truck("Truck2");
            var humanResource1 = new HumanResource("Human1");
            var humanResource2 = new HumanResource("Human2");
            var humanResource3 = new HumanResource("Human3");
            var humanResource4 = new HumanResource("Human4");

            var subTeam1 = new Team("Subteam1");
            var subTeam2 = new Team("Subteam2");

            var teamToDeployForIncident = new Team("Team");

            subTeam1.Add(truck1);
            subTeam1.Add(humanResource1);
            subTeam1.Add(humanResource2);

            subTeam2.Add(truck2);
            subTeam2.Add(humanResource3);
            subTeam2.Add(humanResource4);

            teamToDeployForIncident.Add(subTeam1);
            teamToDeployForIncident.Add(subTeam2);

            teamToDeployForIncident.Deploy();

            Console.ReadLine();
        }
    }
}
