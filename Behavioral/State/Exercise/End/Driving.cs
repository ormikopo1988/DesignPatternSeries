using System;

namespace State.Exercise.End
{
    public class Driving : ITravelMode
    {
        public object GetDirection()
        {
            Console.WriteLine("Calculating ETA (driving)");

            return 1;
        }

        public object GetEta()
        {
            Console.WriteLine("Calculating Direction (driving)");

            return 1;
        }
    }
}
