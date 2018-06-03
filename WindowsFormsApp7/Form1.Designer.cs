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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.comboBoxLecturer = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelLecturer = new System.Windows.Forms.Label();
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
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(335, 38);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(335, 67);
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
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(336, 96);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 5;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 450);
            this.Controls.Add(this.labelLecturer);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.comboBoxLecturer);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ComboBox comboBoxLecturer;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelLecturer;
    }
}

