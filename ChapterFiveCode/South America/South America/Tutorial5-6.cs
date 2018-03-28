using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable to hold a country name.
                string countryName;

                //Declares a StreamReader.
                StreamReader inputFile;

                //Opens the file that will be read and creates a StreamReader object.
                inputFile = File.OpenText("Countries.txt");

                //Clears the Listbox, so the list will be good.
                countriesListBox.Items.Clear();

                //Reads the file's contents.
                while (!inputFile.EndOfStream)
                {
                    //Retrieves a country name.
                    countryName = inputFile.ReadLine();

                    //Adds the country to the Listbox.
                    countriesListBox.Items.Add(countryName);

                }
                //Closes the file.
                inputFile.Close();

            }
            catch (Exception ex)
            {
                //This displays an error message if things go awry.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
