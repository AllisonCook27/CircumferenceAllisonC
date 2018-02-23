/*
 * Created by: Allison Cook
 * Created on: 22 February, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - circumference
 * This program calculates the circumference of a circle for a given radius
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

namespace CircumferenceAllisonC
{
    public partial class frmCircumference : Form
    {
        //Local variables
        double radius, circumference;
        //local constant
        const double PI = 3.14;

        public frmCircumference()
        {
            InitializeComponent();
            lblCircumference.Hide();
            lblAnswerText.Hide();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                radius = double.Parse(txtRadius.Text);
            }
            catch
            {
                MessageBox.Show("Please input a number.");
            }

            if (radius >= 0)
            {
                //calculating the circumference
                circumference = radius * PI * 2;
                //rounding to two decimal places
                circumference = Math.Round(circumference, 2);
                //setting the answer to text
                lblCircumference.Text = Convert.ToString(circumference) + "cm" ;
                //show answer
                lblAnswerText.Show();
                lblCircumference.Show();

            }
            else
            {
                MessageBox.Show("Please input a positive number.");
            }


        }
    }
}
