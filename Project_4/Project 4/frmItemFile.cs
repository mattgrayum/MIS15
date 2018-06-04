using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Project_4
{
    public partial class frmItemFile : Form
    {
        bool formDataSaved;
        bool itemFileIsEmpty;
        bool entryModeOn;
        private const int Columns = 5;  // Represents the number of fields in the Item File
        string[] tempRecord = new string[Columns];  // Will hold removed record in case user wants to undo remove action
        //const string FilePath = @"C:\Users\Matthew\Dropbox\MATT\SCHOOL\CSUS\FALL 2016\MIS 15\Project 4\ItemFile.txt";
        const string FilePath = @"ItemFile.txt";

        public frmItemFile()
        {
            InitializeComponent();
        }

        private void frmItemFile_Load(object sender, EventArgs e)
        {
            if(DisplayItemFile(0) == 1)      // If the method returns a 1, that means the ItemFile wasn't found
            {                               // or couldn't be opened
                this.Close();
            }
        }

        private int DisplayItemFile(int sortByIndex)
        {
            try
            {
                listBoxItemFile.Items.Clear();

                // Read in the Item File data to an array
                string[,] recordSet = ReadItemFile(sortByIndex);

                if (recordSet[0, 0] == "file not found")
                {
                    // If file wasn't found or couldn't be opened, return a 1 so the application knows to exit.
                    return 1;
                }
                else if (recordSet[0, 0] == " ")
                {
                    itemFileIsEmpty = true;

                    PrintItemListHeading();

                    // Print ItemFile data (In this case, an empty file message)
                    for (int i = 0; i < recordSet.GetLength(0); i++)
                    {
                        string str = "";
                        str += recordSet[i, 0];
                        str += recordSet[i, 1];

                    listBoxItemFile.Items.Add(str);
                    }
                    return 0; // Lets the application know that Item File data was opened, read, and displayed without error
                }
                else
                {
                    itemFileIsEmpty = false;

                    PrintItemListHeading();

                    // Create a string out of each record and then print it to the List Box
                    for (int i = 0; i < recordSet.GetLength(0); i++)
                    {
                        // It's possible to get blank lines in the Item File
                        // This if statement skips any blank lines to avoid
                        // throwing an "index out of range" exception.
                        if (recordSet[i, 0] != "" && recordSet[i, 0] != null)
                        {
                            string str = "";
                            str += "   " + recordSet[i, 0].PadRight(11);
                            str += recordSet[i, 1].PadRight(12);
                            decimal decPrice = Decimal.Parse(recordSet[i, 2]);
                            str += String.Format("{0:c2}", decPrice).PadLeft(7);
                            str += "      ";
                            str += recordSet[i, 3].PadRight(20);
                            str += "     ";
                            str += recordSet[i, 4].PadRight(20);

                            listBoxItemFile.Items.Add(str);
                        }
                    }
                    return 0;   // Lets the application know that Item File data was opened, read, and displayed without error
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
                return 1;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxItemFile.SelectedIndex != -1) // Makes sure user has selected an item
                {
                    if (itemFileIsEmpty)
                    {
                        MessageBox.Show("There is nothing to remove silly!", "Can't you read?",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(0 <= listBoxItemFile.SelectedIndex && listBoxItemFile.SelectedIndex <= 2)
                    {
                        // If user selects a line in the heading...
                        MessageBox.Show("Invalid selection", "Error", 
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Isolate the selected Item Number
                        string listItemID = listBoxItemFile.SelectedItem.ToString().Substring(3, 5);

                        // Read in the data from Item File to an Array
                        string[,] recordSet = ReadItemFile(0);

                        // Create a second Array that is one row smaller than recordSet to accept updated set of records
                        string[,] newRecordSet = new string[recordSet.GetLength(0) - 1, recordSet.GetLength(1)];

                        // Populate the new Array with all items except the selected item
                        int newRowCount = 0;
                        for (int i = 0; i < recordSet.GetLength(0); i++)
                        {
                            if (recordSet[i, 0] == listItemID)
                            {
                                // Populate temporary record so user can undo remove if they wish
                                for(int t = 0; t < recordSet.GetLength(1); t++)
                                {
                                    tempRecord[t] = recordSet[i, t];
                                }
                            }
                            else
                            {
                                for (int j = 0; j < recordSet.GetLength(1); j++)
                                {
                                    newRecordSet[newRowCount, j] = recordSet[i, j];
                                }
                                newRowCount++;
                            }
                        }

                        // Write the new Array to the ItemFile
                        UpdateItemFile(newRecordSet);

                        // Display updated ItemFile data in the ListBox
                        DisplayItemFile(0);
                    }
                }
                else
                {
                    MessageBox.Show("To remove an item, select it in the list, and then click the [Remove Item] button",
                                    "Remove Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        public string[,] ReadItemFile(int sortByIndex = 0)
        {
            // Read data from Item File and return an Arry holding that data

            try
            {
                if (File.Exists(FilePath))
                {
                    FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
                    StreamReader sr = new StreamReader(fs);

                    // Get the number of rows in the file
                    int rows = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        rows++;
                    }

                    if (rows == 0)
                    {
                        // Give the application a message to print to the List Box display
                        string[,] emptyFileMessage = { { " ", " " }, {" ", " " },
                                                     { "                        ** The Item File is currently empty **", " " } };
                        fs.Close();
                        sr.Close();

                        return emptyFileMessage;
                    }
                    else
                    {
                        // Set position of StreamReader back to the beginning of the file
                        sr.DiscardBufferedData();
                        sr.BaseStream.Seek(0, SeekOrigin.Begin);

                        // Populate the array with data from the file
                        string[] lines = new string[rows];
                        string[,] items = new string[rows, Columns];

                        // Read file into an array of records
                        for (int i = 0; i < rows; i++)
                        {
                            lines[i] = sr.ReadLine();
                        }

                        

                        // Break records up into a two dimensional array of individual data points
                        for (int i = 0; i < rows; i++)
                        {
                            string[] strArray = lines[i].Split('|');

                            if (strArray[0] != "")  // Avoid reading blank lines
                            {
                                for (int j = 0; j < Columns; j++)
                                {
                                    items[i, j] = strArray[j];
                                }
                            }
                        }

                        // Sort by passed Index Number
                        string[,] sortedItems = SortBy(items, sortByIndex);

                        fs.Close();
                        sr.Close();

                        return sortedItems;
                    }
                }
                else
                {
                    MessageBox.Show(FilePath + " does not exist", "File Error");
                    MessageBox.Show("The application will shut down now\n" +
                                    "   We appologize for any inconvenience");

                    // Return array with error message - this alerts the application
                    // to the fact that the file could not be opened.
                    string[,] s = { { "file not found", "" } };
                    return s;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
                string[,] emptyArray = { { " ", " " } };
                return emptyArray;
            }
        }

        private void UpdateItemFile(string[,] arr)
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    string str = "";
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (j < arr.GetLength(1) - 1)
                        {
                            str += arr[i, j] + "|";
                        }
                        else
                        {
                            str += arr[i, j];  // Don't want a pipe at the end of each line
                        }
                    }
                    sw.WriteLine(str);
                }

                sw.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            do
            {
                entryModeOn = false;
                try
                {
                    frmItemEntry entryForm = new Project_4.frmItemEntry();
                    DialogResult response = new DialogResult();

                    do
                    {
                        formDataSaved = true;

                        do
                        {
                            /* Keep showing the Entry Form until either the user has entered correct data in 
                             * all fields or the user clicks [Cancel]
                             */
                            entryForm.StartPosition = FormStartPosition.CenterParent;
                            response = entryForm.ShowDialog();

                        } while (entryForm.hasInvalidData && response != DialogResult.Cancel);

                        // The [Save] button corresponds with DialogResult.OK
                        if (response == DialogResult.OK)
                        {
                            entryModeOn = true;

                            // Create a single, pipe delimited, string from user entered data
                            string str = "";
                            str += entryForm.itemNumber + "|";
                            str += entryForm.itemType + "|";
                            str += entryForm.price + "|";
                            str += entryForm.description + "|";
                            str += entryForm.manufacturer;

                            /* Check to see if there is a record currently on file with the same Item Number
                             * If there is, let the user know and ask if they want to replace it with 
                             * the newly entered data
                             */

                            // Read in the data from Item File to an Array
                            string[,] recordSet = ReadItemFile(0);

                            // Get a list of Item Numbers on file
                            string[] itemNums = new string[recordSet.GetLength(0)];
                            for (int i = 0; i < recordSet.GetLength(0); i++)
                            {
                                itemNums[i] = recordSet[i, 0];
                            }

                            // If there is a matching Item Number on file, ask user if they want to overwrite it
                            if (itemNums.Contains<string>(entryForm.itemNumber))
                            {
                                DialogResult answer = MessageBox.Show
                                    ("A record matching this Item Number already exists.\n\n" +
                                    "Do you want to replace it with the updated entry?", "Warning",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Hand);

                                if (answer == DialogResult.Yes)
                                {
                                    /* Remove the existing record with matching Item Number */

                                    // Create second Array - one row smaller than recordSet to accept updated set 
                                    string[,] newRecordSet = 
                                        new string[recordSet.GetLength(0) - 1, recordSet.GetLength(1)];

                                    // Populate the new Array with all items except the selected item
                                    int newRowCount = 0;
                                    for (int i = 0; i < recordSet.GetLength(0); i++)
                                    {
                                        if (recordSet[i, 0] != entryForm.itemNumber)
                                        {
                                            for (int j = 0; j < recordSet.GetLength(1); j++)
                                            {
                                                newRecordSet[newRowCount, j] = recordSet[i, j];
                                            }
                                            newRowCount++;
                                        }
                                    }
                                    UpdateItemFile(newRecordSet);
                                }
                                else if(answer == DialogResult.No)
                                {
                                    break;  // Return to entry form without saving entered data
                                }
                            }

                            // Add new record to Item File
                            AppendToItemFile(str);

                            // Display updated Item File data in List Box
                            DisplayItemFile(0);

                        }
                        else if (response == DialogResult.Cancel)
                        {
                            if (entryForm.isIncomplete)
                            {
                                DialogResult resp = MessageBox.Show("Changes have not been saved \n\n" +
                                                                    "To return to the entry form and" + 
                                                                    "save your entry, click [OK]", "Warning",
                                                                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                                if (resp == DialogResult.OK)
                                {
                                    formDataSaved = false; // Loop back and make entry form re-appear
                                }
                            }
                            else
                            {
                                entryModeOn = false; // Pop out of loop and return to Item File display
                            }
                        }
                    } while (formDataSaved == false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                     ex.StackTrace, "Exception");
                } 
            } while (entryModeOn);
        }

        public void AppendToItemFile(string str) 
        {
            try
            {
                FileStream fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                // Write the line to the end of the Item File
                sw.WriteLine(str);

                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        private void PrintItemListHeading()
        {
            // Print heading to the List Box
            listBoxItemFile.Items.Add("");
            listBoxItemFile.Items.Add("   Item #     Item Type     Price      Description              Manufacturer");
            listBoxItemFile.Items.Add("   ================================================================================");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                if (tempRecord[0] == "" || tempRecord[0] == null)
                {
                    MessageBox.Show("You cannot undo this action", "Undo Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string str = "";
                    for (int i = 0; i < tempRecord.Length; i++)
                    {
                        if (i < tempRecord.Length - 1)
                        {
                            str += tempRecord[i] + "|";
                        }
                        else
                        {
                            str += tempRecord[i];
                        }
                    }

                    // Adds new item to Item File
                    AppendToItemFile(str);

                    // Displays updated Item File data in List Box
                    DisplayItemFile(0);

                    // Clear contents of tempRecord
                    for (int i = 0; i < tempRecord.Length; i++)
                    {
                        tempRecord[i] = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" +
                                 ex.StackTrace, "Exception");
            }
        }

        private string[,] SortBy(string[,] rs, int sortByIndex)
        {
            // Sort records by passed column index

            string[] lines = new string[rs.GetLength(0)];
            string[,] sortedRs = new string[rs.GetLength(0), Columns];

            if (sortByIndex > 0)
            {
                // Trade places between first element in each line and column to sort by
                for (int i = 0; i < rs.GetLength(0); i++)
                {
                    swapStrings(ref rs[i, 0], ref rs[i, sortByIndex]);
                }
            }

            for (int i = 0; i < rs.GetLength(0); i++)
            {
                // Create an array of lines for sorting
                string str = "";
                for (int j = 0; j < Columns; j++)
                {
                    if (j < Columns - 1)
                    {
                        str += rs[i, j] + "|";
                    }
                    else
                    {
                        str += rs[i, j];
                    }
                }

                lines[i] = str;
            }

            // Sort the lines Array
            bool swapped = true;
            for (int outer = lines.Length; outer > 0; outer--)
            {
                if (swapped == true)
                {
                    swapped = false;
                    for (int inner = 0; inner < outer - 1; inner++)
                    {
                        if(sortByIndex == 2) // If sorting by price, compare decimal values instead of strings
                        {
                            // Separate the two prices from their respective lines
                            string priceString1 = lines[inner].Substring(0, lines[inner].IndexOf('|'));
                            string priceString2 = lines[inner + 1].Substring(0, lines[inner + 1].IndexOf('|'));

                            // Compare the two prices as decimal values rather than strings to sort correctly
                            if (Decimal.Parse(priceString1) > Decimal.Parse(priceString2))
                            {
                                swapStrings(ref lines[inner], ref lines[inner + 1]);
                                swapped = true;
                            }
                        }
                        else
                        {
                            if (String.Compare(lines[inner], lines[inner + 1]) > 0)
                            {
                                swapStrings(ref lines[inner], ref lines[inner + 1]);
                                swapped = true;
                            }
                        }
                    }
                }
                else break;
            }

            // Break records back up into a two dimensional array of individual data points
            string[] strArray = new string[Columns];
            for (int i = 0; i < lines.Length; i++)
            {
                strArray = lines[i].Split('|');

                if (strArray[0] != "")  // Avoid reading blank lines
                {
                    for (int j = 0; j < Columns; j++)
                    {
                        sortedRs[i, j] = strArray[j];
                    }
                }
            }

            // Put fields back in correct order
            if(sortByIndex > 0)
            {
                for (int i = 0; i < rs.GetLength(0); i++)
                {
                    swapStrings(ref sortedRs[i,0], ref sortedRs[i,sortByIndex]);  
                }
            }

            return sortedRs;
        }

        private void swapStrings(ref string x, ref string y)
        {
            string temp = x;
            x = y;
            y = temp;
        }

        private void itemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayItemFile(0);
        }

        private void itemTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayItemFile(1);
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayItemFile(2);
        }

        private void descriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayItemFile(3);
        }

        private void manufacturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayItemFile(4);
        }

    }
}
