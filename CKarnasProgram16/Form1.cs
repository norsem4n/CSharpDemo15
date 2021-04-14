/* Project:         Homework 7 - Assignment Set 16
 * Date:            December 2020
 * Last Modified:   12.11.2020
 * Developed By:    CGK
 * Class Name:      Form
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace CKarnasProgram16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            allChartersToolStripMenuItem.Enabled = false;
            numberOfChartersForYachtSIzeToolStripMenuItem.Enabled = false;
            chartersSummaryToolStripMenuItem.Enabled = false;
            exitToolStripMenuItem.Enabled = true;

            txtCustomer.Focus();
        }

        //declare a class level variable for CharterManager

        private CharterManager aCharterManager;

        private void Module8Ex2_Load(object sender, EventArgs e)
        {
            //cboYachtType.SelectedIndex = -1;
        }

        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            //validate customer name input data

            if (txtCustomer.Text == string.Empty)
            {
                MessageBox.Show("Enter Customer Name", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //vaidate yacht type input data

            if (cboYachtType.SelectedItem == null)
            {
                MessageBox.Show("Select a yacht type", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //validate yacht size input data 

            if (lboxYachtSize.SelectedItem == null)
            {
                MessageBox.Show("Select a yacht size", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //declare method level variables and assign values

            string customerName = txtCustomer.Text;
            string yachtType = cboYachtType.SelectedItem.ToString();
            int yachtSize = Convert.ToInt32(lboxYachtSize.SelectedItem);
            decimal hoursChartered = Convert.ToDecimal(nudHours.Value);
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, hoursChartered);

            //instantiates a YatchManager object(one time only; when the first charter is added)

            if (aCharterManager == null)
            {
                aCharterManager = new CharterManager();
            }

            //calls the appropriate method on the YachtManager object to add the charter

            aCharterManager.AddCharter(customerName, yachtType, yachtSize, hoursChartered);

            //enables the three menu items within the Display menu

            allChartersToolStripMenuItem.Enabled = true;
            numberOfChartersForYachtSIzeToolStripMenuItem.Enabled = true;
            chartersSummaryToolStripMenuItem.Enabled = true;
            
            //disables tools
            btnAddCharter.Enabled = false;
            txtCustomer.Enabled = false;
            nudHours.Enabled = false;
            lboxYachtSize.Enabled = false;
            cboYachtType.Text = null;
        }

        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //display all charters

            Form3 aForm = new Form3();
            aForm.charterManagerBindingSource.DataSource = aCharterManager;
            aForm.ShowDialog();
        }

        private void numberOfChartersForYachtSIzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //error message if size not selected

            if (lboxYachtSize.SelectedIndex == -1)
            {
                MessageBox.Show("Select a yacht size", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //once selected, give the number of charters in a message box

            int charterCount;

            charterCount = aCharterManager.GetCharterCount(Convert.ToInt32(lboxYachtSize.SelectedItem));

            MessageBox.Show($"The number of charters for the {lboxYachtSize.SelectedItem} foot sized Yacht is {charterCount}", "Yacht Size Total Charters", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartersSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 aForm = new Form4();

            //display lowest charter fee

            aForm.lblLowestFeeDisplay.Text =  aCharterManager.FindLowestCharterFee().ToString("c");

            //the total fees from all charters

            aForm.lblTotalFeeDisplay.Text = aCharterManager.GetTotalCharterFees().ToString("c");

            //and the average fee of all the charters

            aForm.lblAvgFeeDisplay.Text = aCharterManager.GetAvgCharterFee().ToString("c");
            aForm.charterManagerBindingSource.DataSource = aCharterManager;
            aForm.ShowDialog();
        }

        private void addYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cboYachtType.Text == string.Empty)
            {
                MessageBox.Show("Enter a new yacht type", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newMember = cboYachtType.Text;  //assign the new member to be added to a variable
            bool duplicate = false;  // duplication indicator 

            //a foreach loop to iterate through the items in the list and check for potential duplication

            foreach (string aItem in cboYachtType.Items) //for each item in the combo box
            {
                
                if (string.Equals(newMember, aItem, StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be added
                {
                    duplicate = true; //if the member already exists in the list, set duplication indicator to true
                    break; //break out of the loop
                }
            }

            if (duplicate)  //if duplicate is true, new member is not added
            {
                MessageBox.Show("Yacht type already exits", "Well, this is awkward...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYachtType.Text = string.Empty;
            }
            else  //otherwise, new member is added
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo; //create a TextInfo object based on "en-US" culture

                newMember = aTextInfo.ToTitleCase(newMember); //change the name of the new member to be added to proper case

                cboYachtType.Items.Add(newMember); //add the new member to the list
                MessageBox.Show("New yacht type added", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYachtType.Text = string.Empty;
            }
        }

        private void removeYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // validate yacht type input 

            if (cboYachtType.Text == string.Empty)
            {
                MessageBox.Show("Enter a yacht type to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cboYachtType.Items.RemoveAt(cboYachtType.SelectedIndex); //remove selected member from list
                MessageBox.Show("Yacht has been removed", "Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYachtType.Text = string.Empty;
            }
        }
      
        private void resetForNextCharterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //reset input controls

            txtCustomer.Clear();
            
            btnAddCharter.Enabled = true;
            txtCustomer.Enabled = true;
            nudHours.Enabled = true;
            lboxYachtSize.Enabled = true;

            nudHours.Value = nudHours.Minimum;
            cboYachtType.SelectedIndex = -1;
            lboxYachtSize.SelectedIndex = -1;
            txtCustomer.Focus();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
