using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Daniel Bruce
//1/11/2021
//This program lets the user click on cards to identify them by name.

namespace Card_Identifier
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//change text display when clicking on corresponding picture

		private void fiveDiamondsPBox_Click(object sender, EventArgs e)
		{
			cardDescLabel.Text = "Five of Diamonds";
		}

		private void twoHeartsPBox_Click(object sender, EventArgs e)
		{
			cardDescLabel.Text = "Two of Hearts";
		}

		private void tenSpadesPBox_Click(object sender, EventArgs e)
		{
			cardDescLabel.Text = "Ten of Spades";

		}

		private void queenHeartsPBox_Click(object sender, EventArgs e)
		{
			cardDescLabel.Text = "Queen of Hearts";
		}

		private void kingClubsPBox_Click(object sender, EventArgs e)
		{
			cardDescLabel.Text = "King of Clubs";
		}

		//a (redundant) exit button that works

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
