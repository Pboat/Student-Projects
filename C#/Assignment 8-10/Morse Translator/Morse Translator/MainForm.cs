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
 * 2/16/2022
 * This program lets the user convert Latin alphanumeric text to Morse code, and vice versa.
 */

namespace Morse_Translator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //text to morse
        private void textConvertButton_Click(object sender, EventArgs e)
        {
            arrowLabel.Text = "----->";//set arrow text to indicate what kind of translation took place
            try {
                string inputText = textTextBox.Text.ToLower();//set to lowercase to prevent conflicts
                morseTextBox.Text = MorseConvertUtil(inputText,false);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        //morse to text
        private void morseConvertButton_Click(object sender, EventArgs e)
        {
            arrowLabel.Text = "<-----";
            try {
                string inputText = morseTextBox.Text;
                textTextBox.Text = MorseConvertUtil(inputText, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string MorseConvertUtil(string str, bool startMorse) {
            
            // dictionary that matches morse code with it's corresponding char. Unsupported chars are skipped over
            Dictionary <char,string> morseDict = new Dictionary <char,string>(){{'a',".-" }, {'b',"-..." }, {'c',"-.-." }, {'d',"-.." }, 
                {'e',"." }, {'f',"..-." }, {'g',"--." }, {'h',"...." }, {'i',".." }, {'j',".---" }, {'k',"-.-" }, {'l',".-.." },
                {'m', "--" }, {'n',"-." }, {'o',"---" }, {'p',".--." }, {'q',"--.-" }, {'r',".-." }, {'s',"..." }, {'t',"-" }, 
                {'u',"..-" }, {'v',"...-" }, {'w',".--" }, {'x',"-..-" }, {'y',"-.--" }, {'z',"--.." },{'1', ".----" }, {'2',"..---" }, 
                {'3',"...--" }, {'4',"....-" }, {'5',"....." }, {'6',"-...." }, {'7',"--..." }, {'8',"---.." }, {'9',"----." }, {'0',"-----" }, 
                {',',"--..--" }, {'.',".-.-.-" }, {'?',"..--.." }, {'!',"-.-.--" },{'(',"-.--."}, {')',"-.--.-"}, {'"',".-..-."},{'\'',".----."}, {' ',"/" } };

            //build translation with this
            string translation="";

            //choose which way to translate
            //morse to text
            if (startMorse) {
                //turn morse string into individual morse code tokens, to replace with corresponding chars
                string[] tokens = str.Split(null);
                //go through the token array and build a translation using it and the dictionary
                for (int indexToken = 0; indexToken < tokens.Length ; indexToken++ ) {
                    //look through dictionary to find matching code
                    for(int indexDict = 0; indexDict < morseDict.Count ; indexDict++)
                    {
                        if (tokens[indexToken] == morseDict.ElementAt(indexDict).Value) {
                            //add corresponding char from dict to translation str
                            translation += morseDict.ElementAt(indexDict).Key ;
                            break;//since we already found a match for this token, we don't need to keep looping
                        }
                    }
                }
            }
            //text to morse
            else {
                //follows the same process as above, but instead of using tokens, use string's raw char positions
                for (int indexStr = 0; indexStr < str.Length ; indexStr++){
                    for (int indexDict = 0; indexDict < morseDict.Count; indexDict++)
                    {
                        if (str[indexStr] == morseDict.ElementAt(indexDict).Key)
                        {
                            //add corresponding morse code from dict to translation str
                            translation += (morseDict.ElementAt(indexDict).Value + " ");
                            break;//break to skip unneeded passes of this loop
                        }
                    }
                }
                translation.TrimEnd();//remove final whitespace char
            }
            //translation should be constructed, return finished product
            return translation;
        }
    }
}
