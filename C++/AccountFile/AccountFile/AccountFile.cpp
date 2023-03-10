/**
Name: Daniel Bruce
Date:11/8/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: This program determines the sum of the balances 
			 of all accounts listed in a formated file, and 
			 displays the results.
**/

#include "pch.h"
#include "cost.h"
/*
contains:
struct Cost {
	string descr;
	string price; //corresponds with amount heading
	string id; // corresponds with item number heading
};*/
#include <iostream>
#include <vector>
#include <fstream>
#include <string>
#include <iomanip>


using namespace std;

//prototypes
Cost ParseAccounts(fstream &);
double SumAccounts(vector<Cost>);

int main()
{
	//struct vector
	vector<Cost> acct(0);
	//fstream object
	fstream theFile;
	theFile.open("costfile.txt", ios::in);
	//read file contents
	while (!theFile.fail()) {
		acct.push_back(ParseAccounts(theFile));
	}
	//output sum
	cout << setprecision(2) << fixed <<"The total balance between all accounts is $" << SumAccounts(acct) << ".";
	//close file
	theFile.close();
}

//functions

Cost ParseAccounts(fstream &file) {
	Cost act {"","",""};
	//read file contents into structure
	file >> act.descr;
	file >> act.price;
	file >> act.id;
	return act;
}


double SumAccounts(vector<Cost>cst) {
	double sum = 0.0;
	for (int var = 1;var < (cst.size() - 1) ;var++) { //start at one so that the headings are skipped
		sum += stod(cst[var].price);
	}
	return sum;
}