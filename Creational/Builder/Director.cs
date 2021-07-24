namespace Builder
{
    /// <summary>
    /// The director is only responsible for executing the building
    /// steps in a particular sequence. It's helpful when producing
    /// products according to a specific order or configuration.
    /// Strictly speaking, the director class is optional, since the
    /// client can control builders directly.
    /// </summary>
    public class Director
    {
        private IBuilder builder;

        /// <summary>
        /// The director works with any builder instance that the
        /// client code passes to it. This way, the client code may
        /// alter the final type of the newly assembled product.
        /// </summary>
        /// <param name="builder"></param>
        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }

        /// <summary>
        /// The director can construct several product variations
        /// using the same building steps.
        /// </summary>
        public void ConstructSportsCar()
        {
            builder
                .Reset()
                .SetSeats(2)
                .SetDoors(2)
                .SetEngine("sports-engine")
                .SetTripComputer(true)
                .SetGPS(true);
        }

        /// <summary>
        /// The director can construct several product variations
        /// using the same building steps.
        /// </summary>
        public void ConstructSUV()
        {
            builder
                .Reset()
                .SetSeats(4)
                .SetDoors(4)
                .SetEngine("suv-engine")
                .SetGPS(true)
                .SetVoiceRecognition(true);
        }
    }
}
