/**

using namespace std;
**/
#include "Plane.h"
#include <iostream>
using namespace std;
 
void Plane::CheckIn() {
	while (seats[0] < 5 || seats[1] < 5) {
		cout << "Enter 1 to add a seat to 1st class, or 2 to add a seat to first class:" << endl;
		cin >> section;
		if (GetSection() == 1) { // add seat to first class
			cout << FirstClassUp() << endl;
		}
		else if (GetSection() == 2) { // add seat to economy
			cout << EconomyClassUp() << endl;


		}

	}
	cout << "All seats are full! Preparing for takeoff!";
}



