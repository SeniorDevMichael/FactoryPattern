using Example2.Factories;
using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] factories = new string[] { "Abb", "Azercell", "KapitalBank" };

            foreach (var factory_name in factories)
            {
                IProviderService serviceFactory = CommonFactory.GetServiceFactory(factory_name);
                serviceFactory.CheckTransaction();
            }

            Console.ReadLine();
        }
    }
}
