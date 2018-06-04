using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidDecimal(txtHoursWorked, labelHoursWorked, "Hours Worked", 0, 80) && 
                    IsValidDecimal(txtSalesRevenue, labelSalesRevenue, "Sales Revenue"))
                {
                    decimal salesCommission = 0m;
                    decimal totalPay = 0m;
                    decimal hoursWorked = decimal.Parse(txtHoursWorked.Text);
                    decimal salesRevenue = decimal.Parse(txtSalesRevenue.Text);


                    switch (cboEmployeeType.SelectedIndex)
                    {
                        // Salary + Commission
                        case 0:
                            {
                                salesCommission = salesRevenue * .02m;
                                totalPay = 300 + salesCommission;
                                break;
                            }
                        // Hourly + Commission
                        case 1:
                            {
                                salesCommission = salesRevenue * .01m;
                                totalPay = (hoursWorked * 12m) + salesCommission;
                                break;
                            }
                        // Hourly Only
                        case 2:
                            {
                                totalPay = (hoursWorked * 16m);
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("You must enter a valid Employee Type", "Entry Error");
                                cboEmployeeType.BackColor = System.Drawing.Color.Pink;
                                labelEmployeeType.ForeColor = System.Drawing.Color.Red;
                                cboEmployeeType.Text = "";
                                cboEmployeeType.Focus();
                                break;
                            }
                    }

                    // Format and print results to Form Text Boxes
                    txtSalesCommission.Text = salesCommission.ToString("c");
                    txtTotalPay.Text = totalPay.ToString("c");
                    cboEmployeeType.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        public bool IsValidDecimal(TextBox txt, Label lb, string name, 
                                   decimal rangeMin = -999999999, decimal rangeMax = 999999999)
        {
            if(IsPresent(txt, lb, name) &&
               IsDecimal(txt, lb, name) &&
               IsInRange(txt, lb, name, rangeMin, rangeMax))
            {
                return true;
            }
            return false;
        }

        public bool IsPresent(TextBox txt, Label lb, string name)
        {
            if(txt.Text == "")
            {
                MessageBox.Show("You must enter a value for " + name, "Entry Error");
                ShowLineIsInError(txt, lb);
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox txt, Label lb, string name)
        {
            decimal value = 0m;

            if (Decimal.TryParse(txt.Text, out value))
            {
                return true;
            }

            MessageBox.Show(name + " must be a decimal value.", "Entry Error");
            ShowLineIsInError(txt, lb);
            return false;
        }

        public bool IsInRange(TextBox txt, Label lb, string name, decimal rangeMin = -999999999, 
                              decimal rangeMax = 999999999)
        {
            decimal value = Decimal.Parse(txt.Text);

            if(rangeMin <= value && value <= rangeMax)
            {
                return true;
            }

            MessageBox.Show(name + " must be between " + rangeMin + " and " + 
                            rangeMax + ".", "Entry Error");
            ShowLineIsInError(txt, lb);
            return false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetFields(object sender, EventArgs e)
        {
            // Ensures TotalPay field is not an inaccurate reflection of input field data

            txtTotalPay.Text = "";

            // Resets label and text box colors after user has fixed an entry error

            labelEmployeeType.ForeColor = System.Drawing.Color.Black;
            labelSalesRevenue.ForeColor = System.Drawing.Color.Black;
            labelHoursWorked.ForeColor = System.Drawing.Color.Black;
            cboEmployeeType.BackColor = System.Drawing.Color.White;
            txtHoursWorked.BackColor = System.Drawing.Color.White;
            txtSalesRevenue.BackColor = System.Drawing.Color.White;
        }

        private static void ShowLineIsInError(TextBox txt, Label lb)
        {
            // Sets label color to red and textbox back-color to pink 
            // Makes it clear to user which fields need attention

            txt.Text = "";
            txt.BackColor = System.Drawing.Color.Pink;
            lb.ForeColor = System.Drawing.Color.Red;
            txt.Focus();
        }                  
    }
}
