using AbstractFactoryExample1.Animals.Carnivores;
using AbstractFactoryExample1.Animals.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample1.Factories.All
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() //Etyeyen - Şir
        {
            return new Lion();//Şir
        }

        public override Herbivore CreateHerbivore() //Otyeyen - Maral
        {
            return new Deer();//Maral
        }
    }
}
