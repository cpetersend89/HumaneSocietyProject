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
        private static readonly FileReader ReadCages = new FileReader(@"../../Cages.txt");

        public static Animal GetAnimalInfo()
        {
            int cageNumber = AssignAnimalToCage();
            string type = GetAnimalType();
            string name = GetAnimalName();
            string food = GetAnimalFood();
            string servingSize = GetServingSize();
            string shots = GetShots();
            return new Animal(cageNumber, type, name, food, servingSize, shots);
        }

        public static int AssignAnimalToCage()
        {
            Console.WriteLine("Assign animal to an available cage:");
            string content = ReadCages.ReadFromFile();
            while (true)
            {
                int num = Tools.VerifyNumber("Not a valid number, please choose a valid number:");
                if (content.Contains(num.ToString()))
                {
                    ReadCages.DeleteLine(num.ToString());
                    Console.WriteLine($"Cage {num} successfully chosen.");
                    return num;
                }
                Console.WriteLine($"Cage {num} not available, try again.");
            }
        }

        public static int GetCageNumber()
        {
            Console.WriteLine("Enter cage number:");
            int num = Tools.VerifyNumber("Invalid: Please choose a valid number");
            return num;
        }
        public static string GetAnimalName()
        {
            Console.WriteLine("Please enter the animal's name:");
            string name = Console.ReadLine();
            return name.ToUpper();
        }

        public static string GetAnimalType()
        {
            Console.WriteLine("Select animal type: (1) Dog (2) Cat");
            while (true)
            {
                int choice = Tools.VerifyNumber("Invalid: Select '1' for Dog or '2' for Cat.");
                if (choice == 1)
                    return "DOG";
                if (choice == 2)
                    return "CAT";
                Console.WriteLine("Invalid: Select '1' for Dog or '2' for Cat.");
            }

        }
        private static string GetAnimalFood()
        {
            Console.WriteLine("Select food diet: (1) Regular (2) Diet (3) Gluten Free (4) Soft Only");
            while (true)
            {
                int choice = Tools.VerifyNumber("Invalid: (1) Regular (2) Diet (3) Gluten Free (4) Soft Only");
                if (choice == 1)
                    return "REGULAR";
                if (choice == 2)
                    return "DIET";
                if (choice == 3)
                    return "GLUTEN FREE";
                if (choice == 4)
                    return "SOFT ONLY";
                Console.WriteLine("Invalid: (1) Regular (2) Diet (3) Gluten Free (4) Soft Only");
            }
        }

        public static string GetServingSize()
        {
            Console.WriteLine("Serving Size: (1) 1/3 cups (2) 1/2 cups (3) 3/4 cups (4) 1 cup (5) 2 cups");
            while (true)
            {
                int choice = Tools.VerifyNumber("Invalid: (1) 1/3 cups (2) 1/2 cups (3) 3/4 cups (4) 1 cup (5) 2 cups");
                if (choice == 1)
                    return "1/3 cups";
                if (choice == 2)
                    return "1/2 cups";
                if (choice == 3)
                    return "3/4 cups";
                if (choice == 4)
                    return "1 cup";
                if (choice == 5)
                    return "2 cups";
                Console.WriteLine("Invalid: (1) 1/3 cups (2) 1/2 cups (3) 3/4 cups (4) 1 cup (5) 2 cups");
            }
        }

        public static string GetShots()
        {
            while (true)
            {
                Console.WriteLine("Did the animal receive it's shots?  'Y' or 'N'");
                string shots = Console.ReadLine();
                if (shots == "Y" || shots == "y")
                    return "YES";
                if (shots == "N" || shots == "n")
                    return "NO";
                Console.WriteLine("Invalid, try again");
            }
        }

        public static string CustomersName()
        {
            Console.WriteLine("Enter customers name:");
            string name = Console.ReadLine();
            return name.ToUpper();
        }

        public static string CustomersPhoneNumber()
        {
            Console.WriteLine("Enter customers phone number:");
            string phone = Console.ReadLine();
            return phone;
        }
    }
}
