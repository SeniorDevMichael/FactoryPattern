using AbstractFactoryExample1.Factories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample1
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continentFactory)
        {
            _carnivore = continentFactory.CreateCarnivore();
            _herbivore = continentFactory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
