/**
Name: Daniel Bruce
Date:11/14/2018
Class:CIS2541 - NET01 C++ Language Programming
Description: This program allows users to fill up a each of a plane's 
			 sections by letting users "check in"
**/

#include "pch.h"
#include <iostream>
#include "Plane.cpp"

using namespace std;

int main()
{
	//plane object
	Plane Moening474;
	//intro
	cout << "Take reservations! Add paassengers to the plane until the plane is full." << endl;
	//main process
	Moening474.CheckIn();
	//close program when plane is full
	
	exit(0);
	
}

