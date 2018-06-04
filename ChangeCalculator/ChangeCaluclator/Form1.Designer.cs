namespace ChangeCaluclator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtChangeDue = new System.Windows.Forms.TextBox();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Due:";
            // 
            // txtChangeDue
            // 
            this.txtChangeDue.Location = new System.Drawing.Point(128, 24);
            this.txtChangeDue.Name = "txtChangeDue";
            this.txtChangeDue.Size = new System.Drawing.Size(100, 22);
            this.txtChangeDue.TabIndex = 1;
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(128, 150);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.Size = new System.Drawing.Size(100, 22);
            this.txtPennies.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dimes";
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(128, 94);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.Size = new System.Drawing.Size(100, 22);
            this.txtDimes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pennies";
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(128, 122);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.Size = new System.Drawing.Size(100, 22);
            this.txtNickels.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nickels";
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(128, 66);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.Size = new System.Drawing.Size(100, 22);
            this.txtQuarters.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quarters";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(24, 213);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(141, 213);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 348);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChangeDue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChangeDue;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

