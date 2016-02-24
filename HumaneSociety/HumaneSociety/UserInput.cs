using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class UserInput
    {
        public Animal MakeAnimal()
        {
            string name = AnimalName();
            string type = AnimalType();
            string food = AnimalFood();
            int cagenumber = CageNumber();
            bool shots = Shots();
            return new Animal(name, type, food, cagenumber, shots);
        }
        private static string AnimalName()
        {
            Console.WriteLine("Please enter the animal's name:");
            string name = Console.ReadLine();
            return name;
        }

        private static string AnimalType()
        {
            Console.WriteLine("Please input animal type:");
            string type = Console.ReadLine();
            return type;
        }

        private static string AnimalFood()
        {
            Console.WriteLine("Please enter animal's food type:");
            string food = Console.ReadLine();
            return food;
        }

        private static int CageNumber()
        {
            int cagenumber;
            Console.WriteLine("Please assign a cage number:");
            string userinput = Console.ReadLine();
            while (!int.TryParse(userinput, out cagenumber))
            {
                Console.WriteLine("Not a valid number, please choose a valid number:");
                userinput = Console.ReadLine();
            }
            return cagenumber;
        }

        private static bool Shots()
        {
            while (true)
            {
                Console.WriteLine("Did the animal receive it's shots?  'Y' or 'N'");
                string shots = Console.ReadLine();
                if (shots == "Y" || shots == "y")
                    return true;
                if (shots == "N" || shots == "n")
                    return false;
                Console.WriteLine("Invalid, try again");
            }
        }
    }
}
