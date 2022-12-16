"""
Daniel Bruce
4/9/2018
Assignment #8
FileAvg.py
Takes the numbers from a given file and displays their average
"""

def main():
    avgFile()

#end main

def avgFile():
    counter = 0
    numTotal = 0
    numList = open('numbers.dat','r')
    listerine = numList.readline()

    while listerine != '':
        numTotal = numTotal + int(listerine.rstrip('\n'))
        counter = counter + 1
        listerine = numList.readline()
        
    print(format((numTotal/counter),'.3f'))#formatting rounds to 3 decimal places
    numList.close()

#end avgFile
main()

"""
====== RESTART: C:\Users\panth\Documents\CompSci\Prog Logic\FileAvg.py ======
59.286
>>> 
"""

