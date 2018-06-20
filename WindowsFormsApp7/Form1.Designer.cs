namespace WindowsFormsApp7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxStudents = new System.Windows.Forms.ListBox();
            this.labelStudents = new System.Windows.Forms.Label();
            this.buttonAddSt = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelLecturer = new System.Windows.Forms.Label();
            this.buttonSMS = new System.Windows.Forms.Button();
            this.buttonAddLect = new System.Windows.Forms.Button();
            this.buttonXMLSave = new System.Windows.Forms.Button();
            this.buttonXMLLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxStudents
            // 
            this.listBoxStudents.FormattingEnabled = true;
            this.listBoxStudents.ItemHeight = 16;
            this.listBoxStudents.Location = new System.Drawing.Point(12, 96);
            this.listBoxStudents.Name = "listBoxStudents";
            this.listBoxStudents.Size = new System.Drawing.Size(309, 324);
            this.listBoxStudents.TabIndex = 0;
            this.listBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxStudents_SelectedIndexChanged);
            this.listBoxStudents.DoubleClick += new System.EventHandler(this.listBoxStudents_DoubleClick);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(12, 76);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(64, 17);
            this.labelStudents.TabIndex = 1;
            this.labelStudents.Text = "Students";
            // 
            // buttonAddSt
            // 
            this.buttonAddSt.Location = new System.Drawing.Point(327, 96);
            this.buttonAddSt.Name = "buttonAddSt";
            this.buttonAddSt.Size = new System.Drawing.Size(98, 23);
            this.buttonAddSt.TabIndex = 2;
            this.buttonAddSt.Text = "Add Student";
            this.buttonAddSt.UseVisualStyleBackColor = true;
            this.buttonAddSt.Click += new System.EventHandler(this.buttonAddSt_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(336, 125);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // comboBoxLecturer
            // 
            this.comboBoxLecturer.FormattingEnabled = true;
            this.comboBoxLecturer.Location = new System.Drawing.Point(15, 37);
            this.comboBoxLecturer.Name = "comboBoxLecturer";
            this.comboBoxLecturer.Size = new System.Drawing.Size(188, 24);
            this.comboBoxLecturer.TabIndex = 4;
            this.comboBoxLecturer.SelectedIndexChanged += new System.EventHandler(this.comboBoxLecturer_SelectedIndexChanged);
            this.comboBoxLecturer.SelectionChangeCommitted += new System.EventHandler(this.comboBoxLecturer_SelectionChangeCommitted);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(336, 154);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 5;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // labelLecturer
            // 
            this.labelLecturer.AutoSize = true;
            this.labelLecturer.Location = new System.Drawing.Point(12, 17);
            this.labelLecturer.Name = "labelLecturer";
            this.labelLecturer.Size = new System.Drawing.Size(61, 17);
            this.labelLecturer.TabIndex = 12;
            this.labelLecturer.Text = "Lecturer";
            // 
            // buttonSMS
            // 
            this.buttonSMS.Location = new System.Drawing.Point(336, 183);
            this.buttonSMS.Name = "buttonSMS";
            this.buttonSMS.Size = new System.Drawing.Size(75, 23);
            this.buttonSMS.TabIndex = 13;
            this.buttonSMS.Text = "SMS";
            this.buttonSMS.UseVisualStyleBackColor = true;
            this.buttonSMS.Click += new System.EventHandler(this.buttonSMS_Click);
            // 
            // buttonAddLect
            // 
            this.buttonAddLect.Location = new System.Drawing.Point(209, 38);
            this.buttonAddLect.Name = "buttonAddLect";
            this.buttonAddLect.Size = new System.Drawing.Size(98, 23);
            this.buttonAddLect.TabIndex = 14;
            this.buttonAddLect.Text = "Add Lecturer";
            this.buttonAddLect.UseVisualStyleBackColor = true;
            this.buttonAddLect.Click += new System.EventHandler(this.buttonAddLect_Click);
            // 
            // buttonXMLSave
            // 
            this.buttonXMLSave.Location = new System.Drawing.Point(336, 212);
            this.buttonXMLSave.Name = "buttonXMLSave";
            this.buttonXMLSave.Size = new System.Drawing.Size(75, 46);
            this.buttonXMLSave.TabIndex = 15;
            this.buttonXMLSave.Text = "Save to XML";
            this.buttonXMLSave.UseVisualStyleBackColor = true;
            this.buttonXMLSave.Click += new System.EventHandler(this.buttonXMLSave_Click);
            // 
            // buttonXMLLoad
            // 
            this.buttonXMLLoad.Location = new System.Drawing.Point(327, 264);
            this.buttonXMLLoad.Name = "buttonXMLLoad";
            this.buttonXMLLoad.Size = new System.Drawing.Size(89, 46);
            this.buttonXMLLoad.TabIndex = 16;
            this.buttonXMLLoad.Text = "Load from XML Save";
            this.buttonXMLLoad.UseVisualStyleBackColor = true;
            this.buttonXMLLoad.Click += new System.EventHandler(this.buttonXMLLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.buttonXMLLoad);
            this.Controls.Add(this.buttonXMLSave);
            this.Controls.Add(this.buttonAddLect);
            this.Controls.Add(this.buttonSMS);
            this.Controls.Add(this.labelLecturer);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.comboBoxLecturer);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAddSt);
            this.Controls.Add(this.labelStudents);
            this.Controls.Add(this.listBoxStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxStudents;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Button buttonAddSt;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxLecturer;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelLecturer;
        private System.Windows.Forms.Button buttonSMS;
        private System.Windows.Forms.Button buttonAddLect;
        private System.Windows.Forms.Button buttonXMLSave;
        private System.Windows.Forms.Button buttonXMLLoad;
    }
}

