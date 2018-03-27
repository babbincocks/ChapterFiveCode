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

namespace Friend_File_Enhanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a StreamWriter variable.
                StreamWriter outputFile;

                //Create or append a file and create a StreamWriter object.
                outputFile = File.AppendText("Friend.txt");

                //Write the friend's name to the file.
                outputFile.WriteLine(nameTextBox.Text);

                //Then close the file.
                outputFile.Close();

                //The user is then told that the name was written.
                MessageBox.Show("Oi, you! The name was written.");

                //Clear the name input text box.
                nameTextBox.Text = "";

                //Return focus to the name input text box.
                nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                //Displays an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
