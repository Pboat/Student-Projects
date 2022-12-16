#ifndef TIMECARD_H
#define	TIMECARD_H
#include <String>
#include "Time2.cpp"

using namespace std;

class TimeCard : public Time2 {

	private:
		string workerID;
		Time2 punchInTime, punchOutTime;
		double payrate;
		bool hasPunched;

	public:
		//defined in main file
		double getShiftLength();
		double getPay();

		//constructors
		TimeCard() {
			//default
			workerID = "000000000";
			payrate = 0;
			hasPunched = false;
		}

		TimeCard(string id, int iHour, int iMin, int iSec, int oHour, int oMin, int oSec, double pRate, bool punched) {
			
			workerID = id;
			punchInTime.setHour(iHour);
			punchInTime.setMinute(iMin);
			punchInTime.setSecond(iSec);
			punchOutTime.setHour(oHour);
			punchOutTime.setMinute(oMin);
			punchOutTime.setSecond(oSec);
			payrate = pRate;
			hasPunched = punched;
		}

		//getters and setters

		string getWorkerID() {
			return workerID;
		}

		void setWorkerID(string id) {
			workerID = id;
		}
		//in
		Time2 getPunchInTime() {
			return punchInTime;
		}

		void setPunchInTime(Time2 punchI) {
			punchInTime = punchI;
		}
		//out
		Time2 getPunchOutTime() {
			return punchOutTime;
		}

		void setPunchOutTime(Time2 punchO) {
			punchOutTime = punchO;
		}

		double getPayrate() {
			return payrate;
		}

		void setPayrate(double pRate) {
			payrate = pRate;
		}

		bool getHasPunched() {
			return hasPunched;
		}

		void setHasPunched(bool hasP) {
			hasPunched = hasP;
		}
		
		
}

#endif