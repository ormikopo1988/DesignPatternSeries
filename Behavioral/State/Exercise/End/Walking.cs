using System;

namespace State.Exercise.End
{
    public class Walking : ITravelMode
    {
        public int CalculateEstimatedTimeOfArrival()
        {
            Console.WriteLine("Calculating Estimated Time of Arrival (walking)");

            return 4;
        }

        public int CalculateDistance()
        {
            Console.WriteLine("Calculating Direction (walking)");

            return 4;
        }
    }
}
