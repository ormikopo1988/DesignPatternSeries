using System;

namespace State.Exercise.Start
{
    /// <summary>
    /// This is the class that powers our mapping app. 
    /// It provides two methods for calculating the estimated time of arrival (ETA) and the direction between two points. 
    /// Identify the problems in this implementation. Then, refactor the code to use the state pattern. 
    /// What are the benefits of the new implementation?
    /// </summary>
    public class DirectionService
    {
        public TravelMode TravelMode { get; set; }

        public int CalculateEstimatedTimeOfArrival()
        {
            if (TravelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating Estimated Time of Arrival (driving)");
                return 1;
            }
            else if (TravelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating Estimated Time of Arrival (bicycling)");
                return 2;
            }
            else if (TravelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating Estimated Time of Arrival (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating Estimated Time of Arrival (walking)");
                return 4;
            }
        }

        public int CalculateDistance()
        {
            if (TravelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating Distance (driving)");
                return 1;
            }
            else if (TravelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating Distance (bicycling)");
                return 2;
            }
            else if (TravelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating Distance (transit)");
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating Distance (walking)");
                return 4;
            }
        }
    }
}
