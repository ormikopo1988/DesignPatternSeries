using System.Collections.Generic;

namespace Composite.Exercise.Start
{
    /// <summary>
    /// We’re building an application for an incident management organization. 
    /// When an incident (eg fire) occurs, one or more teams may be deployed to attack the incident. 
    /// A team often includes a truck and one or more human resources. 
    /// It can also include a sub team. 
    /// For example, for a medium-sized incident, we may need to deploy two teams and each team may contain a truck and two persons. 
    /// -Team
    ///     - Sub Team 1
    ///         - Truck 
    ///         - Human Resource
    ///         - Human Resource
    ///     - Sub Team 2
    ///         - Truck
    ///         - Human Resource
    ///         - Human Resource  
    /// What are the problems with this implementation? Refactor the code using the composite pattern.
    /// </summary>
    public class Team
    {
        private readonly List<object> resources = new List<object>();

        public void Add(object resource)
        {
            resources.Add(resource);
        }

        public void Deploy()
        {
            foreach(var resource in resources)
            {
                if (resource is Truck)
                {
                    ((Truck)resource).Deploy();
                }
                else if (resource is HumanResource)
                {
                    ((HumanResource)resource).Deploy();
                }
                else
                {
                    ((Team)resource).Deploy();
                }
            }
        }
    }
}
