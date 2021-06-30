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
        public void Reset()
        {
            manual = new Manual();
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="engineType"></param>
        public void SetEngine(string engineType)
        {
            Console.WriteLine("Add engine instructions.");

            manual.EngineInstructions = $"Add engine {engineType} instructions.";
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="isEnabled"></param>
        public void SetGPS(bool isEnabled)
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
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="noOfSeats"></param>
        public void SetSeats(int noOfSeats)
        {
            Console.WriteLine("Document car seat features.");

            manual.SeatsInstructions = $"Document car seat features. Number of seats: {noOfSeats}";
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="isEnabled"></param>
        public void SetTripComputer(bool isEnabled)
        {
            Console.WriteLine("Add trip computer instructions.");

            if (isEnabled)
            {
                manual.GPSInstructions = "Add trip computer instructions.";
            }
            else
            {
                manual.GPSInstructions = string.Empty;
            }
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
