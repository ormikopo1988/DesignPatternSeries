using System;

namespace State.Exercise.End
{
    public class Driving : ITravelMode
    {
        public int CalculateEstimatedTimeOfArrival()
        {
            Console.WriteLine("Calculating Estimated Time of Arrival (driving)");

            return 1;
        }

        public int CalculateDistance()
        {
            Console.WriteLine("Calculating Direction (driving)");

            return 1;
        }
    }
}
