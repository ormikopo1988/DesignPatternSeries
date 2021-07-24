using System;

namespace Builder
{
    /// <summary>
    /// Builder is a creational design pattern that lets you construct
    /// complex objects step by step. The pattern allows you to
    /// produce different types and representations of an object using
    /// the same construction code.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The client code creates a builder object, passes it to the
        /// director and then initiates the construction process. The end
        /// result is retrieved from the builder object.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var director = new Director();

            var carBuilder = new CarBuilder();
            director.SetBuilder(carBuilder);
            director.ConstructSportsCar();
            //director.ConstructSUV();

            // The final product is often retrieved from a builder
            // object since the director isn't aware of and not
            // dependent on concrete builders and products.
            var car = carBuilder.Build();

            Console.WriteLine("Constructed car with:");
            Console.WriteLine($"Number of seats => {car.NumberOfSeats}");
            Console.WriteLine($"Number of doors => {car.NumberOfDoors}");
            Console.WriteLine($"Engine type => {car.EngineType}");
            Console.WriteLine($"Has trip computer => {car.HasTripComputer}");
            Console.WriteLine($"Has GPS => {car.HasGPS}");
            Console.WriteLine($"Has voice recognition => {car.HasVoiceRecognition}");

            var carManualBuilder = new CarManualBuilder();
            director.SetBuilder(carManualBuilder);
            director.ConstructSportsCar();
            //director.ConstructSUV();

            var manual = carManualBuilder.Build();

            Console.WriteLine("Constructed manual with:");
            Console.WriteLine($"Seats instructions => {manual.SeatsInstructions}");
            Console.WriteLine($"Doors instructions => {manual.DoorsInstructions}");
            Console.WriteLine($"Engine type instructions => {manual.EngineInstructions}");
            Console.WriteLine($"Trip computer instructions => {manual.TripComputerInstructions ?? "No instructions."}");
            Console.WriteLine($"GPS instructions => {manual.GPSInstructions ?? "No instructions."}");
            Console.WriteLine($"Voice recognition instructions => {manual.VoiceRecognitionInstructions ?? "No instructions."}");

            Console.ReadLine();
        }
    }
}
