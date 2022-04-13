using System;
using System.Collections.Generic;
using System.Text;

namespace Example2.Factories.All
{
    class KapitalBank : IProviderService
    {
        public void CheckTransaction()
        {
            Console.WriteLine("KapitalBank checked");
        }
    }
}
