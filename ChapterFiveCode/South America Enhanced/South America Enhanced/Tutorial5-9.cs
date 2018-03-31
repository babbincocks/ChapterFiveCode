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



        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //First off, a variable needs to be created to hold the country name that's about to be added.
                string country;

                //Then a StreamReader variable needs to be created.
                StreamReader inputFile;

                //The country list file is then opened and a StreamReader object is created.
                inputFile = File.OpenText("Countries.txt");

                //Then a while loop is created to go as long as the there's another file for the inputFile variable to
                //contain.
                while (!inputFile.EndOfStream)
                {
                    //The loop starts with retrieving a country name from the file.
                    country = inputFile.ReadLine();

                    //The country is then added to the list box. The next country will automatically be chosen,
                    //due to the format of the document, and because I used ReadLine in the code above, as opposed to
                    //Read.
                    lbCountries.Items.Add(country);
                }
                //The file's then closed.
                inputFile.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
