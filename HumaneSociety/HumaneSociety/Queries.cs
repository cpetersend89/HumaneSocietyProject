using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Queries
    { 
        public static void FindAllAnimals()
        {
            List<Animal> temp = Tools.GetTempAnimalList();
            Tools.PrintAnimalList(temp);
        }

        public static void FindAllDogs()
        {
            List<Animal> temp = Tools.GetTempAnimalList();
            List<Animal> allDogs = temp.FindAll(x => x.Type == " DOG");
            Tools.PrintAnimalList(allDogs);
        }

        public static void FindAllCats()
        {
            List<Animal> temp = Tools.GetTempAnimalList();
            List<Animal> allCats = temp.FindAll(x => x.Type == " CAT");
            Tools.PrintAnimalList(allCats);
        }

        public static void FindAnimalsNeedingShots()
        {
            List<Animal> temp = Tools.GetTempAnimalList();
            List<Animal> needShots = temp.FindAll(x => x.Shots == " NO");
            Tools.PrintAnimalList(needShots);
        }

        public static void FindAnimalByName()
        {
            List<Animal> temp = Tools.GetTempAnimalList();
            string name = UserInput.GetAnimalName();
            List<Animal> animalByName = temp.FindAll(x => x.Name == " " + name.ToUpper());
            Tools.PrintAnimalList(animalByName);
        }

        public static void FindAnimalByCage()
        {
            List<Animal> temp = Tools.GetTempAnimalList();
            int num = UserInput.GetCageNumber();
            Animal animalByCage = temp.Find(x => x.CageNumber == num);
            Console.WriteLine(animalByCage);
        }

        public static void PrintCustomerAdoptions()
        {
            FileReader readCustomers = new FileReader(@"../../Customers.txt");
            string customers = readCustomers.ReadFromFile();
            Console.WriteLine(customers);
        }

    }
}
