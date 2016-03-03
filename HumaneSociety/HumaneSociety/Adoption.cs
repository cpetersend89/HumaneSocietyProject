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
        readonly FileWriter _writeCustomer = new FileWriter(@"../../Customers.txt");
        readonly FileWriter _writeAnimal = new FileWriter(@"../../Animals.csv");

        public void AdoptAnAnimal(string customerName, string phoneNumber, string animalName)
        {
            List<Animal> temp = Tools.GetTempAnimalList();
            foreach (var animal1 in temp)
            {
                Console.WriteLine(animal1);
            }
            while (true)
            {

                var animal = temp.First(item => item.Name == " " + animalName);
                if (!temp.Contains(animal))
                {
                    Console.WriteLine("Invalid: Animal does not exist in system.");
                }
                else
                {
                    List<Customer> customerManifest = new List<Customer>();
                    customerManifest.Add(new Customer(customerName, phoneNumber, animal));
                    _writeCustomer.WriteCustomerToFile(customerManifest);
                    temp.Remove(animal);
                    _writeAnimal.OverrideFile(temp);
                    Console.WriteLine($"Confirmation: {customerName} {phoneNumber} {animal}");
                }
            }
        }
    }
}
