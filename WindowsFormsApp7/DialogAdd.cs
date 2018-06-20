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
        Student student=new Student();
       // int selected;
        public List<Lecturer> lecturers = new List<Lecturer>();
        public DialogAdd()
        {
            InitializeComponent();
            // student = new Student(null,null,null,DateTime.Now,null);
            
           
            //  comboBoxLecturer.DataSource
        }
        private void DialogAdd_Load(object sender, EventArgs e)
        {

        }
        public List<Lecturer> Lecturers
        {
            get
            {
                return lecturers;
            }
            set
            {
                lecturers = value;
                comboBoxLecturer.DataSource = lecturers;

                comboBoxLecturer.DisplayMember = "LNP";
            }
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
                textBoxNumber.Text = student.Number;
                monthCalendar1.SelectionEnd = student.Date;
                comboBoxLecturer.SelectedItem = student.Lecturer;
                 

             //   selected = comboBoxLecturer.SelectedIndex;
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
                //student =new Student(textBoxName.Text, textBoxLastName.Text, textBoxPatronymic.Text, monthCalendar1.SelectionEnd,comboBoxLecturer.SelectedItem as string);
                student.Name = textBoxName.Text;
                student.LastName = textBoxLastName.Text;
                student.Patronymic = textBoxPatronymic.Text;
                student.Date = monthCalendar1.SelectionEnd;
                student.Number = textBoxNumber.Text;
              
                if(student.Lecturer != comboBoxLecturer.SelectedItem as Lecturer)
                {
                    try
                    {
                        student.Lecturer.Students.Remove(student);
                    }
                    catch (Exception)
                    {
                    }
                   
                    student.Lecturer = comboBoxLecturer.SelectedItem as Lecturer;
                    (comboBoxLecturer.SelectedItem as Lecturer).Students.Add(student);
                }
                
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

 
}
