namespace State.Exercise.End
{
    public class DirectionService
    {
        private ITravelMode currentTravelMode;

        public DirectionService(ITravelMode initialTravelMode)
        {
            currentTravelMode = initialTravelMode;
        }

        public void ChangeTravelMode(ITravelMode newTravelMode)
        {
            if (currentTravelMode.GetType() == newTravelMode.GetType()) return;

            currentTravelMode = newTravelMode;
        } 

        public int CalculateEstimatedTimeOfArrival()
        {
            return currentTravelMode.CalculateEstimatedTimeOfArrival();
        }

        public int CalculateDistance()
        {
            return currentTravelMode.CalculateDistance();
        }
    }
}
