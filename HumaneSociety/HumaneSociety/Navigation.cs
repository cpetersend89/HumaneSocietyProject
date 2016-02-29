using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Navigation
    {
        readonly Queries _queries = new Queries();
        public Navigation()
        {

        }

        public void MainMenu()
        {
            Console.WriteLine("Main Menu:\n(1) Input Animal\n(2) Adopt Animal\n(3) Queries\n(4) Update Shot Record **COMING SOON**\n(5) Close Application");
            while (true)
            {
                
                int num = Tools.VerifyNumber("Invalid: Please choose a valid option");
                switch (num)
                {
                    case 1:
                        var animal = new Animal();
                        animal.AddAnimal();
                        Tools.ClearConsole();
                        break;
                    case 2:
                        _queries.FindAllAnimals();
                        var animalAdoption = new UserInput();
                        string name = animalAdoption.CustomersName();
                        string phone = animalAdoption.CustomersPhoneNumber();
                        string animalName = UserInput.AnimalName();
                        var adopt = new Adoption();
                        adopt.AdoptAnAnimal(name, phone, animalName);
                        Tools.ClearConsole();
                        break;
                    case 3:
                        QueriesMenu();
                        break;
                    case 4:
                        Console.WriteLine("Coming soon: Select an available option");
                        Tools.ClearConsole();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;
                }
                MainMenu();
            }
        }

        private void QueriesMenu()
        {
            while (true)
            {
                Console.WriteLine("Select option:\n" + "(1) View All Animals\n" + "(2) View All Dogs\n" + "(3) View All Cats\n" + "(4) View Animals Needing Shots\n" + "(5) Find Animal by Name\n" + "(6) Find Animal by Cage Number\n" + "(7) View Customer Adoptions");
                int choice = Tools.VerifyNumber("Invalid: Please choose a valid option");
                switch (choice)
                {
                    case 1:
                        _queries.FindAllAnimals();
                        Tools.ClearConsole();
                        break;
                    case 2:
                        _queries.FindAllDogs();
                        Tools.ClearConsole();
                        break;
                    case 3:
                        _queries.FindAllCats();
                        Tools.ClearConsole();
                        break;
                    case 4:
                        _queries.FindAnimalsNeedShots();
                        Tools.ClearConsole();
                        break;
                    case 5:
                        string name = UserInput.AnimalName();
                        _queries.FindAnimalByName(name);
                        Tools.ClearConsole();
                        break;
                    case 6:
                        Console.WriteLine("Enter cage number:");
                        int number = Tools.VerifyNumber("Invalid: Please choose a valid number");
                        _queries.FindAnimalByCage(number);
                        Tools.ClearConsole();
                        break;
                    case 7:
                        _queries.PrintCustomerAdoptions();
                        Tools.ClearConsole();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        continue;
                }
                MainMenu();
            }
        }
    }
}


