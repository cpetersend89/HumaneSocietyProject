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
        private readonly string _fileName;

        public Cage(string fileName)
        {
            _fileName = fileName;
        }
        public int CageNumber()
        {
            int cagenumber;
            string userinput = Console.ReadLine();
            while (!int.TryParse(userinput, out cagenumber))
            {
                Console.WriteLine("Not a valid number, please choose a valid number:");
                userinput = Console.ReadLine();
            }
            return cagenumber;
        }

        public int AssignCage()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string content = sr.ReadToEnd();
                    while (true)
                    {
                        int num = CageNumber();
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
    }
}
