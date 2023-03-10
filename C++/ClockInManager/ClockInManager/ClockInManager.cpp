/**
Name: Daniel Bruce
Date:12/4/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: This program records(?) when employees clock in and clock out, while also
			 tracking basic shift data.
**/


#include "pch.h"
#include "TimeCard.cpp"
#include <iostream>
#include <iomanip>

const int AR_LENGTH = 4;

using namespace std;

int main()
{
	//array of timecard objects
	TimeCard timeCards[AR_LENGTH] = {
	TimeCard("123456789",8,0,0,15,30,0,12.50,true),
	TimeCard("655789258",9,30,00,16,50,0,14.25,true), 
	TimeCard("112211223",8,10,00,15,37,4,10.00,true),
	TimeCard("000351678",10,30,00,17,0,0,13.00,true)
	};
	//headers
	cout <<"Worker ID      Start Time     End Time       Pay Rate     Hours Worked     Day's Earning" << endl
		 <<"________________________________________________________________________________________" << endl;

	//output objects to table
	for (int var = 0;var < AR_LENGTH;var++) {
		cout << fixed << setprecision(2) << setw(15) << left << timeCards[var].getWorkerID() << left
			<< setw(15) << timeCards[var].getPunchInTime().toString() << left << setw(15)
			<< timeCards[var].getPunchOutTime().toString() << left << setw(0) << "$" << left << setw(12) <<
			timeCards[var].getPayrate() << left << setw(17) << timeCards[var].getShiftLength() << left
			<< setw(0) << "$" << left << setw(6) << timeCards[var].getPay() << endl;
	}

}



