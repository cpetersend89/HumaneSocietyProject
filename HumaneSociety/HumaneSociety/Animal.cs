using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Animal
    {
        private string _name;
        private string _type;
        private string _foodType;
        private int _cageNumber;
        private bool _shots;
        
        public Animal(string name, string type, string foodType, int cageNumber, bool shots)
        {
            _name = name;
            _type = type;
            _foodType = foodType;
            _cageNumber = cageNumber;
            _shots = shots;
        }

        public override string ToString()
        {
            return _name + _type + _foodType + _cageNumber + _shots;
        }
    }
}
