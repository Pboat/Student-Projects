/**
Name: Daniel Bruce
Date:10/8/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: Produces a report for an unspeccified marketing depratment
			 and it's employees based on user input. This version also
			 lets the user to both sort and search through the report.
**/

#include "pch.h"
#include <iostream>
#include <string>
#include <iomanip>
#include <vector> // 10/10 best data type, straight upgrade from arrays
using namespace std;

// prototypes
bool addEmployee(vector<string>&,vector<string>&,vector<string>&,vector<int>&,vector<double>&, vector<double>&);
void printReport(int,vector<string>&, vector<string>&, vector<string>&, vector<int>&, vector<double>&, vector<double>&);
void employeeSearch(vector<string>&, vector<string>&, vector<string>&, vector<int>&, vector<double>&, vector<double>&);
void calcPay();
void displayReport(vector<string>&, vector<string>&, vector<string>&, vector<int>&, vector<double>&, vector<double>&);
void inpValidation(double &);
void selectionSort(vector<string>&, vector<string>&, vector<string>&, vector<int>&, vector<double>&, vector<double>&, int);
void swap(string &, string &);
void swap(int &, int &);
void swap(double &, double &);


int main()
{
	//title
	cout << "Marketing Department Report System" << endl;
	//vectors
	vector<string> firstName(0);
	vector<string> lastName(0);
	vector<string> empId(0);
	vector<int> weeklyHours(0);
	vector<double> payRate(0);
	vector<double> totalPay(0);
	//variables
	bool empDataEntry = true;
	int employeeNumber = 0;
	
	//initial input loop.
	do {
		empDataEntry = addEmployee(firstName, lastName, empId, weeklyHours, payRate, totalPay);

		employeeNumber++; // keeps track of how many employees were entered.

	} while (empDataEntry);

	int menuSelection = 0; //should be self explanatory
	//main loop
	do {
		cout << endl << " Main Menu" << endl << "___________" << endl << "1: Add employees" << endl
			<< "2: Show Report" << endl << "3: Search" << endl << "4: Sorted Report"
			<< endl << "5: Calculate Pay" << endl << "6: Exit" <<endl << ": ";

		cin >> menuSelection;

		switch (menuSelection) {

			case 1:
				empDataEntry = true;

				do {
					empDataEntry = addEmployee(firstName, lastName, empId, weeklyHours, payRate, totalPay);

					employeeNumber++; // keeps track of how many employees were entered.

				} while (empDataEntry);

				break;
			case 2:
				printReport(1,firstName, lastName, empId, weeklyHours, payRate, totalPay);
				break;
			case 3:
				employeeSearch(firstName, lastName, empId, weeklyHours, payRate, totalPay);
				break;
			case 4:
				printReport(2, firstName, lastName, empId, weeklyHours, payRate, totalPay);
				break;
			case 5:
				calcPay();
				break;
			case 6: // so that the default case doesn't trigger when quitting 
				break;
			default:
				cout << "Error! Invalid Input! Please enter a number between 1 and 6." << endl;
				break;
		}


	} while (menuSelection != 6); 

	
}

//1
//adds employee data to all vectors
bool addEmployee(vector<string>&fname, vector<string>&lname, vector<string>&id, vector<int>&hours, vector<double>&rate, vector<double>&total)
{
	//placeholders so that values can be pushed to the vectors
	string fnameAnswer = "";
	string lnameAnswer = "";
	string idAnswer = "";
	double hoursAnswer = 0;
	double rateAnswer = 0.0;
	// input employee data
	cout << "Please enter the employee's first name: ";
	cin >> fnameAnswer;
	fname.push_back(fnameAnswer);
	cout << "Please enter the employee's last name: ";
	cin >> lnameAnswer;
	lname.push_back(lnameAnswer);
	cout << "Please enter the employee's ID: ";
	cin >> idAnswer;
	id.push_back(idAnswer);
	cout << "Please enter the employee's hours for the week: ";
	cin >> hoursAnswer;
	inpValidation(hoursAnswer);
	hours.push_back(static_cast<int>(hoursAnswer));
	cout << "Please enter the employee's pay rate: ";
	cin >> rateAnswer;
	rate.push_back(rateAnswer);
	// user does not enter total pay, it's calculated instead
	double empTotal = rateAnswer * hoursAnswer;
	total.push_back(empTotal);

	
	string leaveAnswer = "";
	cout << "Would you like to enter another user? (y/n): ";
	cin >> leaveAnswer;
	if (leaveAnswer == "n" || leaveAnswer == "N" || leaveAnswer == "no" || leaveAnswer == "No" || leaveAnswer == "nO") //you never nO what could happen
		return false;
	else
		return true;
}

//2 & 4
//prints a report, with an optional algorithm for sorting.
void printReport(int sel,vector<string>&fname, vector<string>&lname, vector<string>&id, vector<int>&hours, vector<double>&rate, vector<double>&total) {
	int sortMode = 0;
	bool notGood2Go = false;
	if (sel == 2) { // if they choose to, let them sort
		cout << "What would you like to sort by?" << endl << "1 - First Name" << endl
			<< "2 - Last Name" << endl << "3 - ID" << endl << "4 - Hours" << endl
			<< "5 - Pay Rate" << endl << "6 - Total Pay"<< endl << ": ";
		cin >> sortMode;
	}
	do {
		/*switch (sortMode) {
		case 0:		//unsorted
			displayReport(fname, lname, id, hours, rate, total);
			break;
			/*case 1:

				displayReport(fname,lname,id,hours,rate,total);
				break;
			case 2:
				break;
			case 3:
				break;
			case 4:
				break;
			case 5:
				break;
			case 6:
				break;
		default:
			cout << "Error! Invalid Input! Please enter a number between 1 and 6";
			notGood2Go = true;
			break;
		
		}*/
		// I moved the switch statement to the sorting function, and made these if statements to check for outlier situations
		if (sortMode == 0) { // unsorted, just displays report
			displayReport(fname, lname, id, hours, rate, total);
		}
		else if (sortMode >= 1 || sortMode <= 6) { // sorts, then displays report
			selectionSort(fname, lname, id, hours, rate, total, sortMode);
			displayReport(fname, lname, id, hours, rate, total);
		}
		else { // a sort of input validation. makes the user enter a number within the specified bounds
			cout << "Error! Invalid Input! Please enter a number between 1 and 6";
			notGood2Go = true;
		}
	} while (notGood2Go);
	
}


//3
//Search algorithm
void employeeSearch(vector<string>&fname, vector<string>&lname, vector<string>&id, vector<int>&hours, vector<double>&rate, vector<double>&total) {
	
	int searchMode = 0;
	string searchQuery = "";
	int pos = -1;
	bool notFound = true;
	
	cout << "What would you like to search with?" << endl << "1 - First Name" << endl
		<< "2 - Last Name" << endl << "3 - ID" << endl << ": ";
	do {
		cin >> searchMode;
		if (searchMode <= 0 || searchMode > 3)
			cout << "Error! Invalid Input! Please enter a number between 1 and 3." << endl << ": ";
	} while (searchMode <= 0 || searchMode > 3);
	cout <<"Search: ";
	cin >> searchQuery;

	switch (searchMode) { //considering that it's not guaranteed that the list will be sorted, linear search will be used
		case 1: // first name
			for (int index = 0; index < (fname.size() )&& notFound; index++) {
				if (searchQuery.compare(fname[index]) == 0) {
					pos = index;
					notFound = false;
				}
			}
			break;
		case 2: // last name
			for (int index = 0; index < (lname.size()) && notFound; index++) {
				if (searchQuery.compare(lname[index]) == 0) {
					pos = index;
					notFound = false;
				}
			}
			break;
		case 3: // id
			for (int index = 0; index < (id.size()) && notFound; index++) {
				if (searchQuery.compare(id[index]) == 0) {
					pos = index;
					notFound = false;
				}
			}
			break;
		default:
			break;
	}
	if (pos == -1) {
		cout << "No match could be found.";
	}
	else {
		cout << endl << setw(15) << left << "First Name" << setw(15) << left << "Last Name" << setw(15) << left << "ID" << setw(15)
			<< left << "Hours" << setw(15) << left << "Pay Rate" << setw(12) << left << "Total Pay"
			<< endl << "______________________________________________________________________________________" << endl;
		cout << setprecision(2) << fixed << setw(15) << left << fname[pos] << setw(15) << left << lname[pos] << setw(15) << left << id[pos]
			<< setw(15) << left << hours[pos] << setw(0) << left << "$" << setw(6) << left << rate[pos] << "/hr"
			<< setw(5) << left << "" << "$" << total[pos] << endl;
	}
}


//5
// simple pay calculator. Would've just put it under the case, but the compiler was making a fuss about the definitions.
void calcPay() 
{
	double calcHours = 0.00;
	double calcPay = 0.00;
	double calcTotal = 0.00;
	cout << "Enter this week's hours: ";
	cin >> calcHours;
	cout << "Enter your pay rate: ";
	cin >> calcPay;
	calcTotal = calcHours * calcPay;
	cout << "Your total untaxed pay for the week is $" << calcTotal << setprecision(2) << fixed;
}

//report printing function
void displayReport(vector<string>&fname, vector<string>&lname, vector<string>&id, vector<int>&hours, vector<double>&rate, vector<double>&total) {

	double avg = 0;

	for (int val : hours)
		avg += val;
	avg = avg / hours.size();
	
	cout << endl << setw(15) << left << "First Name" << setw(15) << left<<"Last Name" << setw(15) << left<<"ID" << setw(15)
		<< left <<"Hours" << setw(15) << left <<"Pay Rate" << setw(12) << left <<"Total Pay"
		<< endl << "______________________________________________________________________________________" << endl;
	for (int count = 0; count < fname.size();count++) {
		
		cout << setprecision(2) << fixed << setw(15) << left << fname[count] << setw(15) << left << lname[count] << setw(15) << left << id[count]
			<< setw(15) << left << hours[count] << setw(0)<< left << "$" << setw(6) << left << rate[count] <<  "/hr"
			<< setw(5) << left << "" << "$" << total[count] << endl;
		
	}
	cout << "Average hours worked: " << avg << setprecision(2) << fixed;
	return;
}

// input validation function
void inpValidation(double &num) {
	while (floor(num) != ceil(num)) {
		cout << "Error! Invalid Input! Please enter an integer: ";
		cin >> num;
	}
	return;
}

// sorting function, with each case corresponding to a sorting pattern
void selectionSort(vector<string>&fname, vector<string>&lname, vector<string>&id, vector<int>&hours, vector<double>&rate, vector<double>&total, int sel) {
	cout << sel << endl;
	switch (sel){
		case 1: // sort by first name
			for (int begin = 0;begin < (fname.size() - 1); begin++) {
				int maxIndex = begin;
				for (int scout = begin; scout < (fname.size());scout++) {
					if (fname[scout].compare(fname[maxIndex]) < 0) { //we are comparing strings, so we need a different approach
						maxIndex = scout;
					}
				}
				if (maxIndex != begin) {
					swap(fname[begin], fname[maxIndex]);
					swap(lname[begin], lname[maxIndex]);
					swap(id[begin], id[maxIndex]);
					swap(hours[begin], hours[maxIndex]);
					swap(rate[begin], rate[maxIndex]);
					swap(total[begin], total[maxIndex]);
				}

			}
			break;
		case 2: // sort by last name
			for (int begin = 0;begin < (lname.size() - 1); begin++) {
				int maxIndex = begin;
				for (int scout = begin; scout < (lname.size());scout++) {
					if (lname[scout].compare(lname[maxIndex]) < 0) {
						maxIndex = scout;
					}
				}
				if (maxIndex != begin) {
					swap(fname[begin], fname[maxIndex]);
					swap(lname[begin], lname[maxIndex]);
					swap(id[begin], id[maxIndex]);
					swap(hours[begin], hours[maxIndex]);
					swap(rate[begin], rate[maxIndex]);
					swap(total[begin], total[maxIndex]);
				}
			}
			break;
		case 3: // sort by ID
			for (int begin = 0;begin < (id.size() - 1); begin++) {
				int maxIndex = begin;
				for (int scout = begin; scout < (id.size());scout++) {
					if (id[scout].compare(id[maxIndex]) < 0) {
						maxIndex = scout;
					}
				}
				if (maxIndex != begin) {
					swap(fname[begin], fname[maxIndex]);
					swap(lname[begin], lname[maxIndex]);
					swap(id[begin], id[maxIndex]);
					swap(hours[begin], hours[maxIndex]);
					swap(rate[begin], rate[maxIndex]);
					swap(total[begin], total[maxIndex]);
				}
			}
			break;
		case 4: // sort by hours
			for (int begin = 0;begin < (hours.size() - 1); begin++) {
				int maxIndex = begin;
				for (int scout = begin; scout < (hours.size());scout++) {
					if (hours[scout] > hours[maxIndex]) {
						maxIndex = scout;
					}
				}
				if (maxIndex != begin) {
					swap(fname[begin], fname[maxIndex]);
					swap(lname[begin], lname[maxIndex]);
					swap(id[begin], id[maxIndex]);
					swap(hours[begin], hours[maxIndex]);
					swap(rate[begin], rate[maxIndex]);
					swap(total[begin], total[maxIndex]);
				}
			}
			break;
		case 5: // sort by hourly pay
			for (int begin = 0;begin < (rate.size() - 1); begin++) {
				int maxIndex = begin;
				for (int scout = begin; scout < (rate.size());scout++) {
					if (rate[scout] > rate[maxIndex]) {
						maxIndex = scout;
					}
				}
				if (maxIndex != begin) {
					swap(fname[begin], fname[maxIndex]);
					swap(lname[begin], lname[maxIndex]);
					swap(id[begin], id[maxIndex]);
					swap(hours[begin], hours[maxIndex]);
					swap(rate[begin], rate[maxIndex]);
					swap(total[begin], total[maxIndex]);
				}
			}
			break;
		case 6: // sort by total weekly pay
			for (int begin = 0;begin < (total.size() - 1); begin++) {
				int maxIndex = begin;
				for (int scout = begin; scout < (total.size());scout++) {
					if (total[scout] > total[maxIndex]) {
						maxIndex = scout;
					}
				}
				if (maxIndex != begin) {
					swap(fname[begin], fname[maxIndex]);
					swap(lname[begin], lname[maxIndex]);
					swap(id[begin], id[maxIndex]);
					swap(hours[begin], hours[maxIndex]);
					swap(rate[begin], rate[maxIndex]);
					swap(total[begin], total[maxIndex]);
				}
			}
			break;
	}
}

//overloaded swaps
void swap(string &a, string &b) {
	//cout << a << "   " << b << endl;
	string temp = "";
	temp = a;
	a = b;
	b = temp;
}

void swap(int &a, int &b) {
	//cout << a << "   " << b << endl;
	int temp = 0;
	temp = a;
	a = b;
	b = temp;
}

void swap(double &a, double &b) {
	//cout << a << "   " << b << endl;
	double temp = 0;
	temp = a;
	a = b;
	b = temp;
}