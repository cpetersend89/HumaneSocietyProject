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
            var assignAnimal = new UserInput();
            int userchoice = assignAnimal.AnimalChoice();
            Console.Clear();
            if (userchoice == 1)
            {
                var dog = new Dog();
            }
            else
            {
                var cat = new Cat();
                cat.AddCat();
            }

            //Adoption adopt = new Adoption();
            //string[] dogs = adopt.FindNewDog("Bruno, is, a, Dog,");
            //Console.WriteLine(dogs[0]);
            

            Console.ReadKey();
        }
    }
}
