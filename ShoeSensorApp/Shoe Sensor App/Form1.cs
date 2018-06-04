using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoe_Sensor_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            txtTotalForce.Text = "0";
            txtAvgForce.Text = "0";
            txtCount.Text = "0";
            bxLstEntered.Items.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   
            //clears or zeros out all text boxes and lists

            txtTotalForce.Text = "0";
            txtAvgForce.Text = "0";
            txtCount.Text = "0";
            txtRecordedForce.Text = null;
            txtActualForce.Text = null;

            //clear list boxes
            bxLstEntered.Items.Clear();
            bxLstActual.Items.Clear();

            //give entry box focus so user can enter a value
            txtRecordedForce.Focus();
        }

        private void txtRecordedForce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //select network to adjust the entered value based on force reduction rules

                float force;
                if (float.TryParse(txtRecordedForce.Text, out force))       //verify that entered value is a number
                {
                    if (force <= 50)
                    {
                        txtActualForce.Text = Convert.ToString(Math.Round(force * .95, 2));
                    }
                    else if (force <= 250)
                    {
                        txtActualForce.Text = Convert.ToString(Math.Round(force * .90, 2));
                    }
                    else if (force <= 500)
                    {
                        txtActualForce.Text = Convert.ToString(Math.Round(force * .85, 2));
                    }
                    else if (force <= 1000)
                    {
                        txtActualForce.Text = Convert.ToString(Math.Round(force * .80, 2));
                    }
                    else txtActualForce.Text = Convert.ToString(Math.Round(force * .75, 2));

                //round the user-entered value to two decimal places
                string roundedValue = Convert.ToString(Math.Round((float.Parse(txtRecordedForce.Text)), 2));

                //populate the list boxes with the new entry
                bxLstEntered.Items.Add(roundedValue);
                bxLstActual.Items.Add(txtActualForce.Text);

                //calculate total, average, and increase counter by one
                calcSummary();

                e.Handled = true;
            }
                else
                {
                    MessageBox.Show("You have entered a non-numerical value \n\n     Please re-enter");
                    clearEntryBox();      
                }   
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //allows user to select a recorded value in the "Entered Values" list box and remove it

            int i = bxLstEntered.SelectedIndex;                     //gets the index number of the selected item
            bxLstEntered.Items.Remove(bxLstEntered.SelectedItem);
            bxLstActual.Items.Remove(bxLstActual.Items[i]);         //removes matching "Actual Value" list box item

            //re-calculates count, total, and average and gives entry box focus for next entry
            calcSummary();

            //clear "ActualForce" textbox for cleaner look 
            txtActualForce.Text = null;

        }

        private void calcSummary()
        {
            //this module iterates through the "Actual Values" list box to calculate a count, total, and average

            float total = 0;
            int count = 0;

            for (int i = 0; i < bxLstActual.Items.Count; i++)
            {
                float value = float.Parse(Convert.ToString(bxLstActual.Items[i]));
                total = total + value;
                count++;
            }

            txtTotalForce.Text = Convert.ToString(Math.Round(total, 2));
            txtAvgForce.Text = Convert.ToString(Math.Round((total / count), 2));
            txtCount.Text = Convert.ToString(count);

            //clear the entry box for and give focus so user can enter the next value
            clearEntryBox();
        }

        private void clearEntryBox()
        {
            txtRecordedForce.Text = null;
            txtRecordedForce.Focus();
        }
    }
}
