using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Shots
    {
        List<Animal> _temp = new List<Animal>();
        List<Animal> _needShots = new List<Animal>();
        Animal temp = new Animal();
        readonly FileReader _readAnimals = new FileReader(@"../../Animals.xml");
        readonly FileWriter _writeAnimals = new FileWriter(@"../../Animals.xml");
        public void UpdateShots(string name)
        {
            _temp = _readAnimals.Deserializer();
            _needShots = _temp.FindAll(x => x.Shots == "NO");
            temp = _needShots.Find(y => y.Name == name.ToUpper());
            Console.WriteLine("Update Shots? (1) Yes or (2) No");
            int num = Tools.VerifyNumber("Invalid: Not a valid number");
            while (true)
            {
                if (num == 1)
                {
                    _temp.Remove(temp);
                    temp.Shots = "YES";
                    _temp.Add(temp);
                    _writeAnimals.Serializer(_temp);
                }
                if (num == 2)
                {
                    _writeAnimals.Serializer(_temp);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid: Select '1' for YES '2' for NO");
                }
            }
        }
    }
}
