namespace WindowsFormsApp7
{
    partial class DialogAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.labelLecturer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 42);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(192, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(6, 45);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(93, 70);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(192, 22);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(93, 98);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(192, 22);
            this.textBoxPatronymic.TabIndex = 4;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(6, 73);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(72, 17);
            this.labelLastname.TabIndex = 5;
            this.labelLastname.Text = "LastName";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(6, 101);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(78, 17);
            this.labelPatronymic.TabIndex = 6;
            this.labelPatronymic.Text = "Patronymic";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(93, 351);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 8;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(210, 351);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(93, 132);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // comboBoxLecturer
            // 
            this.comboBoxLecturer.FormattingEnabled = true;
            this.comboBoxLecturer.Location = new System.Drawing.Point(93, 12);
            this.comboBoxLecturer.Name = "comboBoxLecturer";
            this.comboBoxLecturer.Size = new System.Drawing.Size(192, 24);
            this.comboBoxLecturer.TabIndex = 10;
            this.comboBoxLecturer.SelectedIndexChanged += new System.EventHandler(this.comboBoxLecturer_SelectedIndexChanged);
            // 
            // labelLecturer
            // 
            this.labelLecturer.AutoSize = true;
            this.labelLecturer.Location = new System.Drawing.Point(5, 15);
            this.labelLecturer.Name = "labelLecturer";
            this.labelLecturer.Size = new System.Drawing.Size(61, 17);
            this.labelLecturer.TabIndex = 11;
            this.labelLecturer.Text = "Lecturer";
            // 
            // DialogAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 383);
            this.Controls.Add(this.labelLecturer);
            this.Controls.Add(this.comboBoxLecturer);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "DialogAdd";
            this.Text = "DialogAdd";
            this.Load += new System.EventHandler(this.DialogAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ComboBox comboBoxLecturer;
        private System.Windows.Forms.Label labelLecturer;
    }
}