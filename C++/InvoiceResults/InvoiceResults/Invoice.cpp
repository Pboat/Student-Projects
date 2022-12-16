#include "pch.h"
#include "Invoice.h"
#include <iostream>
using namespace std;

double Invoice::GetTotal() {
	return quant * price;

}