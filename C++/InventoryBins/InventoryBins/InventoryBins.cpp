/**
Name: Daniel Bruce
Date:11/1/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: This program keeps track of several kinds of items and
			 the number of them in each "bin", which the user can
			 freely modify.
**/

#include "pch.h"
#include <iostream>
#include <iomanip>
#include <string>
#include <algorithm>

using namespace std;
//structure
struct Bin {
	string descr;
	int parts;
};
//function prototypes
void AddParts(Bin[]);
void RemoveParts(Bin[]);

//Constants
const int PARTBINSIZE = 10;
//enum BinParts {VALVE,BEARING,BUSHING,COUPLING,FLANGE,GEAR,GEAR_HOUSING,VACUUM_GRIPPER,CABLE,ROD};

int main()
{
	//main variables, held in a structure array
	Bin partBin[PARTBINSIZE]{
		{"Valve",10},{"Bearing",5},{"Bushing",15},{"Coupling",21},{"Flange",7},
		{"Gear",5},{"Gear Housing",5},{"Vacuum Gripper", 25},{"Cable",18},{"Rod",12}
	};
	//other variables
	int mainMenuAnswer = 0;
	//string binMenuAnswer = "";

	//title
	cout << "Motor Men Mechanics" << endl <<"Part Inventory System" << endl 
		 <<"-------------------------------"<<endl
		 << endl << setw(20) << left << "Part" << setw(5) << left << "Amount" << endl;

	//main loop
	do {
		// display list
		for (int var = 0; var < PARTBINSIZE; var++) {
			cout << setw(20)<< left <<partBin[var].descr << setw(5) << left << partBin[var].parts << endl;	
		}
		cout << endl << "1 - Add parts to bin" << endl << "2 - Remove parts from bin"  
			 << endl <<  "3 - Quit" << endl << "Please enter your selection: ";
		cin >> mainMenuAnswer;
		// input validation
		while (mainMenuAnswer < 1 || mainMenuAnswer > 3) {
			cout << "Error! Invalid input! Please enter the numbers next to the menu options to make your selection: ";
			cin >> mainMenuAnswer;
		}
		switch (mainMenuAnswer) {
			case 1: //add
				AddParts(partBin);
				break;
			case 2: //remove
				RemoveParts(partBin);
				break;
			case 3: //quit
				exit(0);
				break;
			default:
				exit(1);
		}
		


	} while (mainMenuAnswer != 3);
	

}

void AddParts(Bin bin[]) { 
	//variables 
	string answer = "";
	string compareTempAns = "";
	string compareTempBin = "";
	int numAnswer = 0;
	int pos = 0;
	bool valid = false;
	// ask which part
	cout << "Which part bin would you like to add parts to? (no plurals): ";
	cin.ignore();
	getline(cin, answer);
	do {
		for (pos = 0; pos < PARTBINSIZE; pos++) {
			compareTempAns = answer;
			compareTempBin = bin[pos].descr;
			remove(compareTempAns.begin(), compareTempAns.end(), ' ');
			remove(compareTempBin.begin(), compareTempBin.end(), ' ');
			if (_stricmp(compareTempAns.c_str(), compareTempBin.c_str()) == 0) {
				valid = true;
				break;
			}
		}
		if (valid == false) {
			cout << "Part not found! Please enter a part from the list above: ";
			cin >> answer;
		}
	} while (valid == false);
	//ask for how many
	cout << "How many parts would you like to add?: ";
	cin >> numAnswer;
	//input validation
	while (numAnswer < 0 || (numAnswer + bin[pos].parts)>30) {
		if (numAnswer < 0) {
			cout << "Error! Invalid input! Please enter a positive number: ";
		}
		else {
			cout << "That bin can't hold that many more parts! Bins can't hold more than 30 parts, so try adding less." << endl
				<< "As a reminder, there are " << bin[pos].parts << " parts in the " << bin[pos].descr << " bin." << endl
				<< "How many parts would you like to add?: ";
		}
		cin >> numAnswer;
	}
	// add parts to bin
	bin[pos].parts += numAnswer;
}
void RemoveParts(Bin bin[]) {
	//variables 
	string answer = "";
	string compareTempAns = "";
	string compareTempBin = "";
	int numAnswer = 0;
	int pos = 0;
	bool valid = false;
	// ask which part
	cout << "Which part bin would you like to take parts from? (no plurals): ";
	cin.ignore();
	getline(cin,answer);
	do {
		for (pos = 0; pos < PARTBINSIZE; pos++) {
			compareTempAns = answer;
			compareTempBin = bin[pos].descr;
			remove(compareTempAns.begin(), compareTempAns.end(),' ');
			remove(compareTempBin.begin(), compareTempBin.end(), ' ');
			if (_stricmp(compareTempAns.c_str(), compareTempBin.c_str()) == 0) {
				valid = true;
				break;
			}
		}
		if (valid == false) {
			cout << "Part not found! Please enter a part from the list above: ";
			cin >> answer;
		}
	} while (valid == false);

	//ask for how many
	cout << "How many parts would you like to remove?: ";
	cin >> numAnswer;
	//input validation
	while (numAnswer < 0 || (bin[pos].parts - numAnswer)<0) {
		if (numAnswer < 0) {
			cout << "Error! Invalid input! Please enter a positive number: ";
		}
		else {
			cout << "You are trying to take more parts than there are in the bin. That's impossible! Try removing less." << endl
				<< "As a reminder, there are " << bin[pos].parts << " parts in the " << bin[pos].descr << " bin." << endl
				<< "How many parts would you like to remove?: ";
		}
		cin >> numAnswer;
	}
	// remove parts from bin
	bin[pos].parts = bin[pos].parts - numAnswer;
}