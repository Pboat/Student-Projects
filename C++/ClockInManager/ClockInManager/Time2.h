#ifndef TIME2_H
#define	TIME2_H

#include <string>

using namespace std;

class Time2 {

	//data fields
private:
	int second;
	int minute;
	int hour;
public:
	//constructors
	Time2() {
		//default
		second = 0;
		minute = 0;
		hour = 0;
	}

	Time2(int sec, int min, int hr);
	//defined in main file

	//getters and setters
	int getSecond() {
		return second;
	}
	void setSecond(int sec);
	//defined in main file

	int getMinute() {
		return minute;
	}
	void setMinute(int min) {
		while (min >= 60) {
			min -= 60;
			hour++;
		}
		minute = min;

	}
	int getHour() {
		return hour;
	}
	void setHour(int hr) {
		hour = hr;
	}

	virtual string toString() {
		int hr = (hour>12 ? hour-12 : hour);
		string str = (hr < 10 ? "0" : "");
		str += to_string(hr);
		str += ":";
		str += (minute < 10 ? "0" : "");
		str += to_string(minute);
		str+= ":";
		str += (second < 10 ? "0" : "");
		str += to_string(second);
		str += (hour > 12 ? "PM" : "AM");
		return str;
	}
};
#endif

