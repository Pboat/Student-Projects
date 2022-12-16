"""
Daniel Bruce
4/30/2018
Unit 10 Assignment
CarPrg.py
Displays the speed of a car that accelerates to 25 mph, then brakes to a
complete stop. Nothing more.
"""
class Car:
    def __init__(self, year, mak):
        self.__yearModel = year
        self.__make = mak
        self.__speed = 0
    #gets
    def getYearModel(self):
        return self.__yearModel
    def getMake(self):
        return self.__make
    def getSpeed(self):
        return self.__speed
    #sets
    def setYearModel(self, year):
        self.__yearModel = year
    def setMake(self, mak):
        self.__make = mak
    #other
    def accelerate(self):
        self.__speed = self.__speed + 5
    def brake(self):
        if self.__speed >= 5:
            self.__speed = self.__speed - 5
        if self.__speed < 5:
            self.__speed = 0
#end Car

def main():
    pontiacGTO = Car(1970, 'Pontiac')
    #acceleration
    for count in range(1,6):
        pontiacGTO.accelerate()
        print("That",pontiacGTO.getYearModel(),pontiacGTO.getMake(),
              "is going",pontiacGTO.getSpeed(),"MpH.")
    #braking 
    for count in range(1,6):
        pontiacGTO.brake()
        print("That",pontiacGTO.getYearModel(),pontiacGTO.getMake(),
              "is going",pontiacGTO.getSpeed(),"MpH.")

#end main


main()
