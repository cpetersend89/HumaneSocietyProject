using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HumaneSociety
{
    public class FileReader
    {
        private readonly string _fileName;

        public FileReader(string fileName)
        {
            _fileName = fileName;
        }
        public string ReadFromFile()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
 
        public List<Animal> ReadFromCsvFile()
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    List<Animal> animals = new List<Animal>();
                    while (!sr.EndOfStream)
                    {
                        string str = sr.ReadLine();
                        string[] parseString = str.Split(',');

                        animals.Add(new Animal(int.Parse(parseString[0]), parseString[1], parseString[2], parseString[3], parseString[4], parseString[5]));
                    }
                    return animals;
                }
            }
        }
        public void DeleteLine(string remove)
        {
            var oldLines = File.ReadAllLines(_fileName);
            var newLines = oldLines.Where(line => !line.Contains(remove));
            File.WriteAllLines(_fileName, newLines);
        }
        //public List<Animal> Deserializer()
        //{
        //    XmlSerializer deserializer = new XmlSerializer(typeof(List<Animal>));
        //    TextReader reader = new StreamReader(@"../../Animals.csv");

        //    List<Animal> obj = (List<Animal>)deserializer.Deserialize(reader);
        //    reader.Close();
        //    return obj;
        //}
    }
}
