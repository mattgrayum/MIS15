namespace GinRummy
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
            this.btnDeal = new System.Windows.Forms.Button();
            this.pbDiscard = new System.Windows.Forms.PictureBox();
            this.pbDeck = new System.Windows.Forms.PictureBox();
            this.pbMyHand8 = new System.Windows.Forms.PictureBox();
            this.panelMyDeck = new System.Windows.Forms.Panel();
            this.pbMyHand2 = new System.Windows.Forms.PictureBox();
            this.pbMyHand3 = new System.Windows.Forms.PictureBox();
            this.pbMyHand4 = new System.Windows.Forms.PictureBox();
            this.pbMyHand5 = new System.Windows.Forms.PictureBox();
            this.pbMyHand6 = new System.Windows.Forms.PictureBox();
            this.pbMyHand7 = new System.Windows.Forms.PictureBox();
            this.pbMyHand1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserScore = new System.Windows.Forms.TextBox();
            this.txtComputerScore = new System.Windows.Forms.TextBox();
            this.listAutoHand = new System.Windows.Forms.ListBox();
            this.listUsersHand = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShowHands = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listDiscard = new System.Windows.Forms.ListBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand8)).BeginInit();
            this.panelMyDeck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeal.Location = new System.Drawing.Point(1019, 100);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(200, 36);
            this.btnDeal.TabIndex = 0;
            this.btnDeal.Text = "Deal";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // pbDiscard
            // 
            this.pbDiscard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDiscard.Location = new System.Drawing.Point(487, 100);
            this.pbDiscard.Name = "pbDiscard";
            this.pbDiscard.Size = new System.Drawing.Size(100, 146);
            this.pbDiscard.TabIndex = 2;
            this.pbDiscard.TabStop = false;
            this.pbDiscard.Click += new System.EventHandler(this.pbDiscard_Click);
            // 
            // pbDeck
            // 
            this.pbDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDeck.Location = new System.Drawing.Point(362, 100);
            this.pbDeck.Name = "pbDeck";
            this.pbDeck.Size = new System.Drawing.Size(100, 146);
            this.pbDeck.TabIndex = 3;
            this.pbDeck.TabStop = false;
            this.pbDeck.Click += new System.EventHandler(this.pbDeck_Click);
            // 
            // pbMyHand8
            // 
            this.pbMyHand8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand8.Location = new System.Drawing.Point(425, 525);
            this.pbMyHand8.Name = "pbMyHand8";
            this.pbMyHand8.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand8.TabIndex = 10;
            this.pbMyHand8.TabStop = false;
            this.pbMyHand8.Click += new System.EventHandler(this.pbMyHand8_Click);
            // 
            // panelMyDeck
            // 
            this.panelMyDeck.Controls.Add(this.pbMyHand2);
            this.panelMyDeck.Controls.Add(this.pbMyHand3);
            this.panelMyDeck.Controls.Add(this.pbMyHand4);
            this.panelMyDeck.Controls.Add(this.pbMyHand5);
            this.panelMyDeck.Controls.Add(this.pbMyHand6);
            this.panelMyDeck.Controls.Add(this.pbMyHand7);
            this.panelMyDeck.Controls.Add(this.pbMyHand1);
            this.panelMyDeck.Location = new System.Drawing.Point(40, 340);
            this.panelMyDeck.Name = "panelMyDeck";
            this.panelMyDeck.Size = new System.Drawing.Size(910, 166);
            this.panelMyDeck.TabIndex = 11;
            // 
            // pbMyHand2
            // 
            this.pbMyHand2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand2.Location = new System.Drawing.Point(155, 10);
            this.pbMyHand2.Name = "pbMyHand2";
            this.pbMyHand2.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand2.TabIndex = 16;
            this.pbMyHand2.TabStop = false;
            this.pbMyHand2.Click += new System.EventHandler(this.pbMyHand2_Click);
            // 
            // pbMyHand3
            // 
            this.pbMyHand3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand3.Location = new System.Drawing.Point(280, 10);
            this.pbMyHand3.Name = "pbMyHand3";
            this.pbMyHand3.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand3.TabIndex = 15;
            this.pbMyHand3.TabStop = false;
            this.pbMyHand3.Click += new System.EventHandler(this.pbMyHand3_Click);
            // 
            // pbMyHand4
            // 
            this.pbMyHand4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand4.Location = new System.Drawing.Point(405, 10);
            this.pbMyHand4.Name = "pbMyHand4";
            this.pbMyHand4.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand4.TabIndex = 14;
            this.pbMyHand4.TabStop = false;
            this.pbMyHand4.Click += new System.EventHandler(this.pbMyHand4_Click);
            // 
            // pbMyHand5
            // 
            this.pbMyHand5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand5.Location = new System.Drawing.Point(530, 10);
            this.pbMyHand5.Name = "pbMyHand5";
            this.pbMyHand5.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand5.TabIndex = 13;
            this.pbMyHand5.TabStop = false;
            this.pbMyHand5.Click += new System.EventHandler(this.pbMyHand5_Click);
            // 
            // pbMyHand6
            // 
            this.pbMyHand6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand6.Location = new System.Drawing.Point(655, 10);
            this.pbMyHand6.Name = "pbMyHand6";
            this.pbMyHand6.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand6.TabIndex = 12;
            this.pbMyHand6.TabStop = false;
            this.pbMyHand6.Click += new System.EventHandler(this.pbMyHand6_Click);
            // 
            // pbMyHand7
            // 
            this.pbMyHand7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand7.Location = new System.Drawing.Point(780, 10);
            this.pbMyHand7.Name = "pbMyHand7";
            this.pbMyHand7.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand7.TabIndex = 11;
            this.pbMyHand7.TabStop = false;
            this.pbMyHand7.Click += new System.EventHandler(this.pbMyHand7_Click);
            // 
            // pbMyHand1
            // 
            this.pbMyHand1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMyHand1.Location = new System.Drawing.Point(30, 10);
            this.pbMyHand1.Name = "pbMyHand1";
            this.pbMyHand1.Size = new System.Drawing.Size(100, 146);
            this.pbMyHand1.TabIndex = 10;
            this.pbMyHand1.TabStop = false;
            this.pbMyHand1.Click += new System.EventHandler(this.pbMyHand1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtUserScore);
            this.groupBox1.Controls.Add(this.txtComputerScore);
            this.groupBox1.Font = new System.Drawing.Font("Poor Richard", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(1019, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Computer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "You:";
            // 
            // txtUserScore
            // 
            this.txtUserScore.Location = new System.Drawing.Point(136, 35);
            this.txtUserScore.Name = "txtUserScore";
            this.txtUserScore.Size = new System.Drawing.Size(52, 28);
            this.txtUserScore.TabIndex = 1;
            // 
            // txtComputerScore
            // 
            this.txtComputerScore.Location = new System.Drawing.Point(136, 69);
            this.txtComputerScore.Name = "txtComputerScore";
            this.txtComputerScore.Size = new System.Drawing.Size(52, 28);
            this.txtComputerScore.TabIndex = 0;
            // 
            // listAutoHand
            // 
            this.listAutoHand.FormattingEnabled = true;
            this.listAutoHand.ItemHeight = 16;
            this.listAutoHand.Location = new System.Drawing.Point(1124, 358);
            this.listAutoHand.Name = "listAutoHand";
            this.listAutoHand.Size = new System.Drawing.Size(95, 148);
            this.listAutoHand.TabIndex = 13;
            // 
            // listUsersHand
            // 
            this.listUsersHand.FormattingEnabled = true;
            this.listUsersHand.ItemHeight = 16;
            this.listUsersHand.Location = new System.Drawing.Point(1019, 358);
            this.listUsersHand.Name = "listUsersHand";
            this.listUsersHand.Size = new System.Drawing.Size(95, 148);
            this.listUsersHand.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1016, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "User\'s Hand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1121, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Computer\'s Hand";
            // 
            // btnShowHands
            // 
            this.btnShowHands.Location = new System.Drawing.Point(1084, 512);
            this.btnShowHands.Name = "btnShowHands";
            this.btnShowHands.Size = new System.Drawing.Size(99, 25);
            this.btnShowHands.TabIndex = 17;
            this.btnShowHands.Text = "Show Hands";
            this.btnShowHands.UseVisualStyleBackColor = true;
            this.btnShowHands.Click += new System.EventHandler(this.btnShowHands_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Discard Pile";
            // 
            // listDiscard
            // 
            this.listDiscard.FormattingEnabled = true;
            this.listDiscard.ItemHeight = 16;
            this.listDiscard.Location = new System.Drawing.Point(646, 100);
            this.listDiscard.Name = "listDiscard";
            this.listDiscard.Size = new System.Drawing.Size(95, 148);
            this.listDiscard.TabIndex = 18;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnNewGame.Location = new System.Drawing.Point(1019, 36);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 36);
            this.btnNewGame.TabIndex = 20;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 562);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listDiscard);
            this.Controls.Add(this.btnShowHands);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listUsersHand);
            this.Controls.Add(this.listAutoHand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMyDeck);
            this.Controls.Add(this.pbMyHand8);
            this.Controls.Add(this.pbDeck);
            this.Controls.Add(this.pbDiscard);
            this.Controls.Add(this.btnDeal);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Gin Rummy";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand8)).EndInit();
            this.panelMyDeck.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMyHand1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.PictureBox pbDiscard;
        private System.Windows.Forms.PictureBox pbDeck;
        private System.Windows.Forms.PictureBox pbMyHand8;
        private System.Windows.Forms.Panel panelMyDeck;
        private System.Windows.Forms.PictureBox pbMyHand2;
        private System.Windows.Forms.PictureBox pbMyHand3;
        private System.Windows.Forms.PictureBox pbMyHand4;
        private System.Windows.Forms.PictureBox pbMyHand5;
        private System.Windows.Forms.PictureBox pbMyHand6;
        private System.Windows.Forms.PictureBox pbMyHand7;
        private System.Windows.Forms.PictureBox pbMyHand1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserScore;
        private System.Windows.Forms.TextBox txtComputerScore;
        private System.Windows.Forms.ListBox listAutoHand;
        private System.Windows.Forms.ListBox listUsersHand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShowHands;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listDiscard;
        private System.Windows.Forms.Button btnNewGame;
    }
}

