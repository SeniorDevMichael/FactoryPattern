using System;
using System.Collections.Generic;
using System.Text;

namespace Example2.Factories.All
{
    public class Abb : IProviderService
    {
        public void CheckTransaction()
        {
            Console.WriteLine("ABB checked");
        }
    }
}
