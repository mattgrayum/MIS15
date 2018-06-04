using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GinRummy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        

        internal void displayCard(Card c)
        {
            pbConfirm.Image = Image.FromFile(c.filePath);
            pbConfirm.ImageLocation = c.filePath;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        public void btnDiscard_Click(object sender, EventArgs e)
        {
            

        }

        private void btnKnock_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void btnGin_Click(object sender, EventArgs e)
        {
            //Close();
        }
    }
}
