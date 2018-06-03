namespace WindowsFormsApp7
{
    partial class StudentInfo
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
            this.labelLecturer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelStdLecturer = new System.Windows.Forms.Label();
            this.labelStdName = new System.Windows.Forms.Label();
            this.labelAssessments = new System.Windows.Forms.Label();
            this.textBoxSetAssessment = new System.Windows.Forms.TextBox();
            this.labelAssessment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLecturer
            // 
            this.labelLecturer.AutoSize = true;
            this.labelLecturer.Location = new System.Drawing.Point(12, 9);
            this.labelLecturer.Name = "labelLecturer";
            this.labelLecturer.Size = new System.Drawing.Size(61, 17);
            this.labelLecturer.TabIndex = 13;
            this.labelLecturer.Text = "Lecturer";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 17);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(257, 251);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 96);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 15;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // labelStdLecturer
            // 
            this.labelStdLecturer.AutoSize = true;
            this.labelStdLecturer.Location = new System.Drawing.Point(85, 9);
            this.labelStdLecturer.Name = "labelStdLecturer";
            this.labelStdLecturer.Size = new System.Drawing.Size(46, 17);
            this.labelStdLecturer.TabIndex = 16;
            this.labelStdLecturer.Text = "label1";
            // 
            // labelStdName
            // 
            this.labelStdName.AutoSize = true;
            this.labelStdName.Location = new System.Drawing.Point(85, 39);
            this.labelStdName.Name = "labelStdName";
            this.labelStdName.Size = new System.Drawing.Size(46, 17);
            this.labelStdName.TabIndex = 17;
            this.labelStdName.Text = "label2";
            // 
            // labelAssessments
            // 
            this.labelAssessments.AutoSize = true;
            this.labelAssessments.Location = new System.Drawing.Point(13, 70);
            this.labelAssessments.Name = "labelAssessments";
            this.labelAssessments.Size = new System.Drawing.Size(91, 17);
            this.labelAssessments.TabIndex = 18;
            this.labelAssessments.Text = "Assessments";
            // 
            // textBoxSetAssessment
            // 
            this.textBoxSetAssessment.Location = new System.Drawing.Point(219, 252);
            this.textBoxSetAssessment.Name = "textBoxSetAssessment";
            this.textBoxSetAssessment.Size = new System.Drawing.Size(32, 22);
            this.textBoxSetAssessment.TabIndex = 19;
            // 
            // labelAssessment
            // 
            this.labelAssessment.AutoSize = true;
            this.labelAssessment.Location = new System.Drawing.Point(110, 70);
            this.labelAssessment.Name = "labelAssessment";
            this.labelAssessment.Size = new System.Drawing.Size(0, 17);
            this.labelAssessment.TabIndex = 21;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 308);
            this.Controls.Add(this.labelAssessment);
            this.Controls.Add(this.textBoxSetAssessment);
            this.Controls.Add(this.labelAssessments);
            this.Controls.Add(this.labelStdName);
            this.Controls.Add(this.labelStdLecturer);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelLecturer);
            this.Controls.Add(this.labelName);
            this.Name = "StudentInfo";
            this.Text = "StudentInfo";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLecturer;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelStdLecturer;
        private System.Windows.Forms.Label labelStdName;
        private System.Windows.Forms.Label labelAssessments;
        private System.Windows.Forms.TextBox textBoxSetAssessment;
        private System.Windows.Forms.Label labelAssessment;
    }
}