/**
Name: Daniel Bruce
Date:8/30/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: A program that determines the user's monthly bill based on
			their package and data usage.
**/

#include "pch.h"
#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
	//variables
	char package = 0;
	double gigaB = 0;
	double cost = 0;

	cout << "T-Sprizon Bill Calculator" << endl << "Please enter your data package:";
	cin >> package;

	//skip asking for data usage if package is C
	if (package == 'c' || package == 'C') {
		cost = 69.99;
	}
	else {
		cout << "Please enter your data usage in gigabytes:";
		cin >> gigaB;

		//package then gigabytes are factored in
		switch (package) {
		case 'a':
		case 'A':
			if (gigaB >= 4)
				cost = (gigaB - 4) * 10 + 39.99;
			else
				cost = 39.99;
			break;
		case 'b':
		case 'B':
			if (gigaB >= 8)
				cost = (gigaB - 8) * 5 + 59.99;
			else
				cost = 59.99;
			break;
			/*case 'c':
			case 'C':
				cost = 69.99;
				break;*/
		default:
			cout << "Error! Please enter a valid package.";
			return 1;

		}
	}
	cout << "This month's bill comes to $" << cost << setprecision(2);
	//end
}

