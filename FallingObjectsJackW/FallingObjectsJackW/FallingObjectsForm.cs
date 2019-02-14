using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

            if (txtAnswer.Text == "")
            {
                lblAnswer.Text = "?";

            }
            else
            {

                //int time = int.Parse(txtAnswer.Text);
                double time = Convert.ToDouble(txtAnswer.Text);
                if (time <= 4.515)
                {
                    double height = Convert.ToDouble(Math.Round(100 * (100 - (0.5 * 9.81 * Math.Pow(time, 2)))) / 100);
                    lblAnswer.Text = Convert.ToString(height);

                }
                else
                {
                    lblAnswer.Text = "0";

                }
            }
        }
        private void lblStatement1_Click(object sender, EventArgs e)
        {

        }
    }
}
