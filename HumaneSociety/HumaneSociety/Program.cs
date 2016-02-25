using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assign an animal?");
            UserInput user = new UserInput();
            Animal cat = user.MakeAnimal();

            Console.WriteLine("Assign to an available cage:");
            FileReader fr = new FileReader(@"../../Cages.txt");
            string availablecages = fr.ReadFromFile();
            Console.Write(availablecages);

            Cage cage = new Cage(@"../../Cages.txt");
            int num = cage.AssignCage();
            Console.ReadKey();

            fr.DeleteLine(num.ToString());
            Console.WriteLine("Removed from database.");

            FileWriter fw = new FileWriter(@"../../Cats.txt");
            fw.WriteToFile(num.ToString() + cat);


            Console.ReadKey();
        }
    }
}
