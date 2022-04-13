using AbstractFactoryExample1.Animals.Carnivores;
using AbstractFactoryExample1.Animals.Herbivores;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample1.Factories.All
{
    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore() //etyeyen - Qurd
        {
            return new Wolf();//Qurd
        }

        public override Herbivore CreateHerbivore() //otyeyen - Bizon
        {
            return new Bison();//Bizon
        }
    }
}
