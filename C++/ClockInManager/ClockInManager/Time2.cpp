#include "pch.h"
#include "Time2.h"

using namespace std;

//place more complex function definitions here

void Time2::setSecond(int sec) {
	while (sec >= 60) { //for every minute in seconds, add a minute to variable minute
		while (sec >= 3600) //same as above, but for every hour in seconds instead
		{
			sec -= 3600;
			hour++;
		}
		sec -= 60;
		minute++;
	}
	second = sec;
}

Time2::Time2(int sec, int min, int hr) {

	hour = hr;
	//while (min >= 60) {
	//	min -= 60;
	//	hr++;
	//}
	minute = min;
	//while (sec >= 60) {
	//	while (sec >= 3600)
		//{
		//	sec -= 3600;
		//	hour++;
		//}
		//sec -= 60;
		//minute++;
	//}
	second = sec;
}