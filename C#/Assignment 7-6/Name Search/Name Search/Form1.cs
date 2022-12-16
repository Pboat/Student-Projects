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
 * 2/10/2022
 * This program lets users search for a name
 * to see if it's in the "database" of the 200 most popular baby names (circa 2009).
 */
namespace Name_Search
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //funcs
        //read both files into their own lists
        private void GetNames(ref List<string> boyList, ref List<string> girlList) {
            //boy list
            StreamReader boyFile = File.OpenText("BoyNames.txt");
            while (!boyFile.EndOfStream) {
                boyList.Add(boyFile.ReadLine());
            }
            boyFile.Close();
            //girl list
            StreamReader girlFile = File.OpenText("GirlNames.txt");
            while (!girlFile.EndOfStream)
            {
                girlList.Add(girlFile.ReadLine());
            }
            girlFile.Close();
        }

        //sequential name search, data is not sorted. returns -1 if none found
        private int SearchName(string name,ref List<string> nameList) {
            int index = -1;
            for (int x = 0 ; x<nameList.Count ; x++) {
                if (nameList[x].ToLower() == name.ToLower()) {
                    index = x;
                    break;
                }
            }
            return index;
        }

        //event handlers
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<string> boyList = new List<string>();
            List<string> girlList = new List<string>();

            int boyIndex = -1;
            int girlIndex = -1;

            string resultsText = nameTextBox.Text + " ";
            
            //fill lists with names from files
            GetNames(ref boyList,ref girlList);
            //search for names
            boyIndex = SearchName(nameTextBox.Text, ref boyList );
            girlIndex = SearchName(nameTextBox.Text, ref girlList);
            //change the text boxes, and build the results text conditionally
            if (boyIndex > -1) {
                resultsText += "appeared on the boy's list";
                boyTextBox.Text = boyIndex.ToString();
            }

            if (boyIndex > -1 && girlIndex > -1) {
                resultsText += " and it ";
            }

            if (girlIndex > -1)
            {
                resultsText += "appeared on the girl's list";
                girlTextBox.Text = girlIndex.ToString();
            }

            if (boyIndex <= -1) {
                boyTextBox.Text = "Not Found";
            }

            if (girlIndex <= -1)
            {
                girlTextBox.Text = "Not Found";
            }

            if (boyIndex <= -1 && girlIndex <= -1)
            {
                resultsText += "did not appear on either list";
            }
            resultsTextBox.Text = resultsText + ".";

        }
    }
}
