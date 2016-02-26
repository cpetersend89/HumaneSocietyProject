using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Cat
    {
        private readonly List<Animal> _cats = new List<Animal>(); 
        public Cat()
        {

        }

        public void AddCat()
        {
            UserInput user = new UserInput();

            FileReader readCages = new FileReader(@"../../Cages.txt");

            string availablecages = readCages.ReadFromFile();

            Console.WriteLine("Available cages:\n" + availablecages);

            Animal cat = user.AnimalInfo();
            _cats.Add(cat);

            FileWriter fw = new FileWriter("//HumaneSociety.settings.xml");
            fw.WriteToXmlFile(_cats);
        }
    }
}
