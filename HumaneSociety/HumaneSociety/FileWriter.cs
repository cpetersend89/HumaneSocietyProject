using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace HumaneSociety
{
    public class FileWriter
    {
        private readonly string _fileName;

        public FileWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteCsvToFile(List<Animal> animals)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Animal animal in animals)
                    {
                        sw.WriteLine(animal);
                    }
                }
            }
        }

        public void OverrideFile(List<Animal> animals)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Animal animal in animals)
                    {
                        sw.WriteLine(animal);
                    }
                }
            }
        }

        public void WriteCustomerToFile(List<Customer> info )
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    foreach (Customer customer in info)
                    {
                        sw.WriteLine(customer);
                    }
                    
                }
            }
        }
        //public void Serializer(List<Animal> details)
        //{

        //    using (FileStream fs = new FileStream(_fileName, FileMode.Create, FileAccess.Write))
        //    {

        //        using (StreamWriter sw = new StreamWriter(fs))
        //        {
        //            XmlSerializer serializer = new XmlSerializer(typeof(List<Animal>));
        //            serializer.Serialize(sw, details);
        //        }
        //    }
        //}
    }
}
