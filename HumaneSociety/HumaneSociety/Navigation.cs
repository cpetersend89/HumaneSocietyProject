using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Navigation
    {

        public void DisplayMainMenu()
        {
            Console.WriteLine("Main Menu:\n(1) Input Animal\n(2) Adopt Animal\n(3) Queries\n(4) Update Shot Record **COMING SOON**\n(5) Close Application");
            while (true)
            { 
                int num = Tools.VerifyNumber("Invalid: Please choose a valid option");
                switch (num)
                {
                    case 1: //Input Animal
                        Console.Clear();
                        var animal = new Animal();
                        animal.AddAnimal();
                        Tools.ClearConsole();
                        break;
                    case 2: //Adopt Animal
                        Console.Clear();
                        Queries.FindAllAnimals();
                        string animalName = UserInput.GetAnimalName();
                        string name = UserInput.CustomersName();
                        string phone = UserInput.CustomersPhoneNumber();
                        var adopt = new Adoption();
                        adopt.AdoptAnAnimal(name, phone, animalName);
                        Tools.ClearConsole();
                        break;
                    case 3: //Queries
                        Console.Clear();
                        DisplayQueriesMenu();
                        break;
                    case 4: //Update Shots
                        var updateShots = new Shots();
                        updateShots.UpdateShots("Logos");
                        Tools.ClearConsole();
                        break;
                    case 5: //Close Application
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid: Please choose a valid option");
                        break;
                }
                DisplayMainMenu();
            }
        }

        private void DisplayQueriesMenu()
        {
            while (true)
            {
                Console.WriteLine("Select option:\n" + "(1) View All Animals\n" + "(2) View All Dogs\n" + "(3) View All Cats\n" + "(4) View Animals Needing Shots\n" + "(5) Find Animal by Name\n" + "(6) Find Animal by Cage Number\n" + "(7) View Customer Adoptions\n" + "(8) Main Menu");
                int choice = Tools.VerifyNumber("Invalid: Please choose a valid option");
                switch (choice)
                {
                    case 1: //View All Animals
                        Console.Clear();
                        Queries.FindAllAnimals();
                        Tools.ClearConsole();
                        break;
                    case 2: // View All Dogs
                        Console.Clear();
                        Queries.FindAllDogs();
                        Tools.ClearConsole();
                        break;
                    case 3: //View All Cats
                        Console.Clear();
                        Queries.FindAllCats();
                        Tools.ClearConsole();
                        break;
                    case 4: //View Animals Needing Shots
                        Console.Clear();
                        Queries.FindAnimalsNeedingShots();
                        Tools.ClearConsole();
                        break;
                    case 5: //View Animal By Name
                        Console.Clear();
                        Queries.FindAnimalByName();
                        Tools.ClearConsole();
                        break;
                    case 6: //View Animal By Cage Number
                        Console.Clear();
                        Queries.FindAnimalByCage();
                        Tools.ClearConsole();
                        break;
                    case 7: //View Customer Manifest
                        Console.Clear();
                        Queries.PrintCustomerAdoptions();
                        Tools.ClearConsole();
                        break;
                    case 8: //Back to Main Menu
                        Console.Clear();
                        DisplayMainMenu();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid: Please choose a valid option");
                        continue;
                }
                DisplayQueriesMenu();
            }
        }
    }
}


