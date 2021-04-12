namespace Builder
{
    /// <summary>
    /// Using the Builder pattern makes sense only when your products
    /// are quite complex and require extensive configuration. The
    /// following two products (Car, Manual) are related, although they don't have
    /// a common interface.
    /// </summary>
    public class Car
    {
        // A car can have a GPS, trip computer and some number of
        // seats. Different models of cars (sports car, SUV,
        // cabriolet) might have different features installed or
        // enabled.
        public string EngineType { get; set; }
        public int NumberOfSeats { get; set; }
        public bool HasGPS { get; set; }
        public bool HasTripComputer { get; set; }
    }
}
