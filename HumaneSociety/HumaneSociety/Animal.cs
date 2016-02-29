using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HumaneSociety
{
    public class Animal
    {
        public int CageNumber { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string FoodType { get; set; }
        public string ServingSize { get; set; }
        public string Shots { get; set; }
        private readonly List<Animal> _animals = new List<Animal>();
        private List<Animal> _temp = new List<Animal>();

        public Animal()
        {
        }
        public Animal(int cageNumber, string type, string name, string foodType, string servingSize, string shots)
        {
            CageNumber = cageNumber;
            Type = type;
            Name = name;
            FoodType = foodType;
            ServingSize = servingSize;
            Shots = shots;
        }
        public void AddAnimal()
        {
            UserInput user = new UserInput();

            var readCages = new FileReader(@"../../Cages.txt");

            string availablecages = readCages.ReadFromFile();

            Console.WriteLine("Available cages:\n" + availablecages);

            Animal animal = user.AnimalInfo();
            _animals.Add(animal);

            FileWriter addAnimal = new FileWriter(@"../../Animals.xml");
            FileReader deserialize = new FileReader(@"../../Animals.xml");
            if (File.Exists(@"../../Animals.xml"))
            {
                _temp = deserialize.Deserializer();
                _temp.Add(animal);
                addAnimal.Serializer(_temp);
            }
            else { addAnimal.Serializer(_animals); }
        }

        public override string ToString()
        {
            return $"Cage: {CageNumber} Type: {Type} Name: {Name} Food Type: {FoodType} Daily Serving {ServingSize} Received Shots {Shots}";
        }

    }
}
