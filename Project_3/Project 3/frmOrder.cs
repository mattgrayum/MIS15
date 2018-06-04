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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        // Features above and beyond the assignment specs:
            // Data validation includes highlighted fields that need attention
            // Date and time are included in the order display
            // User can save orders to a text file with the [Save] button on order form
            // A [Clear Form] button on the order form
        
        frmMenu menu = new frmMenu();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure the user selects a table from the drop down menu
                if (cboTable.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose a table from the drop-down menu",
                                    "Entry Error");
                    HighlightComboboxError(cboTable, lblTable);
                    cboTable.Focus();
                }
                else
                {
                    DialogResult result = new DialogResult();

                    do
                    {
                        result = menu.ShowDialog();

                    } while (menu.hasInvalidData);  // Keep showing the dialog untill all data is good

                    if (result == DialogResult.OK)
                    {
                        // Populate string array with data from dialog box
                        string[,] order = { { " ", " " },
                                            { " ", "\t\tOrder taken at: " + DateTime.Now.ToShortTimeString() +
                                              " on " + DateTime.Now.ToShortDateString()},
                                            { "  " + this.cboTable.Text + " table order:", " "},
                                            { " ", " " },
                                            { "       Order Type", menu.orderType },
                                            { "       Main Dish", menu.protein +
                                              " - [" + menu.cookingInstructions + "]"},
                                            { "       Side Dish", menu.side },
                                            { "       Dessert", menu.dessert }
                                          };

                        listBoxOrder.Items.Clear();

                        // Display contents of string array in ListBox on form
                        for (int i = 0; i < order.GetLength(0); i++)
                        {
                            string orderLine = "";
                            for (int j = 0; j < order.GetLength(1); j++)
                            {
                                orderLine += order[i, j] + "\t";
                            }
                            listBoxOrder.Items.Add(orderLine);
                        }
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        ClearOrderForm();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                ex.StackTrace, "Exception");
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the order to a text file
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "Text File|*.txt";
            fd.Title = "Save File As";
            fd.ShowDialog();

            if (fd.FileName != "")
            {
                // Saves the order to the file path that the user chose
                try
                {
                    string [] strArray = new string[listBoxOrder.Items.Count];
                    for(int i = 0; i < listBoxOrder.Items.Count; i++)
                    {
                        strArray[i] = listBoxOrder.Items[i].ToString();
                    }

                    System.IO.File.AppendAllLines(fd.FileName, strArray);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                    ex.StackTrace, "Exception");
                }
            }
        }

        private static void HighlightComboboxError(ComboBox cbo, Label lb)
        {
            // Sets label color to red and combobox back-color to pink 
            // Makes it clear to user which fields need attention

            cbo.BackColor = System.Drawing.Color.Pink;
            lb.ForeColor = System.Drawing.Color.Red;
            cbo.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrderForm();
        }

        private void ClearOrderForm()
        {
            cboTable.SelectedIndex = -1;
            listBoxOrder.Items.Clear();
            cboTable.Focus();
        }
    }
}
