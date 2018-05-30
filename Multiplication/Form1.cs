/********************************************************************
 * Assignment from SDEV 240                                         *
 * Coded by: Harley Ehrman                                          *
 *                                                                  *
 * From book:                                                       *
 * Microsoft Visual C# 2015:                                        *
 * An Introduction to Object-Oriented Programming 6th Edition       *
 * by Joyce Farrell                                                 *
 *                                                                  *
 * Instructions (Page 307, Exercise 6):                             *
 * Create an application named Multiplication whose Main() method   *
 * the user to input an integer and then calls a method named       *
 * DisplayMultiplicationTable(), which displays the results of      *
 * multiplying the integer by each of the numbers 2 through 10.     *
 ********************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication
{
    public partial class MultiTable : Form
    {
        public MultiTable()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            double multi;

            //set if to validate for numbers only in input
            if (double.TryParse(txtInput.Text, out multi))
            {
                //declare and assign variable
                multi = Convert.ToInt32(txtInput.Text);

                //call DisplaMultiplicationTable method
                DisplaMultiplicationTable(multi);
            }
            else
            {
                lblOutput.Text = "ERROR!" + "\n" + "You must" + "\n" + "enter a" + "\n" + "number.";
            }  
        }
        private void DisplaMultiplicationTable(double value)
        {
            
            //for loop
            for (double x = 2; x <= 10; ++x)
            {
                lblOutput.Text += Convert.ToString(value * x) + "\n";
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblOutput.ResetText();
            txtInput.ResetText();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
