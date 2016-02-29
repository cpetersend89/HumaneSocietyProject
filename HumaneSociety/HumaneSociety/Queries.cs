using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Queries
    {
        private List<Animal> _temp = new List<Animal>();
        private List<Animal> _allDogs = new List<Animal>();
        private List<Animal> _allCats = new List<Animal>();
        private List<Animal> _needShots = new List<Animal>();
        private Animal _animalByName = new Animal();
        private Animal _animalByCage =  new Animal(); 
        readonly FileReader _readAnimals = new FileReader(@"../../Animals.xml");
        readonly FileWriter _writeAnimals = new FileWriter(@"../../Animals.xml");
        readonly FileReader _readCustomers = new FileReader(@"../../Customers.txt");
        public Queries()
        {
            
        }

        

        public void FindAllAnimals()
        {
            _temp = _readAnimals.Deserializer();
            foreach (Animal animals in _temp)
            {
                Console.WriteLine(animals);
            }
            _writeAnimals.Serializer(_temp);
        }

        public void FindAllDogs()
        {
            _temp = _readAnimals.Deserializer();
            _allDogs = _temp.FindAll(x => x.Type == "DOG");
            foreach (Animal dogs in _allDogs)
            {
                Console.WriteLine(dogs);
            }
            _writeAnimals.Serializer(_temp);
        }

        public void FindAllCats()
        {
            _temp = _readAnimals.Deserializer();
            _allCats = _temp.FindAll(x => x.Type == "CAT");
            foreach (Animal cats in _allCats)
            {
                Console.WriteLine(cats);
            }
            _writeAnimals.Serializer(_temp);
        }

        public void FindAnimalsNeedShots()
        {
            _temp = _readAnimals.Deserializer();
            _needShots = _temp.FindAll(x => x.Shots == "NO");
            foreach (Animal animals in _needShots)
            {
                Console.WriteLine(animals);
            }
            _writeAnimals.Serializer(_temp);
        }

        public void FindAnimalByName(string name)
        {
            _temp = _readAnimals.Deserializer();
            _animalByName = _temp.Find(x => x.Name == name.ToUpper());
            Console.WriteLine(_animalByName);
            _writeAnimals.Serializer(_temp);
        }

        public void FindAnimalByCage(int num)
        {
            _temp = _readAnimals.Deserializer();
            _animalByCage = _temp.Find(x => x.CageNumber == num);
            Console.WriteLine(_animalByCage);
            _writeAnimals.Serializer(_temp);
        }

        public void PrintCustomerAdoptions()
        {
            string customers = _readCustomers.ReadFromFile();
            Console.WriteLine(customers); 
        }

    }
}
