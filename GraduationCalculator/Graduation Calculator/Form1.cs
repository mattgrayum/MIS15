using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graduation_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            const int ListLength = 6;
            string currentSemester;
            string currentYear = Convert.ToString(DateTime.Today.Year);

            if (DateTime.Today.Month <= 5)
            {
                currentSemester = "Spring ";
            }
            else currentSemester = "Fall ";

            cboSemester.Items.Add(currentSemester + currentYear);

            if(currentSemester == "Spring")
            {
                for(int i = 0; i < ListLength; i++)
                {
                    cboSemester.Items.Add("Fall " + currentYear);
                    currentYear = Convert.ToString(DateTime.Today.Year + (i + 1));
                    cboSemester.Items.Add("Spring " + currentYear);
                }
            }
            else
            {
                for(int i = 0; i < ListLength; i++)
                {
                    currentYear = Convert.ToString(DateTime.Today.Year + (i + 1));
                    cboSemester.Items.Add("Spring " + currentYear);
                    cboSemester.Items.Add("Fall " + currentYear);
                }
            }
        }

        private void cboSemester_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int unitsToGo = int.Parse(txtRequiredCredits.Text) - int.Parse(txtCreditsCompleted.Text);
            int semestersToGo = cboSemester.SelectedIndex + 1;

            txtCalcCredits.Text = Convert.ToString(unitsToGo / semestersToGo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRequiredCredits.Text = null;
            txtCreditsCompleted.Text = null;
            txtCalcCredits.Text = null;
            txtRequiredCredits.Focus();
        }
    }
}
