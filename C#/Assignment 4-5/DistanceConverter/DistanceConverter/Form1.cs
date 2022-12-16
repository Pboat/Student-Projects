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
 * Use this distance converter for all of your imperial conversion needs (does not include miles)
 */
namespace DistanceConverter
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

        private void convertButton_Click(object sender, EventArgs e)
        {
            //make sure the conversion units were actually selected
            if (fromListBox.SelectedIndex != -1 && toListBox.SelectedIndex != -1)
            {
                //vars
                decimal input = decimal.Parse(distanceTextBox.Text);
                decimal conversionFactor = 1m;
                string fromChoice = fromListBox.SelectedItem.ToString();
                string toChoice = toListBox.SelectedItem.ToString();
                string unitSymbol = "";
                //determine the proper conversion factor
                switch (fromChoice)
                {
                    case "Inches":
                        break;
                    case "Feet":
                        conversionFactor *= 12m;
                        break;
                    case "Yards":
                        conversionFactor *= 36m;
                        break;
                }
                switch (toChoice)
                {
                    case "Inches":
                        unitSymbol = "\"";
                        break;
                    case "Feet":
                        unitSymbol = "\'";
                        conversionFactor /= 12m;
                        break;
                    case "Yards":
                        unitSymbol = " yd";
                        conversionFactor /= 36m;
                        break;
                }
                //convert to the proper units
                decimal finalDist = conversionFactor * input;
                //display result
                conversionResultLabel.Text = finalDist.ToString("f") + unitSymbol;
            }
            else { //they didn't select their units :(
                MessageBox.Show("Please select what you are converting to and from!");
            }
        }
    }
}
