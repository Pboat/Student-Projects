"""
Daniel Bruce
3/12/2018
Unit 6 Assignment
TestAvg.py
Determines your test average and letter grade.
"""
#no need to import anything this time

def main(): #I can't allow decimals without an array (can't use those), so I need to put in a disclaimer.
    print("Average your test scores! Please use integers.") 
    scoreAverage = calcAverage()
    print("The average of all of your scores is:",int(scoreAverage),"%")
    print("This means your grade is a(n)",determineGrade(scoreAverage),".")    
#end main
    
def calcAverage():
    #need to define this now so it's not null
    totalScore = 0
    for theCount in range(1,6):
        print("Enter score number", theCount)
        scorecery = getValidScore()
        totalScore = scorecery+totalScore    
    return(totalScore/5)
#end calcAverage

def determineGrade(averageGrade):
    if averageGrade>=90:
        gra="A"
    elif averageGrade>=80 and averageGrade<90:
        gra="B"
    elif averageGrade>=70 and averageGrade<80:
        gra="C"
    elif averageGrade>=60 and averageGrade<70:
        gra="D"
    else:
        gra="F" #The program already checked if the score was in range, so no need to check for those cases
    return gra
#end determineGrade

def getValidScore():
        inp = input()
        while isValidScore(inp) == False:
            print ("Error: invalid input")
            print ("Please input an integer between 0 and 100.")
            inp = input()
        return int(inp)             
#end getValidScore
    
def isValidScore(score):                            
     if score == "" or str.isdigit(score)==False  or int(score)<0 or int(score)>100:
         return False
     else:
         return True
#end isValidScore
    
    
main()

"""

"""
