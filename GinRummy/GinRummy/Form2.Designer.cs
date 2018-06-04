namespace GinRummy
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbConfirm = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnGin = new System.Windows.Forms.Button();
            this.btnKnock = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbConfirm);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnGin);
            this.panel1.Controls.Add(this.btnKnock);
            this.panel1.Controls.Add(this.btnDiscard);
            this.panel1.Location = new System.Drawing.Point(79, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 340);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "What would you like to do with this card?";
            // 
            // pbConfirm
            // 
            this.pbConfirm.Location = new System.Drawing.Point(75, 112);
            this.pbConfirm.Name = "pbConfirm";
            this.pbConfirm.Size = new System.Drawing.Size(100, 146);
            this.pbConfirm.TabIndex = 9;
            this.pbConfirm.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(228, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 32);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGin
            // 
            this.btnGin.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnGin.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnGin.Location = new System.Drawing.Point(228, 187);
            this.btnGin.Name = "btnGin";
            this.btnGin.Size = new System.Drawing.Size(95, 32);
            this.btnGin.TabIndex = 7;
            this.btnGin.Text = "Gin!";
            this.btnGin.UseVisualStyleBackColor = true;
            this.btnGin.Click += new System.EventHandler(this.btnGin_Click);
            // 
            // btnKnock
            // 
            this.btnKnock.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnKnock.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnKnock.Location = new System.Drawing.Point(228, 140);
            this.btnKnock.Name = "btnKnock";
            this.btnKnock.Size = new System.Drawing.Size(95, 32);
            this.btnKnock.TabIndex = 6;
            this.btnKnock.Text = "Knock";
            this.btnKnock.UseVisualStyleBackColor = true;
            this.btnKnock.Click += new System.EventHandler(this.btnKnock_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDiscard.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold);
            this.btnDiscard.Location = new System.Drawing.Point(228, 93);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(95, 32);
            this.btnDiscard.TabIndex = 5;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 474);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.ShowIcon = false;
            this.Text = "Confirm Card Selection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbConfirm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGin;
        private System.Windows.Forms.Button btnKnock;
        private System.Windows.Forms.Button btnDiscard;
    }
}