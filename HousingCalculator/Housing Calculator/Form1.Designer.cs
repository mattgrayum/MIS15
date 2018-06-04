namespace Housing_Calculator
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
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHomePrice = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonthlyPmt = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIncome
            // 
            this.txtIncome.Location = new System.Drawing.Point(356, 39);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(100, 22);
            this.txtIncome.TabIndex = 0;
            this.txtIncome.Leave += new System.EventHandler(this.txtIncome_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monthly Gross Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Purchase Price of Home";
            // 
            // txtHomePrice
            // 
            this.txtHomePrice.Location = new System.Drawing.Point(205, 70);
            this.txtHomePrice.Name = "txtHomePrice";
            this.txtHomePrice.Size = new System.Drawing.Size(100, 22);
            this.txtHomePrice.TabIndex = 1;
            this.txtHomePrice.Leave += new System.EventHandler(this.txtHomePrice_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(205, 182);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interest Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(205, 126);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 3;
            this.txtRate.Leave += new System.EventHandler(this.txtRate_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Down Payment";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(205, 98);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(100, 22);
            this.txtDownPayment.TabIndex = 2;
            this.txtDownPayment.Leave += new System.EventHandler(this.txtDownPayment_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mortgage Period (years)";
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(205, 154);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(100, 22);
            this.txtPeriods.TabIndex = 4;
            this.txtPeriods.Leave += new System.EventHandler(this.txtPeriods_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Monthly Mortgage Payment";
            // 
            // txtMonthlyPmt
            // 
            this.txtMonthlyPmt.Location = new System.Drawing.Point(356, 240);
            this.txtMonthlyPmt.Name = "txtMonthlyPmt";
            this.txtMonthlyPmt.Size = new System.Drawing.Size(100, 22);
            this.txtMonthlyPmt.TabIndex = 5;
            this.txtMonthlyPmt.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(356, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 398);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonthlyPmt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPeriods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHomePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIncome);
            this.Name = "Form1";
            this.Text = "Mortgage Payment Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHomePrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthlyPmt;
        private System.Windows.Forms.Button btnClear;
    }
}

