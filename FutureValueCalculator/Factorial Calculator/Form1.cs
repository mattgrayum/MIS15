using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial_Calculator
{
    public partial class frmFactorialCalculator : Form
    {
        public frmFactorialCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            decimal factorial = 1;
            string formatStr; 

            for (int i = number; i > 0; i--)
                factorial *= i;

            if (factorial > 1000000000)
                formatStr = "e2";
            else formatStr = "n0";
            
            txtFactorial.Text = factorial.ToString(formatStr);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = null;
            txtFactorial.Text = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
