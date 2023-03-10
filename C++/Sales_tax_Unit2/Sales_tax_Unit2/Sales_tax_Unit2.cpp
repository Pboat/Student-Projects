/**
Name: Daniel Bruce
Date:8/30/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: Calculates the sales tax on a $95 purchase 
**/
#include "pch.h"
#include <iostream>
using namespace std;

int main()
{
	const auto BASE_COST = 95.00,
		STATE_RATE = .04, //rate as in tax rate
		COUNTY_RATE = .02; 
	//I'd calculate the total here if I had to use it more than once.

	cout << "For a $" << BASE_COST << " dollar purchase," 
		 <<"your income tax will be $" << (BASE_COST*(STATE_RATE+COUNTY_RATE)) <<".";

	return 0;
}
