using AbstractFactoryExample1.Factories;
using AbstractFactoryExample1.Factories.All;
using System;

namespace AbstractFactoryExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            // Create and run the African animal world
            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();

            Console.ReadLine();
        }
    }
}
