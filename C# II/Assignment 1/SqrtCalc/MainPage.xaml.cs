using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

/*
 * Daniel Bruce
 * 3/16/2022
 * This program calculates the square root of the number a user enters
 */

namespace SqrtCalc
{

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //vars
                double input = double.Parse(numberTextBox.Text);
                string results = "Results: ";
                //skip process for strange or invalid input
                if (input == 0)
                {
                    results += 0;
                }
                else if (input < 0)
                {
                    results += "Invalid input! Please enter a positive number.";
                }
                else
                {
                    
                    //wait, you just guess a lot???????
                    //uh, get the square root?
                    double guess = input + 1.5; //make this different from input so that sub 1 calcs will work properly.
                    double difference = 0;
                    double prevGuess = 0;
                    //make better guesses until the babylonian method provides minimal change
                    do
                    {
                        //record previous guess to determine difference
                        prevGuess = guess;
                        //make a better guess and check the difference between guesses to see if we should stop
                        
                        if (input >= 1)
                        {
                            guess = (guess + (input / guess)) / 2;
                            difference = prevGuess - guess;
                        }
                        else
                        {
                            guess = (guess + (input / guess)) / 2;
                            difference = prevGuess - guess;
                        }

                    } while (difference > 0.00000000000001);
                    results += guess;
                }
                resultsTextBlock.Text = results;
            }
            catch (Exception ex) { 
                //the only way this should be reached is if invalid characters are entered into the string.
                resultsTextBlock.Text = "Results: Invalid input! Please enter a number.";
            }
        }
    }
}
