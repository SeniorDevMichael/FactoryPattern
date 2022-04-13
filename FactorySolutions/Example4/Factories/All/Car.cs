using System;
using System.Collections.Generic;
using System.Text;

namespace Example4.Factories.All
{
    public class Car : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Car produced");
        }
    }
}
