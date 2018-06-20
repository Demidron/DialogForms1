using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace WindowsFormsApp7
{
   
    public class Lecturer
    {
        [XmlArray]
        public List<Student> Students = new List<Student>();
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string LastName { get; set; }
        [XmlElement]
        public string Patronymic { get; set; }
        [XmlElement]
        public string Number { get; set; }
        public Lecturer()
        {
            //Name = null;
            //LastName = null;
            //Patronymic = null ;
            //Number = null;
        }

        public Lecturer( string lastName,string name, string patronymic, string number)
        {
            Name = name;
            LastName = lastName;
            Patronymic = patronymic;
            Number = number;
        }
        public String LNP
        {
            get { return LastName + " " + Name.First() + "." + Patronymic.First() + "."; }
        }
        //public Lecturer(Student student, string name)
        //{
        //    Students.Add(student);
        //    Name = name;
        //}
    }
}
