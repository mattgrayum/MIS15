using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string str = "";
            decimal income = decimal.Parse(txtIncome.Text, System.Globalization.NumberStyles.Currency);
            double homePrice = double.Parse(txtHomePrice.Text, System.Globalization.NumberStyles.Currency);
            double downPmt = double.Parse(txtDownPayment.Text, System.Globalization.NumberStyles.Currency); ;
            double rate = double.Parse(txtRate.Text.Replace
                                      (System.Globalization.CultureInfo.CurrentCulture.NumberFormat.PercentSymbol, ""));
            double years = Convert.ToDouble(txtPeriods.Text);
            decimal affordablePmt = income * .28m;

            rate /= 100;

            decimal monthlyExpense = (decimal)Financial.Pmt(rate/12, years * 12, -(homePrice - downPmt));
            txtMonthlyPmt.Text = monthlyExpense.ToString("c");

            if (monthlyExpense >= affordablePmt)
            {
                int numberOfRoomMates = 0;
                string s = "s";
                decimal dividedAmt = monthlyExpense;

                do
                {
                    numberOfRoomMates++;
                    dividedAmt = monthlyExpense / numberOfRoomMates + 1;
                } while (dividedAmt >= affordablePmt);

                if (numberOfRoomMates == 1)
                {
                    s = "";
                }

                str = "You can afford a monthly payment of " + monthlyExpense.ToString("c2") + " if you split the expense with "
                                        + numberOfRoomMates + " roomate" + s + ".";
                MessageBox.Show(str);
            }

            else if (monthlyExpense >= income * .20m)
            {
                MessageBox.Show("This is an affordable monthly payment.");
            }

            else MessageBox.Show("That's a VERY affordable monthly payment!");

        }

        private void txtHomePrice_Leave(object sender, EventArgs e)
        {
            txtHomePrice.Text = format(txtHomePrice.Text, "c");
        }

        private void txtDownPayment_Leave(object sender, EventArgs e)
        {
            txtDownPayment .Text = format(txtDownPayment.Text, "c");
        }

        private string format(string str, string format)
        {
            string currencyStr;
            double value;
            if (double.TryParse(str, out value))
                return currencyStr = value.ToString(format);
            else
                return "0";
                
        }

        private void txtIncome_Leave(object sender, EventArgs e)
        {
            txtIncome.Text = format(txtIncome.Text, "c");
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            double rate = Convert.ToDouble(txtRate.Text);
            rate /= 100;
            txtRate.Text = rate.ToString("p2");
        }

        private void txtPeriods_Leave(object sender, EventArgs e)
        {
            txtPeriods.Text = format(txtPeriods.Text, "n0");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRate.Text = null;
            txtPeriods.Text = null;
            txtHomePrice.Text = null;
            txtIncome.Text = null;
            txtDownPayment.Text = null;
            txtMonthlyPmt.Text = null;

            txtIncome.Focus();
        }
    }
}
