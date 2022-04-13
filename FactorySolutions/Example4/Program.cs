using Example4.Factories;
using System;

namespace Example4
{
    class Program
    {
        static void Main(string[] args)
        {
            var vechicleFactory = new VehicleFactory();

            IVehicle vehicleCar = vechicleFactory.ProduceVehicle(VehicleType.Car);
            vehicleCar.DisplayInfo();

            IVehicle vehicleMotorcycle = vechicleFactory.ProduceVehicle(VehicleType.Motorcycle);
            vehicleMotorcycle.DisplayInfo();

            Console.ReadLine();
        }
    }
}
