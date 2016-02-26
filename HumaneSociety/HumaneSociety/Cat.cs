using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Cat
    {
        public Cat()
        {
            UserInput user = new UserInput();
            Animal cat = user.AnimalInfo();

            Console.WriteLine("Assign to an available cage:");
            FileReader readCages = new FileReader(@"../../Cages.txt");
            string availablecages = readCages.ReadFromFile();
            Console.WriteLine(availablecages);

            Cage cage = new Cage();
            var num = cage.AssignCage();
            Console.ReadKey();

            readCages.DeleteLine(num.ToString());
            Console.WriteLine("Removed from database.");

            FileWriter fw = new FileWriter(@"../../Cats.txt");
            fw.WriteToFile(num + " " + cat);
        }
    }
}
