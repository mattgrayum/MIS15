using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class frmItemEntry : Form
    {
        public string itemType = "";
        public string itemNumber = "";
        public string price = "";
        public string description = "";
        public string manufacturer = "";
        public bool hasInvalidData;
        public bool isIncomplete;

        public frmItemEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetFields();
        }

        private bool ValidData()
        {
            try
            {
                // Make sure one of the radio buttons is checked
                if (!(rdoFresh.Checked || rdoPackaged.Checked))
                {
                    MessageBox.Show("Please select the 'Fresh' or 'Packaged' designation for this item.", "Entry Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HighlightRadioButtonError(rdoFresh);
                    HighlightRadioButtonError(rdoPackaged);
                    return false;
                }

                // Make sure all textboxes have data entered
                else if (IsNotPresent(txtItemNum, lbItemNum) ||
                         IsNotPresent(txtDescript, lbDescript) ||
                         IsNotPresent(txtManufact, lbManufact) ||
                         IsNotPresent(txtPrice, lbPrice))
                {
                    return false;
                }

                // Make sure 'Price' is a valid decimal value
                else if (IsNotDecimal(txtPrice, lbPrice))
                {
                    return false;
                }

                // Make sure Item Number is 5 characters in length
                else if (txtItemNum.Text.Length != 5)
                {
                    MessageBox.Show("Item Number must be 5 characters long", "Entry Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HighlightTextboxError(txtItemNum, lbItemNum);

                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
                return false;
            }
        }

        private bool IsNotPresent(TextBox txt, Label lb)
        {
            /* Using this method makes code easier to read
             * by avoiding using !IsPresent
             */

            try
            {
                if (IsPresent(txt, lb))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
                return true;
            }
        }

        private bool IsPresent(TextBox txt, Label lb)
        {
            try
            {
                if (txt.Text == "")
                {
                    MessageBox.Show("An entry is required for every field", "Entry Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    HighlightTextboxError(txt, lb);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
                return false;
            }
        }

        private bool IsNotDecimal(TextBox txt, Label lb)
        {
            try
            {
                decimal value = 0m;
                if (Decimal.TryParse(txt.Text, out value))
                {
                    return false;
                }
                MessageBox.Show("You must enter a decimal value for 'Price'", "Entry Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                HighlightTextboxError(txt, lb);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
                return true;
            }
        }

        private static void HighlightRadioButtonError(RadioButton rdo)
        {
            // Sets label color to red and radio button back-color to pink 
            // Makes it clear to user which fields need attention

            rdo.BackColor = System.Drawing.Color.Pink;
            rdo.ForeColor = System.Drawing.Color.Red;
        }

        private static void HighlightTextboxError(TextBox txt, Label lb)
        {
            // Sets label color to red and textbox back-color to pink 
            // Makes it clear to user which fields need attention

            //txt.Text = "";
            txt.BackColor = System.Drawing.Color.Pink;
            lb.ForeColor = System.Drawing.Color.Red;
            txt.Focus();
        }

        private void SetFields()
        {
            try
            {
                hasInvalidData = false;
                if (ValidData())
                {
                    if (rdoFresh.Checked)
                    {
                        itemType = "Fresh";
                    }
                    else
                    {
                        itemType = "Packaged";
                    }

                    itemNumber = txtItemNum.Text;
                    price = txtPrice.Text;
                    description = txtDescript.Text;
                    manufacturer = txtManufact.Text;

                    isIncomplete = false;
                }
                else
                {
                    hasInvalidData = true;
                    isIncomplete = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        private void txtItemNum_TextChanged(object sender, EventArgs e)
        {
            // Reset color in case it was turned red by data entry error
            resetTextBoxColor(txtItemNum, lbItemNum);

            /* As the user enters each character into the Item Number field,
             * the rest of the fields will auto populate with a matching
             * record
             */

            try
            {
                if (txtItemNum.Text.Length <= 5)
                {
                    // Read in data from the Item File
                    frmItemFile frm = new Project_4.frmItemFile();
                    string[,] recordSet = frm.ReadItemFile();

                    // Get the number of characters that have been entered
                    int len = txtItemNum.Text.Length;

                    if (len == 0)
                    {
                        ClearTextBoxes();
                        ClearRadioButtons();
                    }
                    else
                    {
                        for (int i = 0; i < recordSet.GetLength(0); i++)
                        {
                            // Avoid "index out of range" exception if there are empty records
                            if (recordSet[i, 0] != null && recordSet[i, 0] != "" && recordSet[i,0] != " ") 
                            {
                                /* Find the first record that matches the part of the Item Number
                                 * that the user has entered so far and populate form fields with 
                                 * associated data from that record
                                 */

                                if (recordSet[i, 0].Substring(0, len) == txtItemNum.Text.Substring(0, len))
                                {
                                    if (txtItemNum.Text.Length == 5)
                                    {
                                        // Only autopopulate radio button if entire Item # is entered
                                        if (recordSet[i, 1] == "Packaged")
                                        {
                                            rdoPackaged.Checked = true;
                                        }
                                        else
                                        {
                                            rdoFresh.Checked = true;
                                        }
                                    }
                                    txtPrice.Text = recordSet[i, 2];
                                    txtDescript.Text = recordSet[i, 3];
                                    txtManufact.Text = recordSet[i, 4];
                                    break;
                                }
                                else
                                {
                                    /* Clear form fields if user changes Item Number so that
                                     * it no longer matches an existing record
                                     */
                                    ClearTextBoxes();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        private void resetTextBoxColor(TextBox txt, Label lb)
        {
            txt.BackColor = System.Drawing.Color.White;
            lb.ForeColor = System.Drawing.Color.White;
        }

        private void txtDescript_TextChanged(object sender, EventArgs e)
        {
            // Reset color in case it was turned red by data entry error
            resetTextBoxColor(txtDescript, lbDescript);
        }

        private void txtManufact_TextChanged(object sender, EventArgs e)
        {
            // Reset color in case it was turned red by data entry error
            resetTextBoxColor(txtManufact, lbManufact);
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Reset color in case it was turned red by data entry error
            resetTextBoxColor(txtPrice, lbPrice);
        }

        private void radioButtonCheckChanged(object sender, EventArgs e)
        {
            // Reset color in case it was turned red by data entry error
            resetRadioButtonColors();

            // Give Item Number field focus so user doesn't have to click into it with mouse
            txtItemNum.Focus();
        }

        private void resetRadioButtonColors()
        {
            rdoFresh.BackColor = System.Drawing.Color.DarkSlateGray;
            rdoFresh.ForeColor = System.Drawing.Color.White;
            rdoPackaged.BackColor = System.Drawing.Color.DarkSlateGray;
            rdoPackaged.ForeColor = System.Drawing.Color.White;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            /* If form is completely empty, with no data entered, mark it as complete
             * so the "data not saved" message doesn't appear
             */

            if(((rdoPackaged.Checked == false) && (rdoFresh.Checked == false)) &&
                txtItemNum.Text == "" &&
                txtDescript.Text == "" &&
                txtManufact.Text == "" &&
                txtPrice.Text == "")
            {
                isIncomplete = false;
            }
            else
            {
                /* If user has entered some data, mark as incomplete so 
                 * "data not saved" message will pop up
                 */

                isIncomplete = true;
            } 
        }

        private void ClearTextBoxes()
        {
            //txtItemNum.Text = "";
            txtDescript.Text = "";
            txtManufact.Text = "";
            txtPrice.Text = "";
        }

        private void ClearRadioButtons()
        {
            rdoFresh.Checked = false;
            rdoPackaged.Checked = false;
        }
    }
}
