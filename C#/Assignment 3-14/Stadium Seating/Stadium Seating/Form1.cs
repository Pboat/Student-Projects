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
 * 1/18/2022
 * With this program, the user can determine the revenue earned from tickets of each kind of seating class, 
 * as well as the total revenue from all of them.
 */

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //clear all fields of text that can change
        private void clearButton_Click(object sender, EventArgs e)
        {
            aTextBox.Text = "";
            bTextBox.Text = "";
            cTextBox.Text = "";
            classARevTotalLabel.Text = "";
            classBRevTotalLabel.Text = "";
            classCRevTotalLabel.Text = "";
            totalRevTotalLabel.Text = "";
        }

        private void calcRevButton_Click(object sender, EventArgs e)
        {
            //determine the revenue for each class of ticket
            decimal ticketsA = 15m * decimal.Parse(aTextBox.Text);
            decimal ticketsB = 12m * decimal.Parse(bTextBox.Text);
            decimal ticketsC = 9m * decimal.Parse(cTextBox.Text);
            decimal totalRev = ticketsA + ticketsB + ticketsC;
            //change labels to calculated values
            classARevTotalLabel.Text = ticketsA.ToString("c");
            classBRevTotalLabel.Text = ticketsB.ToString("c");
            classCRevTotalLabel.Text = ticketsC.ToString("c");
            totalRevTotalLabel.Text = totalRev.ToString("c");

        }
    }
}
