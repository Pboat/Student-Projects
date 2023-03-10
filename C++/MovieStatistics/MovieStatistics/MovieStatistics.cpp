/**
Name: Daniel Bruce
Date:10/17/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: Provides the mean, median, and mode of
			 each student's movie watching habits
			 based on user input data
**/
#include "pch.h"
#include <iostream>

using namespace std;

//prototype
void dataValidation(double &);
double average(double *, double);
double median(double *, double);
double mode(double *, double);

int main()
{
    //variables
	double studCount = 0.0;
	//pointers
	double * studData = nullptr;

	//ask the user for student count
	cout << "Please enter the number of students you have surveyed: ";
	cin >> studCount;
	//data validation (loop is in function)
	if (studCount < 0 && ceil(studCount) != floor(studCount)) {
		dataValidation(studCount);
	}
	//allocate
	studData = new double[studCount];

	//enter individual student data
	double temp = 0.0;
	for (int var = 0 ; var < studCount; var++) {
		cout << "Please enter the number of movies student #"<< (var+1) << " saw this month." ;
		cin >> temp;
		if (temp < 0 && ceil(temp) != floor(temp)) {
			dataValidation(temp);
		}
		studData[var] = temp;
	}
	double modeDat = mode(studData, studCount);
	cout << "Average: " << average(studData, studCount) << endl << "Median: "
		<< median(studData, studCount) << endl << "Mode: ";
	if (modeDat == -1)
		cout << "None";
	else
		cout << mode(studData,studCount) << endl ;


}




//if the number is not positive or an integer, ask the user to enter valid input
void dataValidation(double &num) {
	do {
		cout << "Error! Invalid Input! Please enter a positive integer: ";
		cin >> num;
	} while (num < 0 && ceil(num)!=floor(num));
	cout << endl;
}

//averageing function
double average(double *studs, double count) {
	double total = 0;
	for (int var = 0; var < count; var++) 
		total += studs[var];
	total = total / count;
	return total;
}
//median finding function
double median(double *studs, double count) {
	//needs to be sorted, so....
	//selection sort
	for (int start = 0;start < count;start++) {
		int mindex = start;
		for (int hunt = start; hunt < count;hunt++) {
			if (studs[hunt] < studs[mindex])
				mindex = hunt;
		}
		//swap
		if (mindex != start) {
			double temp = studs[start];
			studs[start] = studs[mindex];
			studs[mindex] = temp;
		}
	}
	if ((static_cast<int>(count) % 2) > 0) { //odd numbered student count
		return studs[static_cast<int>(count / 2)]; // the static cast drops the decimal points, meaning it always pointing towards the middle value
	}
	else { //even
		double med = ((studs[static_cast<int>(count / 2)]) + (studs[static_cast<int>(count / 2)-1]))/2;
		return med;
	}
}

// mode function  DON'T USE THIS IN THE FUTURE IT DOESN'T WORK ALL THE TIME
double  mode(double *studs, double count) {
	
	//need to sort
	//selection sort
	for (int start = 0;start < count;start++) {
		int mindex = start;
		for (int hunt = start; hunt < count;hunt++) {
			if (studs[hunt] < studs[mindex])
				mindex = hunt;
		}
		//swap
		if (mindex != start) {
			double  temp = studs[start];
			studs[start] = studs[mindex];
			studs[mindex] = temp;
		}
	}
	//search for mode
	
	if (count > 1) {
		double  mode = -1;
		int lastModeCount = 1;
		int modeCount = 0;
		for (int var = 1; var < count;var++) {
			if (studs[var] == studs[var - 1]) {
				modeCount++;
			}
			else {
				if (modeCount > lastModeCount) {
					lastModeCount = modeCount;
					mode = studs[var-1];

				}
				modeCount = 0;
			}
		}
		return mode;
	}
	else if (count = 1) {
		return studs[0];
	}
	else
		return -1;
	
}