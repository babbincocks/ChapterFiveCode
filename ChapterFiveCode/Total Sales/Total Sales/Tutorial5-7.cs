using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables.
                decimal sales;
                decimal total = 0m;

                //Declares a StreamReader.
                StreamReader inputFile;

                //Opens the file being searched and creates a StreamReader object.
                inputFile = File.OpenText("Sales.txt");

                //Reads the file's contents.
                while (!inputFile.EndOfStream)
                {
                    //Get a sales amount.
                    sales = decimal.Parse(inputFile.ReadLine());

                    //Adds the sales amount to the total variable.
                    total += sales;
                }

                //Closes the file.
                inputFile.Close();

                //Finally, the total is displayed.
                totalLabel.Text = total.ToString("c");

            }
            catch (Exception ex)
            {
                //This displays an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Closes this form.
            this.Close();
        }
    }
}
