using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slot_Machine_Simulation
{
    public partial class MainForm : Form
    {
        //class vars, tracks money spent and prize winnings respectively over the whole play session
        double totalInput = 0;
        double totalOutput = 0;
        public MainForm()
        {
            InitializeComponent();
        }
        //for the first time ever, the exit button does more than just close the program
        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The total money spent was: "+ totalInput.ToString("c") + "\nThe total money won was: " + totalOutput.ToString("c"));
            this.Close();
        }
        //simulates a spin of the slots
        private void spinButton_Click(object sender, EventArgs e)
        {
            try
            {
                //put all the stored images in an array
                Image[] fruits = {Properties.Resources.Apple, Properties.Resources.Banana,
                Properties.Resources.Cherries, Properties.Resources.Grapes, Properties.Resources.Lemon,
                Properties.Resources.Lime, Properties.Resources.Orange, Properties.Resources.Pear,
                Properties.Resources.Strawberry , Properties.Resources.Watermelon };
                //randomly generate images
                Random rand = new Random();
                slotLeftPictureBox.Image = fruits[rand.Next(fruits.Length)];
                slotMiddlePictureBox.Image = fruits[rand.Next(fruits.Length)];
                slotRightPictureBox.Image = fruits[rand.Next(fruits.Length)];

                //determine prize multiplier based on how many matched
                double prizeMult = 0; //default to 0 to indicate a loss
                                      //all match
                if (slotLeftPictureBox.Image == slotMiddlePictureBox.Image && slotLeftPictureBox.Image == slotRightPictureBox.Image)
                {
                    prizeMult = 3;
                }
                //2 match
                else if (slotLeftPictureBox.Image == slotMiddlePictureBox.Image || slotLeftPictureBox.Image == slotRightPictureBox.Image || slotMiddlePictureBox.Image == slotRightPictureBox.Image)
                {
                    prizeMult = 2;
                }

                double prize = double.Parse(moneyTextBox.Text) * prizeMult;

                //add the given and won money to their respective lifetime totals
                totalInput += double.Parse(moneyTextBox.Text);
                totalOutput += prize;

                //display final results of spin
                MessageBox.Show("You've won: " + prize.ToString("c") + "!");

                
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
