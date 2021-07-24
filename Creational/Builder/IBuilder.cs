namespace Builder
{
    /// <summary>
    /// The builder interface specifies methods for creating the
    /// different parts of the product objects.
    /// </summary>
    public interface IBuilder
    {
        IBuilder Reset();
        IBuilder SetSeats(int noOfSeats);
        IBuilder SetDoors(int noOfDoors);
        IBuilder SetEngine(string engineType);
        IBuilder SetTripComputer(bool isEnabled);
        IBuilder SetGPS(bool isEnabled);
        IBuilder SetVoiceRecognition(bool isEnabled);
    }
}
