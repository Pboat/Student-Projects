
#include "pch.h"
#include "TimeCard.h"

//I don't know why, but I have problems if this semicolon isn't placed before the functions. Please don't touch it
;

//calculates shift duration
double TimeCard::getShiftLength() {
	return -((static_cast<double>(punchInTime.getHour()) + (static_cast<double>(punchInTime.getMinute()) / 60) + 
		(static_cast<double>(punchInTime.getSecond()) / 3600)) - (static_cast<double>(punchOutTime.getHour()) + 
		(static_cast<double>(punchOutTime.getMinute()) / 60) + (static_cast<double>(punchOutTime.getSecond()) / 3600)))  ;
}
//calculates shift pay
double TimeCard::getPay() {
	return getShiftLength() * payrate;
}