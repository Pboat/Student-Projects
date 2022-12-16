using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*
 * Daniel Bruce
 * 2/23/2022
 * This program lets a customer add their contact information to the contact list file.
 */
namespace CustomerSubscription
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //this button is the important button that does everything
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //get number of customers from contact list
                int customerCount = 0;
                StreamReader inputFile = File.OpenText("contact_list.txt");
                //increment customerCount for each line
                while (!inputFile.EndOfStream) {
                    inputFile.ReadLine();
                    customerCount++;
                }
                inputFile.Close();

                //create customer object from input
                //combine first and last name into a single name string
                string name = firstNameTextBox.Text + " " + lastNameTextBox.Text;
                Customer consumer = new Customer(name, phoneTextBox.Text, addressTextBox.Text, (100 + customerCount), subscribeCheckBox.Checked);

                //add customer object to end of contact list
                StreamWriter outputFile = File.AppendText("contact_list.txt");
                outputFile.WriteLine(consumer.ToString());
                outputFile.Close();

                //let user know the operation was successful
                MessageBox.Show("Contact added!");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
