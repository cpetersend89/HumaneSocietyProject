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
        private string _foodType;
        private bool _shots;
        
        public Animal(string name, string foodType, bool shots)
        {
            _name = name;
            _foodType = foodType;
            _shots = shots;
        }

        public override string ToString()
        {
            return $"{_name} {_foodType} {_shots}";
        }
    }
}
