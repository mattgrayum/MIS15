namespace Project_4
{
    partial class frmItemEntry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoPackaged = new System.Windows.Forms.RadioButton();
            this.rdoFresh = new System.Windows.Forms.RadioButton();
            this.lbDescript = new System.Windows.Forms.Label();
            this.txtItemNum = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbManufact = new System.Windows.Forms.Label();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.lbItemNum = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtManufact = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(219, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(616, 363);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lbDescript);
            this.panel2.Controls.Add(this.txtItemNum);
            this.panel2.Controls.Add(this.lbPrice);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.lbManufact);
            this.panel2.Controls.Add(this.txtDescript);
            this.panel2.Controls.Add(this.lbItemNum);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.txtManufact);
            this.panel2.Location = new System.Drawing.Point(9, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 347);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.rdoPackaged);
            this.groupBox1.Controls.Add(this.rdoFresh);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(162, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Type";
            // 
            // rdoPackaged
            // 
            this.rdoPackaged.AutoSize = true;
            this.rdoPackaged.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPackaged.Location = new System.Drawing.Point(6, 36);
            this.rdoPackaged.Name = "rdoPackaged";
            this.rdoPackaged.Size = new System.Drawing.Size(102, 21);
            this.rdoPackaged.TabIndex = 6;
            this.rdoPackaged.Text = "&Packaged";
            this.rdoPackaged.UseVisualStyleBackColor = true;
            this.rdoPackaged.CheckedChanged += new System.EventHandler(this.radioButtonCheckChanged);
            // 
            // rdoFresh
            // 
            this.rdoFresh.AutoSize = true;
            this.rdoFresh.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFresh.Location = new System.Drawing.Point(114, 36);
            this.rdoFresh.Name = "rdoFresh";
            this.rdoFresh.Size = new System.Drawing.Size(71, 21);
            this.rdoFresh.TabIndex = 7;
            this.rdoFresh.Text = "&Fresh";
            this.rdoFresh.UseVisualStyleBackColor = true;
            this.rdoFresh.CheckedChanged += new System.EventHandler(this.radioButtonCheckChanged);
            // 
            // lbDescript
            // 
            this.lbDescript.AutoSize = true;
            this.lbDescript.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescript.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDescript.Location = new System.Drawing.Point(159, 153);
            this.lbDescript.Name = "lbDescript";
            this.lbDescript.Size = new System.Drawing.Size(92, 17);
            this.lbDescript.TabIndex = 9;
            this.lbDescript.Text = "Description";
            // 
            // txtItemNum
            // 
            this.txtItemNum.Location = new System.Drawing.Point(300, 125);
            this.txtItemNum.Name = "txtItemNum";
            this.txtItemNum.Size = new System.Drawing.Size(162, 22);
            this.txtItemNum.TabIndex = 0;
            this.txtItemNum.TextChanged += new System.EventHandler(this.txtItemNum_TextChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPrice.Location = new System.Drawing.Point(159, 209);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(47, 17);
            this.lbPrice.TabIndex = 5;
            this.lbPrice.Text = "Price";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(340, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Close Form";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(300, 209);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(162, 22);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lbManufact
            // 
            this.lbManufact.AutoSize = true;
            this.lbManufact.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbManufact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbManufact.Location = new System.Drawing.Point(159, 181);
            this.lbManufact.Name = "lbManufact";
            this.lbManufact.Size = new System.Drawing.Size(107, 17);
            this.lbManufact.TabIndex = 7;
            this.lbManufact.Text = "Manufacturer";
            // 
            // txtDescript
            // 
            this.txtDescript.Location = new System.Drawing.Point(300, 153);
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(162, 22);
            this.txtDescript.TabIndex = 1;
            this.txtDescript.TextChanged += new System.EventHandler(this.txtDescript_TextChanged);
            // 
            // lbItemNum
            // 
            this.lbItemNum.AutoSize = true;
            this.lbItemNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItemNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbItemNum.Location = new System.Drawing.Point(159, 125);
            this.lbItemNum.Name = "lbItemNum";
            this.lbItemNum.Size = new System.Drawing.Size(102, 17);
            this.lbItemNum.TabIndex = 3;
            this.lbItemNum.Text = "Item Number";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(162, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save Record";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtManufact
            // 
            this.txtManufact.Location = new System.Drawing.Point(300, 181);
            this.txtManufact.Name = "txtManufact";
            this.txtManufact.Size = new System.Drawing.Size(162, 22);
            this.txtManufact.TabIndex = 2;
            this.txtManufact.TextChanged += new System.EventHandler(this.txtManufact_TextChanged);
            // 
            // frmItemEntry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1039, 453);
            this.Controls.Add(this.panel1);
            this.Name = "frmItemEntry";
            this.ShowIcon = false;
            this.Text = "Item Entry Form";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoPackaged;
        private System.Windows.Forms.RadioButton rdoFresh;
        private System.Windows.Forms.Label lbDescript;
        private System.Windows.Forms.TextBox txtItemNum;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lbManufact;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.Label lbItemNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtManufact;
    }
}