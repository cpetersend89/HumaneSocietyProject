using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Tools
    {
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

        public static void ClearConsole()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
