/**
Name: Daniel Bruce
Date:11/14/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: This program displays sorted lists of invoices.
**/

#include "pch.h"
#include <iostream>
#include <string>
#include "Invoice.cpp"
#include <iomanip>

using namespace std;
const int AR_LENGTH = 8;

//prototypes
void swap(Invoice&, Invoice&);
void displayResults(int,string,int,double);
void displayResults(string, double);

int main()
{
	//invoice array initialization
	Invoice invoices[AR_LENGTH] = {
		 Invoice(83, "Electric sander", 7, 57.98),
		 Invoice(24, "Power saw", 18, 99.99),
		 Invoice(7, "Sledge hammer", 11, 21.5),
		 Invoice(77, "Hammer", 76, 11.99),
		 Invoice(39, "Lawn mower", 3, 79.5),
		 Invoice(68, "Screwdriver", 106, 6.99),
		 Invoice(56, "Jig saw", 21, 11.00),
		 Invoice(3, "Wrench", 34, 7.5) };

	// selection sorting by description, ascending order

	for (int var = 0; var < AR_LENGTH -1; var++) {
		int maxIndex = var;
		for (int count = maxIndex; count < AR_LENGTH - 1; count++) {
			if (invoices[count].GetPrtDesc().compare(invoices[maxIndex].GetPrtDesc())<0) {
				maxIndex = count;
			}
		}
		if (maxIndex != var) {
			swap(invoices[var], invoices[maxIndex]);
		}
	}

	//display results
	for (int var = 0; var < AR_LENGTH; var++) {
		displayResults(invoices[var].GetPrtNum(), invoices[var].GetPrtDesc(), invoices[var].GetQuant(), invoices[var].GetPrice());
	}
	cout << endl;

	//insertion sorting by price, descending order

	for (int var = 0; var < AR_LENGTH - 1; var++) {
		Invoice unsorted = invoices[var];
		int crawl = var;
		for(;crawl > 0 && invoices[crawl-1].GetPrice() < unsorted.GetPrice() ;crawl--){
			swap(invoices[crawl], invoices[crawl-1]);
		}
		invoices[crawl] = unsorted;
	}

	//display results again
	for (int var = 0; var < AR_LENGTH; var++) {
		displayResults(invoices[var].GetPrtNum(), invoices[var].GetPrtDesc(), invoices[var].GetQuant(), invoices[var].GetPrice());
	}
	cout << endl;

	// bubbble sorting (you didn't specify, so I'm doing bubble for practice) by total price, ascending order
	for (int max = AR_LENGTH - 1; max > 0; max--) {
		for (int var = 0; var < max; var++) {
			if (invoices[var].GetTotal()>invoices[var+1].GetTotal()) {
				swap(invoices[var] , invoices[var + 1]);
			}
		}
	}
	//display results one last time
	for (int var = 0; var < AR_LENGTH; var++) {
		displayResults(invoices[var].GetPrtDesc(), invoices[var].GetTotal());
	}
	cout << endl;
}

//swaping function
void swap(Invoice&x, Invoice&y) {
	Invoice temp;
	temp = x;
	x = y;
	y = temp;
}
//displays results

void displayResults(int num, string desc, int count, double cost) {
	cout << setprecision(2)<< fixed << endl << setw(4) << left << num << setw(16) << left << desc << setw(4)
		<< left  << count << setw(0) << left << "$" << setw(7) << left << cost;
	
}
//overloaded results displayer for displaying the totals
void displayResults(string desc, double total) {
	cout << setprecision(2) << fixed << endl << setw(16) << left << desc << setw(0) << left << "$" << setw(9) << total;
}
