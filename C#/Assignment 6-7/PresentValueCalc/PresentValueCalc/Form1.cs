using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Daniel Bruce
 * 2/1/2022
 * This program lets the user enter information about their intended investment goal(future value),
 * to find the investment (present value) necessary to reach it.
 */

namespace PresentValueCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //calc's the present value and returns it.
        private decimal PresentValue(decimal futr, decimal intr, int year) {

            decimal present = 0;
            //calc
            present = (futr / (decimal)Math.Pow((double)(1 + intr),(double)year));
            
            return present;
        }
        //press to get the present value
        private void calcButton_Click(object sender, EventArgs e)
        {
            //data validation for each textbox, throwaway value for out fields
            if (decimal.TryParse(futureTextBox.Text, out decimal x)){
                if (decimal.TryParse(interestTextBox.Text, out decimal y)){
                    if (int.TryParse(yearsTextBox.Text, out int z)){
                        //use the method to set calc present value and change the present value textbox
                        presentTextBox.Text = PresentValue(decimal.Parse(futureTextBox.Text), decimal.Parse(interestTextBox.Text)/100, int.Parse(yearsTextBox.Text)).ToString("c");
                    }
                    else {
                        MessageBox.Show("Invalid input for \"Years\" ");
                    }
                }
                else {
                    MessageBox.Show("Invalid input for \"Annual Interest\" ");
                }
            }
            else {
                MessageBox.Show("Invalid input for \"Future Value\" ");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
