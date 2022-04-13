using Example3.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example3
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string vehicle);
    }
}