namespace Project_4
{
    partial class frmItemFile
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
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblItemFile = new System.Windows.Forms.Label();
            this.listBoxItemFile = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.listBoxItemFile);
            this.panel1.Location = new System.Drawing.Point(201, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 445);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Controls.Add(this.btnRemoveItem);
            this.panel2.Controls.Add(this.btnUndo);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Location = new System.Drawing.Point(795, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 427);
            this.panel2.TabIndex = 8;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddItem.Location = new System.Drawing.Point(9, 45);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(135, 50);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.TabStop = false;
            this.btnAddItem.Text = "&Add Items";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveItem.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRemoveItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoveItem.Location = new System.Drawing.Point(9, 132);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(135, 50);
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.TabStop = false;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUndo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F);
            this.btnUndo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUndo.Location = new System.Drawing.Point(9, 224);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(135, 50);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.TabStop = false;
            this.btnUndo.Text = "Undo Remove";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(9, 323);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Khaki;
            this.panel3.Controls.Add(this.lblItemFile);
            this.panel3.Location = new System.Drawing.Point(8, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(781, 38);
            this.panel3.TabIndex = 9;
            // 
            // lblItemFile
            // 
            this.lblItemFile.AutoSize = true;
            this.lblItemFile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblItemFile.Location = new System.Drawing.Point(27, 5);
            this.lblItemFile.Name = "lblItemFile";
            this.lblItemFile.Size = new System.Drawing.Size(121, 28);
            this.lblItemFile.TabIndex = 1;
            this.lblItemFile.Text = "Inventory";
            // 
            // listBoxItemFile
            // 
            this.listBoxItemFile.BackColor = System.Drawing.Color.Khaki;
            this.listBoxItemFile.Font = new System.Drawing.Font("DejaVu Sans Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItemFile.FormattingEnabled = true;
            this.listBoxItemFile.ItemHeight = 18;
            this.listBoxItemFile.Location = new System.Drawing.Point(8, 52);
            this.listBoxItemFile.Name = "listBoxItemFile";
            this.listBoxItemFile.Size = new System.Drawing.Size(781, 382);
            this.listBoxItemFile.TabIndex = 7;
            this.listBoxItemFile.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortToolStripMenuItem,
            this.addOrEditToolStripMenuItem,
            this.removeItemToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sortToolStripMenuItem
            // 
            this.sortToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.itemTypeToolStripMenuItem,
            this.descriptionToolStripMenuItem,
            this.manufacturerToolStripMenuItem,
            this.priceToolStripMenuItem});
            this.sortToolStripMenuItem.Name = "sortToolStripMenuItem";
            this.sortToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sortToolStripMenuItem.Text = "Sort";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.itemToolStripMenuItem.Text = "Item #";
            this.itemToolStripMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem_Click);
            // 
            // itemTypeToolStripMenuItem
            // 
            this.itemTypeToolStripMenuItem.Name = "itemTypeToolStripMenuItem";
            this.itemTypeToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.itemTypeToolStripMenuItem.Text = "Item Type";
            this.itemTypeToolStripMenuItem.Click += new System.EventHandler(this.itemTypeToolStripMenuItem_Click);
            // 
            // descriptionToolStripMenuItem
            // 
            this.descriptionToolStripMenuItem.Name = "descriptionToolStripMenuItem";
            this.descriptionToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.descriptionToolStripMenuItem.Text = "Description";
            this.descriptionToolStripMenuItem.Click += new System.EventHandler(this.descriptionToolStripMenuItem_Click);
            // 
            // manufacturerToolStripMenuItem
            // 
            this.manufacturerToolStripMenuItem.Name = "manufacturerToolStripMenuItem";
            this.manufacturerToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.manufacturerToolStripMenuItem.Text = "Manufacturer";
            this.manufacturerToolStripMenuItem.Click += new System.EventHandler(this.manufacturerToolStripMenuItem_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.priceToolStripMenuItem.Text = "Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.priceToolStripMenuItem_Click);
            // 
            // addOrEditToolStripMenuItem
            // 
            this.addOrEditToolStripMenuItem.Name = "addOrEditToolStripMenuItem";
            this.addOrEditToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.addOrEditToolStripMenuItem.Text = "Add or Edit";
            this.addOrEditToolStripMenuItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmItemFile
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1200, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmItemFile";
            this.ShowIcon = false;
            this.Text = "Item File";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmItemFile_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblItemFile;
        private System.Windows.Forms.ListBox listBoxItemFile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

