// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

#ifndef COST_H
#define COST_H
#include <string>
namespace std {
	struct Cost {
		string descr;
		string price; //corresponds with amount heading
		string id; // corresponds with item number heading
	};
}

#endif //COST_H
