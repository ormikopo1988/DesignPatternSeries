namespace Builder
{
    /// <summary>
    /// The builder interface specifies methods for creating the
    /// different parts of the product objects.
    /// </summary>
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int noOfSeats);
        void SetEngine(string engineType);
        void SetTripComputer(bool isEnabled);
        void SetGPS(bool isEnabled);
    }
}
