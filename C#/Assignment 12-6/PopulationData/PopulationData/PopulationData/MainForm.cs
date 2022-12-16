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
 * 3/1/2022
 * This program lets users look through and modify the "Population Database".
 * The user can also get additional statistics about the data by pressing the "get stats" button.
 */
namespace PopulationData
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }
        //auto-generated//
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDBDataSet.City);
           

        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDBDataSet);

        }
        //auto-generated end//
        //show stats
        private void statButton_Click(object sender, EventArgs e)
        {
            //build message
            //total population
            string message = ("Total Population: " + cityTableAdapter.TotalQuery() + "\n");
            //average population
            message += ("Average Population: " + cityTableAdapter.AvgQuery() + "\n");
            //max population
            message += ("Greatest Population: " + cityTableAdapter.MaxQuery() + "\n");
            //min population
            message += ("Lowest Population: " + cityTableAdapter.MinQuery());
            //display message
            MessageBox.Show(message);
        }
    }
}
