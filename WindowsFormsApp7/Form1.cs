using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        BindingSource bs = new BindingSource();
        List<Lecturer> Lecturers = new List<Lecturer>();
        List<string> Numbers = new List<string>();
        public Form1()
        {
            InitializeComponent();
            Lecturers.Add(new Lecturer("Клепач", "Владимир", "Дмитриевич", "380684468К"));
            Lecturers.Add(new Lecturer("Хилько", "Андрей", "Сергеевич", "38068446Х"));
            listBoxStudents.DisplayMember = "FIO";
            comboBoxLecturer.DisplayMember = "LNP";
            bs.DataSource = Lecturers;
            comboBoxLecturer.DataSource = bs;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddSt_Click(object sender, EventArgs e)
        {
            var wnd = new DialogAdd();
            wnd.Lecturers = this.Lecturers;
            if (wnd.ShowDialog() == DialogResult.OK)
            {


                bs.ResetBindings(false);
                listBoxStudents.DataSource = null;
                listBoxStudents.DataSource = (comboBoxLecturer.SelectedItem as Lecturer).Students;
                listBoxStudents.DisplayMember = "FIO";


            }


        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (comboBoxLecturer.SelectedItem != null)
            {
                (comboBoxLecturer.SelectedItem as Lecturer).Students.Remove(listBoxStudents.SelectedItem as Student);
                bs.ResetBindings(false);
                listBoxStudents.DataSource = null;
                listBoxStudents.DataSource = (comboBoxLecturer.SelectedItem as Lecturer).Students;
                listBoxStudents.DisplayMember = "FIO";
            }

        }

        private void listBoxStudents_DoubleClick(object sender, EventArgs e)
        {
            var wnd = new StudentInfo();
            var st = listBoxStudents.SelectedItem as Student;
            wnd.Student = st;

            if (wnd.ShowDialog() == DialogResult.OK)
            {
                (listBoxStudents.SelectedItem as Student).Assessments = wnd.Assessments;
            }
        }
        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem == null)
                return;

            var wnd = new DialogAdd();

            wnd.Lecturers = this.Lecturers;
            var st = listBoxStudents.SelectedItem as Student;
            wnd.Student = st;

            wnd.ShowDialog();

            listBoxStudents.DataSource = null;

            listBoxStudents.DataSource = (comboBoxLecturer.SelectedItem as Lecturer).Students;//
            listBoxStudents.DisplayMember = "FIO";


        }

        private void comboBoxLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStudents.DataSource = null;

            listBoxStudents.DataSource = (comboBoxLecturer.SelectedItem as Lecturer).Students;//
            listBoxStudents.DisplayMember = "FIO";

        }

        private void buttonSMS_Click(object sender, EventArgs e)
        {
            var wnd = new SMSForm
            {
                Lecturers = this.Lecturers,
                Numbers = Numbers
            };
            if (listBoxStudents.SelectedItem as Student != null)
            {
                wnd.Number = (listBoxStudents.SelectedItem as Student).Number;
            }
            else
            {
                wnd.Number = (comboBoxLecturer.SelectedItem as Lecturer).Number;
            }


            if (wnd.ShowDialog() == DialogResult.OK)
            {
                if (wnd.Numbers.Count > 5)
                {
                    Numbers = wnd.Numbers.GetRange(0, 5);

                }
                else
                {
                    this.Numbers = wnd.Numbers;
                }

            }
        }

        private void buttonAddLect_Click(object sender, EventArgs e)
        {
            var wnd = new LecturerAdd();

            if (wnd.ShowDialog() == DialogResult.OK)
            {
                Lecturers.Add(wnd.Lecturer);
            }
            bs.ResetBindings(false);
        }

        private void comboBoxLecturer_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void buttonXMLSave_Click(object sender, EventArgs e)
        {
            // объект для сериализации

            SaveFormXML saveXML = new SaveFormXML();
            saveXML.Lecturers = this.Lecturers;
            saveXML.Numbers = Numbers;
            // передаем в конструктор тип класса
            XmlSerializer formatter = new XmlSerializer(typeof(SaveFormXML));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("save.xml", FileMode.Create))
            {
                formatter.Serialize(fs, saveXML);
            }
        }

        private void buttonXMLLoad_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(SaveFormXML));
            using (FileStream fs = new FileStream("save.xml", FileMode.Open))
            {
                SaveFormXML saveXML = (SaveFormXML)formatter.Deserialize(fs);
                Lecturers.Clear();
                Lecturers.AddRange(saveXML.Lecturers);
                Numbers = saveXML.Numbers;
                foreach (var item in Lecturers)
                {
                    foreach (var stud in item.Students)
                    {
                        stud.Lecturer = item;
                    }
                }

                bs.ResetBindings(false);
            }
        }
    }

}
