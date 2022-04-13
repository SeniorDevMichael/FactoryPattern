using System;
using System.Collections.Generic;
using System.Text;

namespace Example5.Factories.All
{
    public class Apple : IMobilePhone
    {
        public void DisplayInfo()
        {
            Console.WriteLine("Apple");
        }
    }
}
