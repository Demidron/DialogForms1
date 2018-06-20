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
    public partial class LecturerAdd : Form
    {
        public Lecturer Lecturer;
        public LecturerAdd()
        {
            InitializeComponent();
            Lecturer = new Lecturer();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Lecturer.Name = textBoxName.Text;
            Lecturer.LastName = textBoxLastName.Text;
            Lecturer.Patronymic= textBoxPatronymic.Text;
            Lecturer.Number = textBoxNumber.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LecturerAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
