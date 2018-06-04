namespace Graduation_Calculator
{
    partial class Form1
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtRequiredCredits = new System.Windows.Forms.TextBox();
            this.txtCreditsCompleted = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboSemester = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCalcCredits = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(261, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Required number of credits to graduate:";
            // 
            // txtRequiredCredits
            // 
            this.txtRequiredCredits.Location = new System.Drawing.Point(294, 32);
            this.txtRequiredCredits.Name = "txtRequiredCredits";
            this.txtRequiredCredits.Size = new System.Drawing.Size(100, 22);
            this.txtRequiredCredits.TabIndex = 0;
            // 
            // txtCreditsCompleted
            // 
            this.txtCreditsCompleted.Location = new System.Drawing.Point(294, 60);
            this.txtCreditsCompleted.Name = "txtCreditsCompleted";
            this.txtCreditsCompleted.Size = new System.Drawing.Size(100, 22);
            this.txtCreditsCompleted.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Completed credits to date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "I want to graduate by the end of:";
            // 
            // cboSemester
            // 
            this.cboSemester.FormattingEnabled = true;
            this.cboSemester.Location = new System.Drawing.Point(294, 88);
            this.cboSemester.Name = "cboSemester";
            this.cboSemester.Size = new System.Drawing.Size(121, 24);
            this.cboSemester.TabIndex = 2;
            this.cboSemester.TextUpdate += new System.EventHandler(this.cboSemester_TextUpdate);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "You will need to complete";
            // 
            // txtCalcCredits
            // 
            this.txtCalcCredits.Location = new System.Drawing.Point(198, 158);
            this.txtCalcCredits.Name = "txtCalcCredits";
            this.txtCalcCredits.Size = new System.Drawing.Size(24, 22);
            this.txtCalcCredits.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(27, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(121, 34);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "credits per semester.";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(440, 285);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCalcCredits);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboSemester);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCreditsCompleted);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRequiredCredits);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.Text = "Graduation Credits Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGradCredits;
        private System.Windows.Forms.TextBox txtCreditsComplete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCreditsPerSem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRequiredCredits;
        private System.Windows.Forms.TextBox txtCreditsCompleted;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboSemester;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCalcCredits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label11;
    }
}

