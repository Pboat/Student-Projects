/**
Name: Daniel Bruce
Date:9/6/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: Takes a user's numerical input three times and then displays
  the results of various mathematical functions using that input
**/

#include "pch.h"
#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	//create variables
	int firstInput, secondInput, thirdInput = 0;

	cout << "Math! Now With Three Numbers!" << endl;
	//ask for input
	cout << "Please enter three numbers, each separated by a space: ";
	cin >> firstInput >> secondInput >> thirdInput;

	//calculate, then communicate

	cout << "Sum: ";
	cout << firstInput + secondInput + thirdInput << endl;
	
	cout << "Average: ";
	cout << static_cast<int>(static_cast<float>(firstInput + secondInput + thirdInput)/3) << endl;

	cout << "Product: "; 
	cout << firstInput * secondInput * thirdInput << endl;

	cout << "Largest: ";
	cout << fmax(fmax(firstInput, secondInput), thirdInput) << endl;

	cout << "Smallest: ";
	cout << fmin(fmin(firstInput, secondInput), thirdInput) << endl;

	return 0;
}
