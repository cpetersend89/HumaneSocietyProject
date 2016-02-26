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
        public Animal AnimalInfo()
        {
            string name = AnimalName();
            string food = AnimalFood();
            bool shots = Shots();
            return new Animal(name, food, shots);
        }
        private static string AnimalName()
        {
            Console.WriteLine("Please enter the animal's name:");
            string name = Console.ReadLine();
            return name;
        }
        //private static string AnimalType()
        //{
        //    Console.WriteLine("Please input animal type:");
        //    string type = Console.ReadLine();
        //    return type;
        //}

        private static string AnimalFood()
        {
            Console.WriteLine("Please enter animal's food type:");
            string food = Console.ReadLine();
            return food;
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

        public int AnimalChoice()
        {
            Console.WriteLine("Would you like to assign a (1) Dog or a (2) Cat?");
            while (true)
            {
                int choice = VerifyNumber("Invalid: Select '1' for Dog or '2' for Cat.");
                if (choice == 1 || choice == 2)
                    return choice;
                Console.WriteLine("Invalid: Select '1' for Dog or '2' for Cat.");
            }
        }
    }
}
