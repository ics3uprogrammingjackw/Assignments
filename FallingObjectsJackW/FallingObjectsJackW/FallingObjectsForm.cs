/*
 * Created by: Jack Wright
 * Created on: 08-Feb-19
 * Created for: ICS3U Programming
 * Assignment #2 - Falling objects 
 * This program calculates how far a thrown object would be off the ground at a time depending on the users input
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FallingObjectsJackW
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmFallingObjects_Load(object sender, EventArgs e)
        {

        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {

            // Does not allow the user to input anything other than numbers and decimals
            txtAnswer.Text = Regex.Match(txtAnswer.Text, @"\d+(?:[\.][\d]*)?").Value;

            // Solves error where the cursor goes to the start of the text box in certain scenarios
            txtAnswer.SelectionStart = txtAnswer.Text.Length;

            if (txtAnswer.Text == "")
            {
                lblAnswer.Text = "?";

            }
            else
            {

                // converts user input to a double
                double time = Convert.ToDouble(txtAnswer.Text);

               
                // Calculates answer and rounds to two decimals
                double height = Convert.ToDouble(Math.Round(100 * (100 - (0.5 * 9.81 * Math.Pow(time, 2)))) / 100);
                if (height >= 0)
                {
                    

                    // Displays answer
                    lblAnswer.Text = Convert.ToString(height);

                }
                else
                {
                    // displays the answer as zero if the input would make the answer a negative number (below the ground)
                    lblAnswer.Text = "0";

                }
            }
        }
        private void lblStatement1_Click(object sender, EventArgs e)
        {

        }
    }
}
