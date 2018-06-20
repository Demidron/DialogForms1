using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_SMS;

namespace WindowsFormsApp7
{
    public partial class SMSForm : Form
    {
        List<string> numbers = new List<string>();

        BindingSource bs = new BindingSource();
        public List<Lecturer> lecturers = new List<Lecturer>();
        public SMSForm()
        {
            InitializeComponent();

            bs.DataSource = numbers;
            comboBoxNumbers.DataSource = bs;
        }

        private void SMSForm_Load(object sender, EventArgs e)
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
            }
        }
        public List<string> Numbers
        {
            get
            {
                return numbers;
            }
            set
            {
                numbers.Clear();
                numbers.AddRange(value);
                bs.ResetBindings(false);
            }
        }

        public string Number
        {
            set
            {
                if (value != null)
                {
                    if (!numbers.Contains(value))
                    {
                        numbers.Add(value);
                    }
                    bs.ResetBindings(false);
                    comboBoxNumbers.SelectedItem = value;
                }
            }
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxSMSText.Text = "";
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            if (Send(comboBoxNumbers.SelectedItem as string, textBoxSMSText.Text))
            {
                try
                {
                    numbers.Find(x => x == comboBoxNumbers.Text);
                }
                catch (NullReferenceException)
                {
                    numbers.Add(comboBoxNumbers.Text);
                    bs.ResetBindings(false);
                }
            }
            this.DialogResult = DialogResult.OK;

        }
        bool Send(string number, string text)
        {
            SMSSender sender = new SMSSender("vladmir.klepach@gmail.com", "1qaZ2wsX", "name");
            var result = sender.Send(number, text);
            switch (result)
            {
                case -1:
                    Console.WriteLine("Неправильный логин и / или пароль");
                    break;
                case -2:
                    Console.WriteLine("Неправильный формат XML");
                    break;
                case -3:
                    Console.WriteLine("Недостаточно кредитов на аккаунте пользователя");
                    break;
                case -4:
                    Console.WriteLine("Нет верных номеров получателей");
                    break;
                case -5:
                    Console.WriteLine("Ошибка подключения");
                    break;
                case -6:
                    break;
                case -7:
                    break;
                default:
                    Console.WriteLine("СМС в количестве: {0} отправлено!", result);
                    return true;
                    //break;
            }
            return false;
        }

        private void comboBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOwnerNumber.Text = "";
            foreach (var item in lecturers)
            {
                if (item.Number == comboBoxNumbers.Text)
                {
                    labelOwnerNumber.Text += item.LNP + Environment.NewLine;
                }

                try
                {
                    labelOwnerNumber.Text += item.Students.Find(x => x.Number == comboBoxNumbers.Text).FIO + Environment.NewLine;
                }
                catch (Exception){ }

            }
        }

        private void SMSForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void textBoxSMSText_TextChanged(object sender, EventArgs e)
        {
            buttonSend.Enabled = textBoxSMSText.Text != string.Empty ? true : false;


            labelCount.Text = $"Sym: { textBoxSMSText.Text.Count()}, SMS: {textBoxSMSText.Text.Count() / 70}";

        }

        private void comboBoxNumbers_TextChanged(object sender, EventArgs e)
        {
            labelOwnerNumber.Text = "";
            foreach (var item in lecturers)
            {
                if (item.Number == comboBoxNumbers.Text)
                {
                    labelOwnerNumber.Text += item.LNP + Environment.NewLine;
                }

                try
                {
                    labelOwnerNumber.Text += item.Students.Find(x => x.Number == comboBoxNumbers.Text).FIO + Environment.NewLine;
                }
                catch (Exception)
                {


                }


            }

        }
    }
}
