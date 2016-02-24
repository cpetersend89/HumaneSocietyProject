using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Cat : Animal
    {
        
        public Cat(string name, string type, string foodType, int cageNumber, bool shots)
            : base(name, type, foodType, cageNumber, shots)
        {

        }
        //private Animal _animal;
        //public Cat(Animal animal)
        //{
        //    this._animal = animal;
        //}

        //public override string ToString()
        //{
        //    return _animal.ToString();
        //}
    }
}
