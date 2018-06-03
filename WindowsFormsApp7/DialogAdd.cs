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
    public partial class DialogAdd : Form
    {
        Student student;
        List<string> Lecturers = new List<string>();
        public DialogAdd()
        {
            InitializeComponent();
            student = new Student(null,null,null,DateTime.Now,null);
            Lecturers.Add("Клепач В.В.");
            Lecturers.Add("Хилько А.С.");
            comboBoxLecturer.DataSource = Lecturers;
            //  comboBoxLecturer.DataSource
        }
        private void DialogAdd_Load(object sender, EventArgs e)
        {

        }
        public Student Student
        {
            get
            {
                return student;
            }
            set
            {
                student = value;
                textBoxLastName.Text = student.LastName;
                textBoxName.Text = student.Name;
                textBoxPatronymic.Text = student.Patronymic;
                monthCalendar1.SelectionEnd = student.Date;
                comboBoxLecturer.SelectedItem = student.Lecturer;
            }
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(textBoxLastName.Text=="")
            {
                MessageBox.Show("Set Last Name!!!");
            }
            if (textBoxPatronymic.Text == "")
            {
                MessageBox.Show("Set Patronymic!!!");
            }
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Set Name!!!");
            }
            if (textBoxLastName.Text!="" && textBoxPatronymic.Text != "" && textBoxName.Text != "")
            {
                student =new Student(textBoxName.Text, textBoxLastName.Text, textBoxPatronymic.Text, monthCalendar1.SelectionEnd,comboBoxLecturer.SelectedItem as string);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Lecturer { get; set; }
        public DateTime Date { get; set; }

        public List<Tuple<DateTime, Int32>> Assessments=new List<Tuple<DateTime, int>>();
        public void Init(Student st)
        {
            Name = st.Name;
            LastName = st.LastName;
        }
 
        public String FIO
        {
            get { return LastName+" " +Name.First()+"."+Patronymic.First()+"."; }
        }
        //public String Lect
        //{
        //    get { return Lecturer; }
        //}
        public Student(string name, string lastName, string patronymic,DateTime date, string lecturer)
        {
            Name = name;
            LastName = lastName;
            Patronymic = patronymic;
            Date = date;
            Lecturer = lecturer;
            
        }
        
    }
}
