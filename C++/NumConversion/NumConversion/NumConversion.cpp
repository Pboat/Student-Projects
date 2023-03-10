/**
Name: Daniel Bruce
Date:9/20/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: A program that lets users convert decimal numbers to numbers of different bases 
(base 1,8, and 16)
**/

#include "pch.h"
#include <iostream>
#include <iomanip>
#include <cmath>
#include <string>

using namespace std;

int main()
{
	char endProg = 'n';
	// lets the user run the program again without restarting the program
		do {

			// variables
			double numUpperLimit = 0; //starts as double so that validation loop works correctly
			double numLowerLimit = 0;
			int theCount = 0;

			//title, then take input
			cout << "Whole Number Conversion!" << endl << "Please enter your starting number: ";
			cin >> numLowerLimit;
			while (numLowerLimit < 0 || floor(numLowerLimit) != ceil(numLowerLimit)) {
				cout << "Error! Invalid Input! Please enter a positive integer: ";
				cin >> numLowerLimit;
			}
			cout << "Please enter your ending number: ";
			cin >> numUpperLimit;
			while (numUpperLimit < 0 || floor(numUpperLimit) != ceil(numUpperLimit ) || numUpperLimit < numLowerLimit) {
				cout << "Error! Invalid Input! Please enter a positive integer larger than the previous number you entered: ";
				cin >> numUpperLimit;
			}

			//cast to int so that conversion works
			static_cast<int>(numUpperLimit, numLowerLimit);

			// assign lower limit to another variable so that we can modify the variable while
			// preserving the original value
			theCount = numLowerLimit;

			// main loop
			while (theCount <= numUpperLimit) {
				//variables specific to loop
				//binary
				int testValueBin = theCount;
				int binPlace = 0;
				double binNum = 0;
				//octal
				int testValueOct = theCount;
				double octNum = 0;
				//hexadecimal
				int testValueHex = theCount;
				double hexNum = 0;
				char hexChar = '\0';
				string hexFinal = "";

				// binary number generation loop
				while (testValueBin != 0) {
					binNum += (pow(10, binPlace))*(testValueBin % 2);
					binPlace++;
					testValueBin /= 2;
				}

				// octal number generation loop
				for (int octPlace = 0; testValueOct != 0; octPlace++) {
					octNum += (pow(10, octPlace))*(testValueOct % 8);
					testValueOct /= 8;
				}

				//hex number generation loop
				do {
					hexNum = (testValueHex % 16);
					if (hexNum > 9)
						hexChar = (char(hexNum) - 10) + 'A';
					else
						hexChar = char(hexNum) + 48;
					testValueHex /= 16;
					hexFinal = hexChar + hexFinal;
				} while (testValueHex != 0);

				cout << setprecision(0) << fixed << "Decimal: " << theCount++ << " Binary: " << binNum << " Octal: " <<
					octNum << " Hexadecimal: " << hexFinal << endl;
			}
			cout << "If you would like to stop the program, enter \"q\". Otherwise, press enter a different character to continue.";
			cin >> endProg;
		} while (endProg != 'q' && endProg != 'Q') ;

}

