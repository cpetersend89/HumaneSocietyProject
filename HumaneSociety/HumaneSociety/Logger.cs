using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Logger
    {
        private readonly List<Animal> _animals = new List<Animal>();
        public void AddAnimal(Animal animal)
        {
            if (animal == null)
            {
                throw new NullReferenceException("Animals information required");
            }

            _animals.Add(animal);
        }

        public void PrintAnimals()
        {
            foreach (Animal test in _animals)
            {
                Console.WriteLine(test);
            }
        }


    }
}
