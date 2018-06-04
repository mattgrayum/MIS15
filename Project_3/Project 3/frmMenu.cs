using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        // properties that can be accessed from the order form code
        public string orderType;
        public string protein;
        public string cookingInstructions;
        public string side;
        public string dessert;
        public bool hasInvalidData;

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                hasInvalidData = false;
                if (ValidData())
                {
                    // assign orderType property based on which radio button is checked
                    if (rdoToGo.Checked)
                    {
                        orderType = "To Go";
                    }
                    else if (rdoEatIn.Checked)
                    {
                        orderType = "Eat In";
                    }

                    // Give cookingInstructions property a default value if nothing is entered
                    if(txtCookingInstructions.Text == "")
                    {
                        cookingInstructions = "No cooking instructions included";
                    }
                    else
                    {
                        cookingInstructions = txtCookingInstructions.Text;
                    }

                    // assign protein, side, and dessert properties
                    protein = listItem.SelectedItem.ToString();
                    side = cboSide.SelectedItem.ToString();
                    dessert = cboDessert.SelectedItem.ToString();
                }
                else
                {
                    hasInvalidData = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        private bool ValidData()
        {
            // Make sure one of the radio buttons is checked
            if(!(rdoToGo.Checked || rdoEatIn.Checked))
            {
                MessageBox.Show("Indicate whether you'd like to 'Eat In' or take your order 'To Go'");
                HighlightRadioButtonError(rdoToGo);
                HighlightRadioButtonError(rdoEatIn);
                return false;
            }
            // Make sure a Main Dish is selected
            else if(listItem.SelectedIndex < 0)
            {
                MessageBox.Show("You must select an item from the list of Main Dishes");
                HighlightListboxError(listItem, lbItem);
                return false;
            }
            // Make sure a Side and a Dessert are selected
            else if(NoComboBoxSelection(cboSide, lbSide) || NoComboBoxSelection(cboDessert, lbDessert))
            {
                return false;
            }
            return true;
        }

        private bool NoComboBoxSelection(ComboBox cbo, Label lb)
        {
            if(cbo.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a " + lb.Text + " to go with your order");
                HighlightComboboxError(cbo, lb);
                return true;
            }
            return false;
        }

        private static void HighlightTextboxError(TextBox txt, Label lb)
        {
            // Sets label color to red and textbox back-color to pink 
            // Makes it clear to user which fields need attention

            txt.Text = "";
            txt.BackColor = System.Drawing.Color.Pink;
            lb.ForeColor = System.Drawing.Color.Red;
            txt.Focus();
        }

        private static void HighlightComboboxError(ComboBox cbo, Label lb)
        {
            // Sets label color to red and combobox back-color to pink 
            // Makes it clear to user which fields need attention

            cbo.BackColor = System.Drawing.Color.Pink;
            lb.ForeColor = System.Drawing.Color.Red;
            cbo.Focus();
        }

        private static void HighlightListboxError(ListBox listBox, Label lb)
        {
            // Sets label color to red and list box back-color to pink 
            // Makes it clear to user which fields need attention

            listBox.BackColor = System.Drawing.Color.Pink;
            lb.ForeColor = System.Drawing.Color.Red;
            listBox.Focus();
        }

        private static void HighlightRadioButtonError(RadioButton rdo)
        {
            // Sets label color to red and radio button back-color to pink 
            // Makes it clear to user which fields need attention

            rdo.BackColor = System.Drawing.Color.Pink;
            rdo.ForeColor = System.Drawing.Color.Red;
        }

        private void ClearMenu(object sender, EventArgs e)
        {
            rdoToGo.Checked = false;
            rdoEatIn.Checked = false;
            txtCookingInstructions.Text = "";
            cboDessert.SelectedIndex = -1;
            cboSide.SelectedIndex = -1;
            listItem.SelectedIndex = -1;

        }
    }
}
