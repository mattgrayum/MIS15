namespace Project_3
{
    partial class frmMenu
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cboSide = new System.Windows.Forms.ComboBox();
            this.cboDessert = new System.Windows.Forms.ComboBox();
            this.lbItem = new System.Windows.Forms.Label();
            this.lbSide = new System.Windows.Forms.Label();
            this.lbDessert = new System.Windows.Forms.Label();
            this.lbCookingInstructions = new System.Windows.Forms.Label();
            this.txtCookingInstructions = new System.Windows.Forms.TextBox();
            this.listItem = new System.Windows.Forms.ListBox();
            this.chkSavePreferences = new System.Windows.Forms.CheckBox();
            this.rdoToGo = new System.Windows.Forms.RadioButton();
            this.rdoEatIn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(218, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 36);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(349, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cboSide
            // 
            this.cboSide.FormattingEnabled = true;
            this.cboSide.Items.AddRange(new object[] {
            "Baked Potato",
            "Side Salad",
            "Assorted Vegetables",
            "French Fries."});
            this.cboSide.Location = new System.Drawing.Point(89, 233);
            this.cboSide.Name = "cboSide";
            this.cboSide.Size = new System.Drawing.Size(121, 24);
            this.cboSide.TabIndex = 3;
            // 
            // cboDessert
            // 
            this.cboDessert.FormattingEnabled = true;
            this.cboDessert.Items.AddRange(new object[] {
            "Chocolate Cake",
            "Pumpkin Pie",
            "Ice Cream",
            "Cookie"});
            this.cboDessert.Location = new System.Drawing.Point(328, 233);
            this.cboDessert.Name = "cboDessert";
            this.cboDessert.Size = new System.Drawing.Size(121, 24);
            this.cboDessert.TabIndex = 4;
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.Location = new System.Drawing.Point(47, 152);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(34, 17);
            this.lbItem.TabIndex = 7;
            this.lbItem.Text = "Item";
            // 
            // lbSide
            // 
            this.lbSide.AutoSize = true;
            this.lbSide.Location = new System.Drawing.Point(47, 233);
            this.lbSide.Name = "lbSide";
            this.lbSide.Size = new System.Drawing.Size(36, 17);
            this.lbSide.TabIndex = 8;
            this.lbSide.Text = "Side";
            // 
            // lbDessert
            // 
            this.lbDessert.AutoSize = true;
            this.lbDessert.Location = new System.Drawing.Point(265, 233);
            this.lbDessert.Name = "lbDessert";
            this.lbDessert.Size = new System.Drawing.Size(57, 17);
            this.lbDessert.TabIndex = 9;
            this.lbDessert.Text = "Dessert";
            // 
            // lbCookingInstructions
            // 
            this.lbCookingInstructions.AutoSize = true;
            this.lbCookingInstructions.Location = new System.Drawing.Point(208, 152);
            this.lbCookingInstructions.Name = "lbCookingInstructions";
            this.lbCookingInstructions.Size = new System.Drawing.Size(135, 17);
            this.lbCookingInstructions.TabIndex = 10;
            this.lbCookingInstructions.Text = "Cooking Instructions";
            // 
            // txtCookingInstructions
            // 
            this.txtCookingInstructions.Location = new System.Drawing.Point(349, 152);
            this.txtCookingInstructions.Name = "txtCookingInstructions";
            this.txtCookingInstructions.Size = new System.Drawing.Size(100, 22);
            this.txtCookingInstructions.TabIndex = 2;
            // 
            // listItem
            // 
            this.listItem.FormattingEnabled = true;
            this.listItem.ItemHeight = 16;
            this.listItem.Items.AddRange(new object[] {
            "Pork Chop ",
            "Chicken",
            "Fish"});
            this.listItem.Location = new System.Drawing.Point(93, 152);
            this.listItem.Name = "listItem";
            this.listItem.Size = new System.Drawing.Size(100, 52);
            this.listItem.TabIndex = 1;
            // 
            // chkSavePreferences
            // 
            this.chkSavePreferences.AutoSize = true;
            this.chkSavePreferences.Location = new System.Drawing.Point(50, 321);
            this.chkSavePreferences.Name = "chkSavePreferences";
            this.chkSavePreferences.Size = new System.Drawing.Size(143, 21);
            this.chkSavePreferences.TabIndex = 5;
            this.chkSavePreferences.Text = "Save Preferences";
            this.chkSavePreferences.UseVisualStyleBackColor = true;
            // 
            // rdoToGo
            // 
            this.rdoToGo.AutoSize = true;
            this.rdoToGo.Location = new System.Drawing.Point(6, 33);
            this.rdoToGo.Name = "rdoToGo";
            this.rdoToGo.Size = new System.Drawing.Size(69, 21);
            this.rdoToGo.TabIndex = 14;
            this.rdoToGo.TabStop = true;
            this.rdoToGo.Text = "To Go";
            this.rdoToGo.UseVisualStyleBackColor = true;
            // 
            // rdoEatIn
            // 
            this.rdoEatIn.AutoSize = true;
            this.rdoEatIn.Location = new System.Drawing.Point(81, 33);
            this.rdoEatIn.Name = "rdoEatIn";
            this.rdoEatIn.Size = new System.Drawing.Size(65, 21);
            this.rdoEatIn.TabIndex = 15;
            this.rdoEatIn.TabStop = true;
            this.rdoEatIn.Text = "Eat In";
            this.rdoEatIn.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoEatIn);
            this.groupBox1.Controls.Add(this.rdoToGo);
            this.groupBox1.Location = new System.Drawing.Point(93, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Type";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSavePreferences);
            this.Controls.Add(this.listItem);
            this.Controls.Add(this.txtCookingInstructions);
            this.Controls.Add(this.lbCookingInstructions);
            this.Controls.Add(this.lbDessert);
            this.Controls.Add(this.lbSide);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.cboDessert);
            this.Controls.Add(this.cboSide);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.ClearMenu);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboSide;
        private System.Windows.Forms.ComboBox cboDessert;
        private System.Windows.Forms.Label lbItem;
        private System.Windows.Forms.Label lbSide;
        private System.Windows.Forms.Label lbDessert;
        private System.Windows.Forms.Label lbCookingInstructions;
        private System.Windows.Forms.TextBox txtCookingInstructions;
        private System.Windows.Forms.ListBox listItem;
        private System.Windows.Forms.CheckBox chkSavePreferences;
        private System.Windows.Forms.RadioButton rdoToGo;
        private System.Windows.Forms.RadioButton rdoEatIn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}