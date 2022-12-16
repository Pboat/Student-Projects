
#ifndef PLANE_H
#define PLANE_H
#include <string>
using namespace std;
class Plane {
	private:
		int section = 0;
		int seats[2] = {0,0}; // First class is pos 0, economy is pos 1


	public:

		void CheckIn();
		//increments first class seats taken
		string FirstClassUp() {
			string capacity = "";
			if (seats[0] < 5) {
				seats[0]++;
				capacity = "Seat added to first class.";
			}
			else {
				capacity = "No more seats are available in first class.";
			}
			return capacity;
		}
		//increments economy class seats taken
		string EconomyClassUp() {
			string capacity = "";
			if (seats[1] < 5) {
				seats[1]++;
				capacity = "Seat added to economy.";
			}
			else{
				capacity = "No more seats are available in economy.";
			}
			return capacity;

		}

		//getters and setters
		void SetSection(int choice) {
			section = choice;
		}

		int GetSection() {
			return section;
		}
		int* GetSeats() {
			return seats;
		}
};
#endif
