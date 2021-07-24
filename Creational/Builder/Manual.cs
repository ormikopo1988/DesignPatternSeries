namespace Builder
{
    /// <summary>
    /// Using the Builder pattern makes sense only when your products
    /// are quite complex and require extensive configuration. The
    /// following two products (Car, Manual) are related, although they don't have
    /// a common interface.
    /// </summary>
    public class Manual
    {
        // Each car should have a user manual that corresponds to
        // the car's configuration and describes all its features.
        public string EngineInstructions { get; set; }
        public string SeatsInstructions { get; set; }
        public string DoorsInstructions { get; set; }
        public string GPSInstructions { get; set; }
        public string TripComputerInstructions { get; set; }
        public string VoiceRecognitionInstructions { get; set; }
    }
}
