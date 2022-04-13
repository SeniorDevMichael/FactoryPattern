using System;
using System.Collections.Generic;
using System.Text;

namespace Example2.Factories.All
{
    class Azercell : IProviderService
    {
        public void CheckTransaction()
        {
            Console.WriteLine("Azercell checked");
        }
    }
}
