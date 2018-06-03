using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        BindingSource bs = new BindingSource();
        List<Lecturer> Lecturers = new List<Lecturer>();
        public Form1()
        {
            InitializeComponent();

            listBoxStudents.DisplayMember = "FIO";
            comboBoxLecturer.DisplayMember = "Name";
            bs.DataSource = Lecturers;
            comboBoxLecturer.DataSource = bs;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var wnd = new DialogAdd();

            if (wnd.ShowDialog() == DialogResult.OK)
            {
                //Students.Add(wnd.sdt);
                try
                {
                    Lecturers.Find(x => x.Name == wnd.Student.Lecturer).Students.Add(wnd.Student);
                }
                catch (System.NullReferenceException)
                {

                    Lecturers.Add(new Lecturer(wnd.Student, wnd.Student.Lecturer));
                }
                
                bs.ResetBindings(false);
                listBoxStudents.DataSource = null;
                listBoxStudents.DataSource = (comboBoxLecturer.SelectedItem as Lecturer).Students;
                listBoxStudents.DisplayMember = "FIO";
                
                //Lecturers.Add(new Lecturer(wnd.sdt,wnd.sdt.Lecturer));      
            }
            //bs.ResetBindings(false);

        }

        private void listBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // (listBoxStudents.SelectedItem as Student).Lecturer
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(comboBoxLecturer.SelectedItem!=null)
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
            //wnd.student.Name = st.Name;
            //wnd.student.LastName= st.LastName;
            if (wnd.ShowDialog() == DialogResult.OK)
            {
                (listBoxStudents.SelectedItem as Student).Assessments = wnd.Assessments;
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBoxStudents.SelectedItem != null)
            {
                var wnd = new DialogAdd();
                var st = listBoxStudents.SelectedItem as Student;
                wnd.Student = st;
                //wnd.ShowDialog();
                if (wnd.ShowDialog() == DialogResult.OK)
                {
                    if (wnd.Student.Lecturer!= st.Lecturer)
                    {
                        (comboBoxLecturer.SelectedItem as Lecturer).Students.Remove(st);
                        try
                        {
                            Lecturers.Find(x => x.Name == wnd.Student.Lecturer).Students.Add(wnd.Student);
                        }
                        catch (System.NullReferenceException)
                        {
                            Lecturers.Add(new Lecturer(wnd.Student, wnd.Student.Lecturer));
                            bs.ResetBindings(false);
                        }
                    }
                    else
                    {
                    //    (listBoxStudents.SelectedItem as Student).Init(wnd.Student);
                        (listBoxStudents.SelectedItem as Student).Name = wnd.Student.Name;
                        (listBoxStudents.SelectedItem as Student).LastName = wnd.Student.LastName;
                        (listBoxStudents.SelectedItem as Student).Patronymic = wnd.Student.Patronymic;
                        (listBoxStudents.SelectedItem as Student).Date = wnd.Student.Date;
                    }
                }
                listBoxStudents.DataSource = null;

                listBoxStudents.DataSource = (comboBoxLecturer.SelectedItem as Lecturer).Students;//
                listBoxStudents.DisplayMember = "FIO";

            }
        }

        private void comboBoxLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxStudents.DataSource = null;
            
            listBoxStudents.DataSource = (comboBoxLecturer.SelectedItem as Lecturer).Students;//
            listBoxStudents.DisplayMember = "FIO";
            //  comboBoxLecturer.
        }
    }
    public class Lecturer
    {
        public List<Student> Students = new List<Student>();
        public string Name { get; set; }

        public Lecturer(Student student, string name)
        {
            Students.Add(student);
            Name = name;
        }
    }
}
