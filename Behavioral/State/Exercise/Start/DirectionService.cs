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

        public object GetEta()
        {
            if (TravelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating ETA (driving)");

                return 1;
            }
            else if (TravelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating ETA (bicycling)");
                
                return 2;
            }
            else if (TravelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating ETA (transit)");
                
                return 3;
            }
            else
            {
                Console.WriteLine("Calculating ETA (walking)");
                
                return 4;
            }
        }

        public object GetDirection()
        {
            if (TravelMode == TravelMode.DRIVING)
            {
                Console.WriteLine("Calculating Direction (driving)");

                return 1;
            }
            else if (TravelMode == TravelMode.BICYCLING)
            {
                Console.WriteLine("Calculating Direction (bicycling)");

                return 2;
            }
            else if (TravelMode == TravelMode.TRANSIT)
            {
                Console.WriteLine("Calculating Direction (transit)");

                return 3;
            }
            else
            {
                Console.WriteLine("Calculating Direction (walking)");

                return 4;
            }
        }
    }
}
