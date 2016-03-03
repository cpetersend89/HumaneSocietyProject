using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Tools
    {
        public static int VerifyNumber(string errormessage)
        {
            int number;
            string userInput = Console.ReadLine();
            while (!int.TryParse(userInput, out number))
            {

                Console.WriteLine(errormessage);
                userInput = Console.ReadLine();
            }
            return number;
        }

        public static void ClearConsole()
        {
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static List<Animal> GetTempAnimalList()
        {
            FileReader readAnimals = new FileReader(@"../../Animals.csv");
            List<Animal> temp = readAnimals.ReadFromCsvFile();
            return temp;
        }

        public static void PrintAnimalList(List<Animal> animals)
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

    }
}
