using System;

namespace Builder
{
    /// <summary>
    /// The concrete builder classes follow the builder interface and
    /// provide specific implementations of the building steps. Your
    /// program may have several variations of builders, each
    /// implemented differently.
    /// </summary>
    public class CarBuilder : IBuilder
    {
        private Car car;

        /// <summary>
        /// A fresh builder instance should contain a blank product
        /// object which it uses in further assembly.
        /// </summary>
        public CarBuilder()
        {
            Reset();
        }

        /// <summary>
        /// The reset method clears the object being built.
        /// </summary>
        public void Reset()
        {
            car = new Car();
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="engineType"></param>
        public void SetEngine(string engineType)
        {
            Console.WriteLine("Install a given engine.");

            car.EngineType = engineType;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="isEnabled"></param>
        public void SetGPS(bool isEnabled)
        {
            Console.WriteLine("Install a GPS.");

            car.HasGPS = isEnabled;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="noOfSeats"></param>
        public void SetSeats(int noOfSeats)
        {
            Console.WriteLine("Set the number of seats in the car.");

            car.NumberOfSeats = noOfSeats;
        }

        /// <summary>
        /// All production steps work with the same product instance.
        /// </summary>
        /// <param name="isEnabled"></param>
        public void SetTripComputer(bool isEnabled)
        {
            Console.WriteLine("Install a trip computer.");

            car.HasTripComputer = isEnabled;
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
        public Car Build()
        {
            var result = car;

            Reset();
            
            return result;
        }
    }
}
