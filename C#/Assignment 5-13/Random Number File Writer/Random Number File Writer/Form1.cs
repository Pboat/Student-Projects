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
 * 1/24/2022
 * This program generates a text file with a user specified amount of random numbers,
 * and then displays it
 */
namespace Random_Number_File_Writer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //cya
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            StreamWriter fileMaker;
            StreamReader fileLooker;
            try
            {
                RandNumSaveFileDialog.DefaultExt = ".txt"; //so you don't have to type ".txt" to get a text file
                RandNumSaveFileDialog.InitialDirectory = "Desktop";
                if (RandNumSaveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //make the file
                    fileMaker = File.CreateText(RandNumSaveFileDialog.FileName); //make a file where the save dialog said it should go
                    Random rng = new Random();
                    for (int x = int.Parse(numCountBox.Text); x > 0; x--) //put as many things in as the user wants
                    {
                        fileMaker.WriteLine((rng.Next(100)+1).ToString());//add the random number to the file (1-100)
                    }
                    fileMaker.Close();

                    //feed the file's contents into the list box
                    fileLooker = File.OpenText(RandNumSaveFileDialog.FileName);
                    while (!fileLooker.EndOfStream)
                    {
                        resultsListBox.Items.Add(fileLooker.ReadLine()); //add to the list box
                    }
                    fileLooker.Close();
                }

                else
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
