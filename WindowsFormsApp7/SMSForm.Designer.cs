namespace WindowsFormsApp7
{
    partial class SMSForm
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
            this.comboBoxNumbers = new System.Windows.Forms.ComboBox();
            this.textBoxSMSText = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelOwnerNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNumbers
            // 
            this.comboBoxNumbers.FormattingEnabled = true;
            this.comboBoxNumbers.Location = new System.Drawing.Point(12, 12);
            this.comboBoxNumbers.Name = "comboBoxNumbers";
            this.comboBoxNumbers.Size = new System.Drawing.Size(175, 24);
            this.comboBoxNumbers.TabIndex = 0;
            this.comboBoxNumbers.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumbers_SelectedIndexChanged);
            this.comboBoxNumbers.TextChanged += new System.EventHandler(this.comboBoxNumbers_TextChanged);
            // 
            // textBoxSMSText
            // 
            this.textBoxSMSText.Location = new System.Drawing.Point(12, 86);
            this.textBoxSMSText.Multiline = true;
            this.textBoxSMSText.Name = "textBoxSMSText";
            this.textBoxSMSText.Size = new System.Drawing.Size(332, 113);
            this.textBoxSMSText.TabIndex = 1;
            this.textBoxSMSText.TextChanged += new System.EventHandler(this.textBoxSMSText_TextChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Location = new System.Drawing.Point(9, 66);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(35, 17);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Text";
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(12, 205);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(269, 205);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(133, 208);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(0, 17);
            this.labelCount.TabIndex = 6;
            // 
            // labelOwnerNumber
            // 
            this.labelOwnerNumber.AutoSize = true;
            this.labelOwnerNumber.Location = new System.Drawing.Point(193, 19);
            this.labelOwnerNumber.Name = "labelOwnerNumber";
            this.labelOwnerNumber.Size = new System.Drawing.Size(0, 17);
            this.labelOwnerNumber.TabIndex = 8;
            // 
            // SMSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 237);
            this.Controls.Add(this.labelOwnerNumber);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxSMSText);
            this.Controls.Add(this.comboBoxNumbers);
            this.Name = "SMSForm";
            this.Text = "SMSForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMSForm_FormClosing);
            this.Load += new System.EventHandler(this.SMSForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNumbers;
        private System.Windows.Forms.TextBox textBoxSMSText;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelOwnerNumber;
    }
}