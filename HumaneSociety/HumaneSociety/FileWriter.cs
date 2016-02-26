using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HumaneSociety
{
    public class FileWriter
    {
        private string _path;
        private readonly string _fileName;

        public FileWriter(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteToFile(string info)
        {
            using (FileStream fs = new FileStream(_fileName, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(info);
                }
            }
        }
        public void WriteToXmlFile(List<Animal> animals)
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!File.Exists(_path + _fileName))
            {
                var writer = new XmlTextWriter(_path + _fileName, Encoding.UTF8);
                writer.WriteStartElement("ANIMAL");
                writer.WriteEndElement();
                writer.Close();
            }
            var doc = new XmlDocument();
            doc.Load(_path + _fileName);
            var xmlNodeList = doc.SelectNodes("_animals");
            if (xmlNodeList != null)
                foreach (XmlNode xNode in xmlNodeList)
                {
                    var a = new Animal();
                    var node = xNode.SelectSingleNode("CageNumber");
                    if (node != null) a.CageNumber =  Convert.ToInt32(node.InnerText);
                    var selectSingleNode = xNode.SelectSingleNode("Name");
                    if (selectSingleNode != null) a.Name = selectSingleNode.InnerText;
                    var singleNode = xNode.SelectSingleNode("FoodType");
                    if (singleNode != null) a.FoodType = singleNode.InnerText;
                    var xmlNode = xNode.SelectSingleNode("Shots");
                    if (xmlNode != null) a.Shots = xmlNode.InnerText;
                    animals.Add(a);
                }
            foreach (var a in animals)
            {
                XmlNode xtop = doc.CreateElement("Animal");
                XmlNode xCageNumber = doc.CreateElement("CageNumber");
                XmlNode xName = doc.CreateElement("Name");
                XmlNode xFood = doc.CreateElement("FoodType");
                XmlNode xShots = doc.CreateElement("Shots");
                xCageNumber.InnerText = a.CageNumber.ToString();
                xName.InnerText = a.Name;
                xFood.InnerText = a.FoodType;
                xShots.InnerText = a.Shots;
                xtop.AppendChild(xCageNumber);
                xtop.AppendChild(xName);
                xtop.AppendChild(xFood);
                xtop.AppendChild(xShots);
                doc.DocumentElement?.AppendChild(xtop);
            }
            doc.Save(_path + _fileName);
        }
    }
}
