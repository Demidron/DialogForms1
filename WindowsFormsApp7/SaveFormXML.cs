using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace WindowsFormsApp7
{
    [Serializable]
    [XmlRoot("Root")]
    public class SaveFormXML
    {
        [XmlElement]
        public List<Lecturer> Lecturers { get; set; }
        [XmlElement]
        public List<string> Numbers { get; set; }

        public SaveFormXML()
        { }

        public SaveFormXML(List<Lecturer> lecturers, List<string> numbers)
        {
            Lecturers = lecturers;
            Numbers = numbers;
        }
    }
}
