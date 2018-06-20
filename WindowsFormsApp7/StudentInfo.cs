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
        // public List<Tuple<DateTime, Int32>> Assessments = new List<Tuple<DateTime, int>>();
        public List<Assessment> Assessments = new List<Assessment>();
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

                labelStdLecturer.Text = student.Lecturer.LNP;
                Assessments = student.Assessments;
                try
                {
                    labelAssessment.Text = Assessments.Find(x => x.Date.Day == monthCalendar1.SelectionEnd.Day).assessment.ToString();

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
                labelAssessment.Text = Assessments.Find(x => x.Date.Day == monthCalendar1.SelectionEnd.Day).assessment.ToString();
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
                int ass = Convert.ToInt32(textBoxSetAssessment.Text);
                if (ass < 12&& ass > 0)
                Assessments.Add(new Assessment(monthCalendar1.SelectionEnd, ass));
                labelAssessment.Text = Assessments.Find(x => x.Date.Day == monthCalendar1.SelectionEnd.Day).assessment.ToString();

            }
            catch (System.FormatException)
            {            
            }
            this.DialogResult = DialogResult.OK;
            
        }
    }

}
