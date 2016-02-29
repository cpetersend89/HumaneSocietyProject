using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adoption
    {
        private List<Animal> _temp = new List<Animal>();
        private readonly List<Customer> _customerManifest = new List<Customer>();

        readonly FileReader _readAnimals = new FileReader(@"../../Animals.xml");
        readonly FileWriter _writeAnimals = new FileWriter(@"../../Animals.xml");
        readonly FileWriter _customer = new FileWriter(@"../../Customers.txt");

        public void AdoptAnAnimal(string customerName, string phoneNumber, string animalName)
        {
            _temp = _readAnimals.Deserializer();
            var animal = _temp.First(item => item.Name == animalName);
            _customerManifest.Add(new Customer(customerName, phoneNumber, animal));
            _customer.WriteCustomerToFile(_customerManifest);
            _temp.Remove(animal);
            _writeAnimals.Serializer(_temp);
        }
    }
}
