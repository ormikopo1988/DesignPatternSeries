using System;

namespace Builder
{
    /// <summary>
    /// Unlike other creational patterns, builder lets you construct
    /// products that don't follow a common interface.
    /// </summary>
    public class CarManualBuilder : IBuilder
    {
        private Manual manual;

        /// <summary>
        /// A fresh builder instance should contain a blank product
        /// object which it uses in further assembly.
        /// </summary>
        public CarManualBuilder()
        {
            Reset();
        }

        /// <summary>
        /// The reset method clears the object being built.
        /// </summary>
        public IBuilder Reset()
        {
            manual = new Manual();

            return this;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="engineType"></param>
        public IBuilder SetEngine(string engineType)
        {
            Console.WriteLine("Add engine instructions.");

            manual.EngineInstructions = $"Add engine {engineType} instructions.";

            return this;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="isEnabled"></param>
        public IBuilder SetGPS(bool isEnabled)
        {
            Console.WriteLine("Add GPS instructions.");

            if (isEnabled)
            {
                manual.GPSInstructions = "Add GPS instructions.";
            }
            else
            {
                manual.GPSInstructions = string.Empty;
            }

            return this;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="noOfSeats"></param>
        public IBuilder SetSeats(int noOfSeats)
        {
            Console.WriteLine("Document car seat features.");

            manual.SeatsInstructions = $"Document car seat features. Number of seats: {noOfSeats}";

            return this;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="noOfDoors"></param>
        /// <returns></returns>
        public IBuilder SetDoors(int noOfDoors)
        {
            Console.WriteLine("Document car door features.");

            manual.DoorsInstructions = $"Document car door features. Number of dpors: {noOfDoors}";

            return this;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="isEnabled"></param>
        public IBuilder SetTripComputer(bool isEnabled)
        {
            Console.WriteLine("Add trip computer instructions.");

            if (isEnabled)
            {
                manual.TripComputerInstructions = "Add trip computer instructions.";
            }
            else
            {
                manual.TripComputerInstructions = string.Empty;
            }

            return this;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="isEnabled"></param>
        public IBuilder SetVoiceRecognition(bool isEnabled)
        {
            Console.WriteLine("Add voice recognition instructions.");

            if (isEnabled)
            {
                manual.VoiceRecognitionInstructions = "Add voice recognition instructions.";
            }
            else
            {
                manual.VoiceRecognitionInstructions = string.Empty;
            }

            return this;
        }

        /// <summary>
        /// Concrete builders are supposed to provide their own
        /// methods for retrieving results. That's because various
        /// types of builders may create entirely different products
        /// that don't all follow the same interface. Therefore such
        /// methods can't be declared in the builder interface (at
        /// least not in a statically-typed programming language).
        /// Usually, after returning the end result to the client, a
        /// builder instance is expected to be ready to start
        /// producing another product. That's why it's a usual
        /// practice to call the Reset method at the end of the
        /// `GetProduct` method body. However, this behavior isn't
        /// mandatory, and you can make your builder wait for an
        /// explicit reset call from the client code before disposing
        /// of the previous result.
        /// </summary>
        /// <returns></returns>
        public Manual Build()
        {
            var result = manual;

            Reset();

            return result;
        }
    }
}
