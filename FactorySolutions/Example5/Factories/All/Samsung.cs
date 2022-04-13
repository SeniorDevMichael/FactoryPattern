using System;
using System.Collections.Generic;
using System.Text;

namespace Example5.Factories.All
{
    public class Samsung : IMobilePhone
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Samsung");
        }
    }
}
