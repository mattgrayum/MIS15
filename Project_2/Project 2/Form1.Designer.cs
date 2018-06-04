namespace Project_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboEmployeeType = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtSalesRevenue = new System.Windows.Forms.TextBox();
            this.txtSalesCommission = new System.Windows.Forms.TextBox();
            this.txtTotalPay = new System.Windows.Forms.TextBox();
            this.labelEmployeeType = new System.Windows.Forms.Label();
            this.labelHoursWorked = new System.Windows.Forms.Label();
            this.labelSalesRevenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(182, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cboEmployeeType);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtHoursWorked);
            this.panel2.Controls.Add(this.txtSalesRevenue);
            this.panel2.Controls.Add(this.txtSalesCommission);
            this.panel2.Controls.Add(this.txtTotalPay);
            this.panel2.Controls.Add(this.labelEmployeeType);
            this.panel2.Controls.Add(this.labelHoursWorked);
            this.panel2.Controls.Add(this.labelSalesRevenue);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCalculate);
            this.panel2.Location = new System.Drawing.Point(14, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(986, 370);
            this.panel2.TabIndex = 10;
            // 
            // cboEmployeeType
            // 
            this.cboEmployeeType.BackColor = System.Drawing.SystemColors.Window;
            this.cboEmployeeType.FormattingEnabled = true;
            this.cboEmployeeType.Items.AddRange(new object[] {
            "Salary + Commission",
            "Hourly + Commission",
            "Hourly Only"});
            this.cboEmployeeType.Location = new System.Drawing.Point(306, 107);
            this.cboEmployeeType.Name = "cboEmployeeType";
            this.cboEmployeeType.Size = new System.Drawing.Size(165, 24);
            this.cboEmployeeType.TabIndex = 0;
            this.cboEmployeeType.SelectedIndexChanged += new System.EventHandler(this.ResetFields);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SlateGray;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(739, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 41);
            this.btnExit.TabIndex = 11;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 63);
            this.panel3.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 35);
            this.label6.TabIndex = 22;
            this.label6.Text = "Employee Pay Calculator";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(306, 155);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(105, 22);
            this.txtHoursWorked.TabIndex = 1;
            this.txtHoursWorked.TextChanged += new System.EventHandler(this.ResetFields);
            // 
            // txtSalesRevenue
            // 
            this.txtSalesRevenue.Location = new System.Drawing.Point(306, 205);
            this.txtSalesRevenue.Name = "txtSalesRevenue";
            this.txtSalesRevenue.Size = new System.Drawing.Size(105, 22);
            this.txtSalesRevenue.TabIndex = 2;
            this.txtSalesRevenue.TextChanged += new System.EventHandler(this.ResetFields);
            // 
            // txtSalesCommission
            // 
            this.txtSalesCommission.Location = new System.Drawing.Point(746, 155);
            this.txtSalesCommission.Name = "txtSalesCommission";
            this.txtSalesCommission.ReadOnly = true;
            this.txtSalesCommission.Size = new System.Drawing.Size(100, 22);
            this.txtSalesCommission.TabIndex = 20;
            this.txtSalesCommission.TabStop = false;
            // 
            // txtTotalPay
            // 
            this.txtTotalPay.Location = new System.Drawing.Point(746, 205);
            this.txtTotalPay.Name = "txtTotalPay";
            this.txtTotalPay.ReadOnly = true;
            this.txtTotalPay.Size = new System.Drawing.Size(100, 22);
            this.txtTotalPay.TabIndex = 19;
            this.txtTotalPay.TabStop = false;
            // 
            // labelEmployeeType
            // 
            this.labelEmployeeType.AutoSize = true;
            this.labelEmployeeType.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeType.Location = new System.Drawing.Point(110, 107);
            this.labelEmployeeType.Name = "labelEmployeeType";
            this.labelEmployeeType.Size = new System.Drawing.Size(165, 26);
            this.labelEmployeeType.TabIndex = 18;
            this.labelEmployeeType.Text = "Employee Type";
            // 
            // labelHoursWorked
            // 
            this.labelHoursWorked.AutoSize = true;
            this.labelHoursWorked.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoursWorked.Location = new System.Drawing.Point(110, 155);
            this.labelHoursWorked.Name = "labelHoursWorked";
            this.labelHoursWorked.Size = new System.Drawing.Size(155, 26);
            this.labelHoursWorked.TabIndex = 17;
            this.labelHoursWorked.Text = "Hours Worked";
            // 
            // labelSalesRevenue
            // 
            this.labelSalesRevenue.AutoSize = true;
            this.labelSalesRevenue.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesRevenue.Location = new System.Drawing.Point(110, 205);
            this.labelSalesRevenue.Name = "labelSalesRevenue";
            this.labelSalesRevenue.Size = new System.Drawing.Size(161, 26);
            this.labelSalesRevenue.TabIndex = 16;
            this.labelSalesRevenue.Text = "Sales Revenue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(546, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sales Commission";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 13;
            this.label1.Text = "Total Pay";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SlateGray;
            this.btnCalculate.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(306, 281);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 41);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1236, 515);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Pay Calculator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboEmployeeType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtSalesRevenue;
        private System.Windows.Forms.TextBox txtSalesCommission;
        private System.Windows.Forms.TextBox txtTotalPay;
        private System.Windows.Forms.Label labelEmployeeType;
        private System.Windows.Forms.Label labelHoursWorked;
        private System.Windows.Forms.Label labelSalesRevenue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
    }
}

