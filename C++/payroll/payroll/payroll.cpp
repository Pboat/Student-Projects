/**
Name: Daniel Bruce
Date:8/24/2018
Class:CIS2541 - NET01 C++ Language Programming
**/
#include "pch.h"
// above statement needed to run in 2017 vis studio debugger.
#include <iostream>
using namespace std;

int main() {
	double hour, payrate, income;
	//ask for hours
	cout << "How many hours did you work in the last week?";
	cin >> hour;

	//then get the rates
	cout << "How much do you get paid every hour?";
	cin >> payrate;

	//math it up
	income = hour * payrate;

	//show them what they made
	cout << "You made $" << income << " this week.";
	return 0;
}
;
