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
 * 2/25/2022
 * Simple hourly wage to yearly salary calculator
 */
namespace HourlyWageCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateYearlyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //convert from hourly wage to yearly salary
                decimal input = decimal.Parse(hourlyTextBox.Text);
                decimal hours = decimal.Parse(hoursTextBox.Text);
                decimal wage = hours * input * 52;
                yearlyTextBox.Text = wage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calculateHourlyButton_Click(object sender, EventArgs e)
        {
            try
            {
                //convert from yearly salary to hourly wage
                decimal input = decimal.Parse(yearlyTextBox.Text);
                decimal hours = decimal.Parse(yearlyTextBox.Text);
                decimal wage = input / (hours * 52);
                hourlyTextBox.Text = wage.ToString();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void hoursLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
