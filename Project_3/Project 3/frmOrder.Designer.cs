namespace Project_3
{
    partial class frmOrder
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
            this.cboTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboTable
            // 
            this.cboTable.FormattingEnabled = true;
            this.cboTable.Items.AddRange(new object[] {
            "Blue",
            "Green",
            "Red",
            "Yellow",
            "Gray"});
            this.cboTable.Location = new System.Drawing.Point(165, 77);
            this.cboTable.Name = "cboTable";
            this.cboTable.Size = new System.Drawing.Size(121, 24);
            this.cboTable.TabIndex = 0;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(111, 77);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(48, 17);
            this.lblTable.TabIndex = 1;
            this.lblTable.Text = "Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Order Details:";
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSelectItem.Location = new System.Drawing.Point(452, 78);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Size = new System.Drawing.Size(100, 36);
            this.btnSelectItem.TabIndex = 4;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSave.Location = new System.Drawing.Point(114, 306);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 36);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(452, 306);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 36);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 16;
            this.listBoxOrder.Location = new System.Drawing.Point(114, 134);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(439, 148);
            this.listBoxOrder.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(284, 306);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(636, 481);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cboTable);
            this.Name = "frmOrder";
            this.ShowIcon = false;
            this.Text = "Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Button btnClear;
    }
}

