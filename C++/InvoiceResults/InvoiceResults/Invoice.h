#ifndef INVOICE_H
#define INVOICE_H

#include <string>

using namespace std;

class Invoice {

private:
	int prtNum;
	string prtDesc;
	int quant;
	double price;

public:
	//defined later
	double GetTotal();

	//constructors
	Invoice() {
		//default
		prtNum = 0;
		prtDesc = "none";
		quant = 0;
		price = 0.0;
	}
	Invoice(int num, string desc, int count, double mon) {

		prtNum = num;
		prtDesc = desc;
		quant = count;
		price = mon;
	}

	// = operator overload
	//we'll be swapping around instance variables a lot soon, so this will be useful
	const Invoice operator=(const Invoice &right) {
		if (this != &right) {
			prtNum = right.prtNum;
			prtDesc = right.prtDesc;
			quant = right.quant;
			price = right.price;
		}
		return *this;
	}


	//getters & setters
	int GetPrtNum() {
		return prtNum;
	}

	void SetPrtNum(int num) {
		prtNum = num;
	}

	string GetPrtDesc() {
		return prtDesc;
	}

	void SetPrtDesc(string desc) {
		prtDesc = desc;
	}

	int GetQuant() {
		return quant;
	}

	void SetQuant(int num) {
		quant = num;
	}

	double GetPrice() {
		return price;
	}

	void SetPrice(double num) {
		price = num;
	}

};
#endif
