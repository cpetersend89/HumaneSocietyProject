using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Cage
    {
        readonly FileReader _readCages = new FileReader(@"../../Cages.txt");

        public int AssignCage()
        {
            string content = _readCages.ReadFromFile();
            while (true)
            {
                int num = UserInput.VerifyNumber("Not a valid number, please choose a valid number:"); ;
                if (content.Contains(num.ToString()))
                {
                    Console.WriteLine($"Cage {num} successfully chosen.");
                    return num;
                }
                Console.WriteLine($"Cage {num} not available, try again.");
            }


        }
    }
}
