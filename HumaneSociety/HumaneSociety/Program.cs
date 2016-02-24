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
            //var fw = new FileWriter(@"../../test.txt");
            //fw.WriteToFile("Testing to see if this writes to the file.");


            //var fr = new FileReader(@"../../test.txt");
            //string testFr = fr.ReadFromFile();
            //Console.WriteLine(testFr);

            //var cat = new Cat("Logos", "Cat", "Diet", 5, true);
            //Console.WriteLine(cat);

            //var cat = new Cat(new Animal("Logos", "Cat", "Diet", 5, true));
            //Console.WriteLine(cat);

            var animals = new Logger();



            var ui = new UserInput();
            Animal animal = ui.MakeAnimal();
            animals.AddAnimal(animal);
            animals.PrintAnimals();

            Console.ReadKey();
        }
    }
}
