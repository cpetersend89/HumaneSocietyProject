 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Customer
    {
        private readonly string _name;
        private readonly string _phoneNumber;
        private readonly Animal _animal;

        public Customer(string name, string phoneNumber, Animal animal)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _animal = animal;
        }

        public override string ToString()
        {
            return $"{"Customer: " + _name} {_phoneNumber} {"Animal: " + _animal.Name + " " + _animal.FoodType + " " + _animal.Shots}";
        }
    }
}
