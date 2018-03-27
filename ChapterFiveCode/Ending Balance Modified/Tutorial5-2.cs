using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance_Modified
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            //Constant for the monthly interest rate.
            const decimal INTEREST_RATE = 0.005m;

            //Local variables.
            decimal balance;
            int months;
            int count = 1;

            //Get the starting balance.
            if (decimal.TryParse(startingBalTextBox.Text, out balance))
            {
                //Get the number of months.
                if (int.TryParse(monthsTextBox.Text, out months))
                {
                    //The following loop calculates the end balance.
                    while (count <= months)
                    {
                        //This adds this month's interest to the balance.
                        balance = balance + (INTEREST_RATE * balance);

                        //This displays this month's ending balance.
                        detailListBox.Items.Add("The ending balance for month " + count + " is "
                            + balance.ToString("c"));

                        //Increment the counter.
                        count++;
                    }

                    //Display the ending balance.
                    endingBalanceLabel.Text = balance.ToString("c");

                }
                else
                {
                    //Invalid number of months was entered.
                    MessageBox.Show("The entered value for the number of months was invalid.");
                }
            }
            else
            {
                //Invalid starting balance was entered.
                MessageBox.Show("The entered value for your balance was invalid.");

            }
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            //Resets the field values.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            //Resets the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
