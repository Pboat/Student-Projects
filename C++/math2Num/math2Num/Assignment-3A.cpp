/**
Name: Daniel Bruce
Date:9/6/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: Takes a user's numerical input twice and then displays
  the results of various mathematical functions using that input
**/

#include "pch.h"
#include <iostream>
using namespace std;

int main()
{
	//create variables
	int firstInput, secondInput = 0;

	cout << "Two Number Math!" << endl;
	//ask for input
	cout << "Please enter two numbers, each separated by a space: ";
	cin >> firstInput >> secondInput;

	//do the math and then output it while describing the output
	cout << "Sum: ";
	cout << firstInput + secondInput << endl;

	cout << "Product: ";
	cout << firstInput * secondInput << endl;

	cout << "Difference: ";
	cout << firstInput - secondInput << endl;
	//typecasted to float so it will work properly
	cout << "Quotient: ";
	cout << static_cast<float>(firstInput) / secondInput << endl;
	
	cout << "Remainder: ";
	cout << firstInput % secondInput << endl;

	return 0;
}
