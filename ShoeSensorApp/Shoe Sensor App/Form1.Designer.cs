namespace Shoe_Sensor_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bxLstActual = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bxLstEntered = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAvgForce = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalForce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtActualForce = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecordedForce = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 480);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bxLstActual);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.bxLstEntered);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCount);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtAvgForce);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtTotalForce);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtActualForce);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtRecordedForce);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 472);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Imprint MT Shadow", 4.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 435);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 9);
            this.label8.TabIndex = 38;
            this.label8.Text = "Lion Industries LLC";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(47, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(82, 76);
            this.panel3.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bell MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 31);
            this.label7.TabIndex = 36;
            this.label7.Text = "Insole Impact Sensor Calculator";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 35;
            this.label6.Text = "Actual Values";
            // 
            // bxLstActual
            // 
            this.bxLstActual.BackColor = System.Drawing.Color.Khaki;
            this.bxLstActual.FormattingEnabled = true;
            this.bxLstActual.ItemHeight = 16;
            this.bxLstActual.Location = new System.Drawing.Point(499, 105);
            this.bxLstActual.Name = "bxLstActual";
            this.bxLstActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bxLstActual.Size = new System.Drawing.Size(120, 276);
            this.bxLstActual.TabIndex = 34;
            this.bxLstActual.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(367, 393);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(252, 39);
            this.btnRemove.TabIndex = 33;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "Remove Selected Item";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(364, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "Entered Values";
            // 
            // bxLstEntered
            // 
            this.bxLstEntered.BackColor = System.Drawing.Color.Khaki;
            this.bxLstEntered.FormattingEnabled = true;
            this.bxLstEntered.ItemHeight = 16;
            this.bxLstEntered.Location = new System.Drawing.Point(367, 105);
            this.bxLstEntered.Name = "bxLstEntered";
            this.bxLstEntered.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bxLstEntered.Size = new System.Drawing.Size(120, 276);
            this.bxLstEntered.TabIndex = 31;
            this.bxLstEntered.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 30;
            this.label5.Text = "Entry count:";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.Color.Khaki;
            this.txtCount.Location = new System.Drawing.Point(234, 277);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(100, 22);
            this.txtCount.TabIndex = 29;
            this.txtCount.TabStop = false;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(51, 265);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 34);
            this.btnClear.TabIndex = 28;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Average force per step:";
            // 
            // txtAvgForce
            // 
            this.txtAvgForce.BackColor = System.Drawing.Color.Khaki;
            this.txtAvgForce.Location = new System.Drawing.Point(234, 210);
            this.txtAvgForce.Name = "txtAvgForce";
            this.txtAvgForce.Size = new System.Drawing.Size(100, 22);
            this.txtAvgForce.TabIndex = 26;
            this.txtAvgForce.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Total force exerted:";
            // 
            // txtTotalForce
            // 
            this.txtTotalForce.BackColor = System.Drawing.Color.Khaki;
            this.txtTotalForce.Location = new System.Drawing.Point(234, 182);
            this.txtTotalForce.Name = "txtTotalForce";
            this.txtTotalForce.Size = new System.Drawing.Size(100, 22);
            this.txtTotalForce.TabIndex = 24;
            this.txtTotalForce.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Actual force exerted:";
            // 
            // txtActualForce
            // 
            this.txtActualForce.BackColor = System.Drawing.Color.Khaki;
            this.txtActualForce.Location = new System.Drawing.Point(234, 105);
            this.txtActualForce.Name = "txtActualForce";
            this.txtActualForce.Size = new System.Drawing.Size(100, 22);
            this.txtActualForce.TabIndex = 22;
            this.txtActualForce.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Enter impact force:";
            // 
            // txtRecordedForce
            // 
            this.txtRecordedForce.BackColor = System.Drawing.Color.Khaki;
            this.txtRecordedForce.Location = new System.Drawing.Point(234, 77);
            this.txtRecordedForce.Name = "txtRecordedForce";
            this.txtRecordedForce.Size = new System.Drawing.Size(100, 22);
            this.txtRecordedForce.TabIndex = 0;
            this.txtRecordedForce.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecordedForce_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(712, 522);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Shoe Sensor App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox bxLstActual;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox bxLstEntered;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAvgForce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalForce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActualForce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecordedForce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
    }
}

