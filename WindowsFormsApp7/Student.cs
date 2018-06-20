using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WindowsFormsApp7
{
    public class Student 
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        [XmlIgnore]
        public Lecturer Lecturer { get; set; }
        public DateTime Date { get; set; }
        public string Number { get; set; }
        //public List<Tuple<DateTime, Int32>> Assessments = new List<Tuple<DateTime, int>>();
        public List<Assessment> Assessments = new List<Assessment>();
        //public void Init(Student st)
        //{
        //    Name = st.Name;
        //    LastName = st.LastName;
        //}
        public Student()
        {

        }
        public String FIO
        {
            get { return LastName + " " + Name.First() + "." + Patronymic.First() + "."; }
        }


        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            Name = reader.ReadString();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(Name);
        }
    }



}
