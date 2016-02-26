using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HumaneSociety
{
    public class Animal
    {
        public int CageNumber;
        public string Name;
        public string FoodType;
        public string Shots;
        
        public Animal(int cageNumber, string name, string foodType, string shots)
        {
            CageNumber = cageNumber;
            Name = name;
            FoodType = foodType;
            Shots = shots;
        }

        public Animal()
        {
        }

        public override string ToString()
        {
            return $"{Name} , {FoodType} , {Shots}";
        }
    }
}
