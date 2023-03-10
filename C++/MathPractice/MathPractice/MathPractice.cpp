/**
Name: Daniel Bruce
Date:9/27/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: A program where users can practice basic arithmetic
	by taking randomly generated quizzes of their choosing
**/

//headers
#include "pch.h"
#include <iostream>
#include <cmath>
#include <ctime>
using namespace std;

/*math function prototypes. All will make two random int's, calculate the solution,
accept user input for their answer, then respond depending on whether they were
correct or not.
*/
void mathAdd();
void mathSub();
void mathMulti();
void mathDiv();
void mathMod();

// input validation function prototype.
void inpValidation(double &);

// main function
int main()
{


	cout << "/\\/\\/\\/Basic Math Practice!\\/\\/\\/\\"<< endl;
	//main loop
	for (int stayStatus = 1;stayStatus;) 
	{
		//seed randomizer
		srand(time(0));

		double selection = 0;
		cout << "Please enter the matching number to make your selection:"<< endl << "1 - Addition" << endl
			<< "2 - Subtraction" << endl << "3 - Multiplication" << endl << "4 - Long Division"
			<< endl << "5 - Remainder Division" << endl << "6 - Exit" << endl;
		cin >> selection;
		inpValidation(selection);

		switch (static_cast<int>(selection)) {

			case 1:
				mathAdd();
				break;
			case 2:
				mathSub();
				break;
			case 3:
				mathMulti();
				break;
			case 4:
				mathDiv();
				break;
			case 5:
				mathMod();
				break;
			case 6:
				stayStatus = 0;
				break;
			default:
			cout << "Error! Invalid input! Please enter a number between 1 and 6. " << endl;
			break;
		}

	}

}

void mathAdd() //addition
{
	int qCount = 0;
	int rightCount = 0;
	int wrongCount = 0;
	int stay = 1;
	cout << "Enter -1 to return to the menu."<< endl;
	while (stay) { // makes the loop repeat until we escape with return later on.
		int num1 = rand() % 10;
		int num2 = rand() % 10;

		int solution = num1 + num2;
		double answer = -2;
		int incorrect = 1; // I named this "incorrect" because naming it
						   //correct would mean that correct needs to be false to exit 
						   //the loop, and that can get a bit confusing
		do {
			cout << "What is " << num1 << " + " << num2 << "?" << endl;
			cin >> answer;
			inpValidation(answer);

			if (static_cast<int>(answer) == solution) {
				incorrect = 0;
				cout << "Correct! :)" << endl;
				rightCount++;
				qCount++;
			}
			else if (static_cast<int>(answer) == -1) {
				stay = 0; 
				incorrect = 0;
			}
			else{
				cout << "Incorrect! Please try again." << endl;
				wrongCount++;
				qCount++;
			}
			
		} while (incorrect);
	}
	//summary
	cout << endl << "Session Summary:" << endl << endl << "Total Questions: " << qCount << endl << "Correct Answers: "
		<< rightCount << endl << "Wrong Answers: " << wrongCount << endl << endl;
	return;
}

void mathSub() // subtraction
{
	int qCount = 0;
	int rightCount = 0;
	int wrongCount = 0;
	int stay = 1;
		cout << "Enter -1 to return to the menu." << endl;
	while (stay) {
		int num1 = rand() % 10;
		int num2 = rand() % 10;

		//since we are using -1 as our sentinel value, we can't have negative solutions. 
		//This if statement prevents that by swapping the random numbers.
		if (num2 > num1) {
			int swap = num2;
			num2 = num1;
			num1 = swap;
		}

		int solution = num1 - num2;
		double answer = -2;
		int incorrect = 1;
		do {
			cout << "What is " << num1 << " - " << num2 << "?" << endl;
			cin >> answer;
			inpValidation(answer);

			if (static_cast<int>(answer) == solution) {
				incorrect = 0;
				cout << "Correct! :)" << endl;
				rightCount++;
				qCount++;
			}
			else if (static_cast<int>(answer) == -1) {
				stay = 0;
				incorrect = 0;
			}
			else {
				cout << "Incorrect! Please try again." << endl;
				wrongCount++;
				qCount++;
			}
			
		} while (incorrect);
	}
	cout << endl << "Session Summary:" << endl << endl << "Total Questions: " << qCount << endl << "Correct Answers: "
		<< rightCount << endl << "Wrong Answers: " << wrongCount << endl << endl;
	return;
}

void mathMulti() //multiplication
{
	int qCount = 0;
	int rightCount = 0;
	int wrongCount = 0;
	int stay = 1;
	cout << "Enter -1 to return to the menu." << endl;
	while (stay) {
		int num1 = rand() % 10;
		int num2 = rand() % 10;

		int solution = num1 * num2;
		double answer = -2;
		int incorrect = 1; 

		do {
			cout << "What is " << num1 << " X " << num2 << "?" << endl;
			cin >> answer;
			inpValidation(answer);

			if (static_cast<int>(answer) == solution) {
				incorrect = 0;
				cout << "Correct! :)" << endl;
				rightCount++;
				qCount++;
			}
			else if (static_cast<int>(answer) == -1) {
				stay = 0;
				incorrect = 0;
			}
			else {
				cout << "Incorrect! Please try again." << endl;
				wrongCount++;
				qCount++;
			}
			
		} while (incorrect);
	}
	cout << endl << "Session Summary:" << endl << endl << "Total Questions: " << qCount << endl << "Correct Answers: "
		<< rightCount << endl << "Wrong Answers: " << wrongCount << endl << endl;
	return;
}

void mathDiv() // division
{
	int qCount = 0;
	int rightCount = 0;
	int wrongCount = 0;
	int stay = 1;
	cout << "Enter -1 to return to the menu." << endl;
	while (stay) {
		int num1 = rand() % 10;
		int num2 = rand() % 10;

		//prevents a divide by 0 error.
		while (num2 == 0) {
			int num2 = 100 * rand();
		}

		double solution = static_cast<double>(num1) / static_cast<double>(num2);
		solution = round((solution*100))/100; //rounds it to 2 decimal places
		double answer = -2.0;
		int incorrect = 1;
		cout << "Round your answer to 2 decimal places." << endl;
		do {
			cout << "What is " << num1 << " / " << num2 << "?" << endl;
			cin >> answer;
			//no input validation needed

			if (answer == solution) {
				incorrect = 0;
				cout << "Correct! :)" << endl;
				rightCount++;
				qCount++;
			}
			else if (answer == -1) {
				stay = 0;
				incorrect = 0;
			}
			else {
				cout << "Incorrect! Please try again." << endl;
				wrongCount++;
				qCount++;
			}
			
		} while (incorrect);
	}
	cout << endl << "Session Summary:" << endl << endl << "Total Questions: " << qCount << endl << "Correct Answers: "
		<< rightCount << endl << "Wrong Answers: " << wrongCount << endl << endl;
	return;
}

void mathMod() // Remainder division / modulus
{
	int qCount = 0;
	int rightCount = 0;
	int wrongCount = 0;
	int stay = 1;
	cout << "Enter -1 to return to the menu." << endl;
	while (stay) {
		int num1 = rand() % 10;
		int num2 = rand() % 10;

		//prevents a divide by 0 error.
		while (num2 == 0) {
			int num2 = 100 * rand();
		}

		int solution = num1 % num2;
		double answer = -2;
		int incorrect = 1;
		do {
			cout << "What is the remainder of " << num1 << " / " << num2 << "?" << endl;
			cin >> answer;
			inpValidation(answer);

			if (static_cast<int>(answer) == solution) {
				incorrect = 0;
				cout << "Correct! :)" << endl;
				rightCount++;
				qCount++;
			}
			else if (static_cast<int>(answer) == -1) {
				stay = 0;
				incorrect = 0;
			}
			else {
				cout << "Incorrect! Please try again." << endl;
				wrongCount++;
				qCount++;
			}
			
		} while (incorrect);
	}
	cout << endl << "Session Summary:" << endl << endl << "Total Questions: " << qCount << endl << "Correct Answers: "
		<< rightCount << endl << "Wrong Answers: " << wrongCount << endl << endl;
	return;
}
// input validation

void inpValidation(double &num) {
	while (floor(num) != ceil(num)) {
		cout << "Error! Invalid Input! Please enter an integer: ";
		cin >> num;
	}
	return;
}


