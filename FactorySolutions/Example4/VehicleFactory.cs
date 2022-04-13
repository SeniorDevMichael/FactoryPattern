using Example4.Factories;
using Example4.Factories.All;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example4
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle ProduceVehicle(VehicleType type)
        {
            IVehicle vehicle = null;

            switch (type)
            {
                case VehicleType.Car:
                    vehicle = new Car();
                    break;
                case VehicleType.Truck:
                    vehicle = new Truck();
                    break;
                case VehicleType.Motorcycle:
                    vehicle = new Motorcycle();
                    break;
            }

            return vehicle;
        }
    }
}
