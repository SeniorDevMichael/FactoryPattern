using Example4.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example4
{
    public interface IVehicleFactory
    {
        IVehicle ProduceVehicle(VehicleType type);
    }

    public enum VehicleType
    {
        Car = 1,
        Truck = 2,
        Motorcycle = 3
    }
}
