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
    public partial class StudentInfo : Form
    {
        public Student student;
        public List<Tuple<DateTime, Int32>> Assessments = new List<Tuple<DateTime, int>>();
        public StudentInfo()
        {
            InitializeComponent();
            monthCalendar1.SelectionEnd = DateTime.Now;
        }
        private void StudentInfo_Load(object sender, EventArgs e)
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
                
                labelStdName.Text = student.FIO;

                labelStdLecturer.Text = student.Lecturer;
                Assessments = student.Assessments;
                try
                {
                    labelAssessment.Text = Assessments.Find(x => x.Item1.Day == monthCalendar1.SelectionEnd.Day).Item2.ToString();

                }
                catch (NullReferenceException)
                {
                    labelAssessment.Text = "";


                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            try
            {
                labelAssessment.Text = Assessments.Find(x => x.Item1.Day == monthCalendar1.SelectionEnd.Day).Item2.ToString();

            }
            catch (NullReferenceException)
            {
                labelAssessment.Text = "";


            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Assessments.Add(new Tuple<DateTime, int>(monthCalendar1.SelectionEnd, Convert.ToInt32(textBoxSetAssessment.Text)));
                labelAssessment.Text = Assessments.Find(x => x.Item1.Day == monthCalendar1.SelectionEnd.Day).Item2.ToString();

            }
            catch (System.FormatException)
            {

                
            }
            this.DialogResult = DialogResult.OK;
            
        }
    }

}
