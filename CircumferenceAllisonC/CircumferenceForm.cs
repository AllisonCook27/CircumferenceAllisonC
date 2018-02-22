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
        double radius, circumference;
        const double pi = 3.14;

        public frmCircumference()
        {
            InitializeComponent();
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
                circumference = radius * pi * 2;
                circumference = Math.Round(circumference, 2);
                lblCircumference = Convert.ToString(circumference) + "cm" ;

            }
            else
            {
                MessageBox.Show("Please input a positive number.")
            }


        }
    }
}
