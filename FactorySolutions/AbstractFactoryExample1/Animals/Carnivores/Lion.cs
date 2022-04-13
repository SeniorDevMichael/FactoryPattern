using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryExample1.Animals.Carnivores
{
    public class Lion : Carnivore //Etyeyen
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
              " eats " + h.GetType().Name);
        }
    }
}
