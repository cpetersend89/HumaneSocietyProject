using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adoption
    {
        FileReader adoptDog = new FileReader(@"../../Dogs.txt");
        public string FindDog(string name)
        {
            var x = adoptDog.ReadFromFile();
            var dog = x.Where(line => line.Contains(name))
                var newLines = oldLines.Where(line => !line.Contains(remove));
        }
        


    }
}
