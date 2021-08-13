using System;

namespace State.Exercise.End
{
    public class Bicycling : ITravelMode
    {
        public int CalculateEstimatedTimeOfArrival()
        {
            Console.WriteLine("Calculating Estimated Time of Arrival (bicycling)");

            return 2;
        }

        public int CalculateDistance()
        {
            Console.WriteLine("Calculating Direction (bicycling)");

            return 2;
        }
    }
}
