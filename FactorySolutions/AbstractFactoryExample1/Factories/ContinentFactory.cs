using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample1.Factories
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    public abstract class ContinentFactory
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
    }
}