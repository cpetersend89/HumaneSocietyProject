using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Dog
    {
        private readonly List<Animal> _dogs = new List<Animal>(); 
        public Dog()
        {
            UserInput user = new UserInput();

            FileReader readCages = new FileReader(@"../../Cages.txt");

            string availablecages = readCages.ReadFromFile();

            Console.WriteLine("Available cages:\n" + availablecages);

            Animal cat = user.AnimalInfo();
            _dogs.Add(cat);

            FileWriter fw = new FileWriter("//HumaneSociety.settings.xml");
            fw.WriteToXmlFile(_dogs);
        }
    }
}
