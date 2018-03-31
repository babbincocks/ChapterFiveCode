using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinTosses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            try
            {
                //Variable to determine which side is currently "up".
                int sideUp;

                //Then a new random object is created.
                Random rand = new Random();

                //Then a random number is generated, with a range of 0-1, with 1 being treated as heads-up, and 0 being
                //treated as tails-up.
                sideUp = rand.Next(2);

                //Then a decision is made using an if-else statement, depending on the value that the sideUp variable has 
                //now. If 1, the heads picture is made visible and tails made invisible; if 0, vice versa.
                if (sideUp == 1)
                {
                    pbHeads.Visible = true;
                    pbTails.Visible = false;
                }
                else
                {
                    pbTails.Visible = true;
                    pbHeads.Visible = false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
