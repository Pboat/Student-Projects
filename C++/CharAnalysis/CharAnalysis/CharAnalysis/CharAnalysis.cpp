/**
Name: Daniel Bruce
Date:10/25/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: This program reads text from a file, then reports the number of times
			 that certain kinds of characters appear.
**/

#include "pch.h"
#include <iostream>
#include <fstream>
#include <string>
#include <cctype>

using namespace std;



int main()
{
	//open file
	ifstream fileInput;
	fileInput.open("*\\Unit10\\CharAnalysis\\text.txt");

	//file text variables
	string text;
	string input;
	//read file and put it in the text variable
	while (fileInput >> input) {
		text.append(input);
	}


	//variables for counting
	int upCount = 0;
	int lowCount = 0;
	int numCount = 0;

	//counting uppercase characters
	for (int var = 0; var < text.length();var++) {
		
		if (isupper(text[var])) {
			upCount++;
		}
	}
	//counting lowercase characters
	for (int var = 0; var < text.length();var++) {
		
		if (islower(text[var])) {
			lowCount++;
		}
	}
	//counting digits
	for (int var = 0; var < text.length();var++) {
		
		if (isdigit(text[var])) {
			numCount++;
		}
	}

	//output results
	cout << "Text analysis of text.txt" << endl << endl << "Uppercase letters: " << upCount << endl << "Lowercase letters: " 
		 << lowCount << endl << "Numbers: " << numCount << endl ;

	//close file
	fileInput.close();
}
