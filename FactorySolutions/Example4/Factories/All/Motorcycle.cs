using System;
using System.Collections.Generic;
using System.Text;

namespace Example4.Factories.All
{
    public class Motorcycle : IVehicle
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Motorcycle produced");
        }
    }
}
