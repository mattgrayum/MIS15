using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCaluclator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int changeDue;
            if(int.TryParse(txtChangeDue.Text, out changeDue))
            {
                int quarters = (changeDue - (changeDue % 25)) / 25;
                changeDue -= quarters * 25;

                int dimes = (changeDue - (changeDue % 10)) / 10;
                changeDue -= dimes * 10;

                int nickels = (changeDue - (changeDue % 5)) / 5;
                changeDue -= nickels * 5;

                int pennies = changeDue;
                changeDue -= pennies;

                txtPennies.Text = pennies.ToString();
                txtNickels.Text = nickels.ToString();
                txtDimes.Text = dimes.ToString();
                txtQuarters.Text = quarters.ToString();
            }
            else
            {
                MessageBox.Show("You must enter an integer value");
            }
        }
    }
}
