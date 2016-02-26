using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adoption
    {
        FileReader adoptDog = new FileReader(@"../../Dogs.txt");
        public string[] FindDog(string name)
        {
            var oldLines = File.ReadAllLines(@"../../Dogs.txt");
            var newLines = oldLines.Where(line => line.Contains(name));
            var enumerable = newLines as string[] ?? newLines.ToArray();
            File.WriteAllLines(@"../../Dogs.txt", enumerable);
            Console.WriteLine(enumerable[0]);
            return enumerable;
        }

        public string[] FindNewDog(string name)
        {
            return new[] {name};
        }



    }
}
