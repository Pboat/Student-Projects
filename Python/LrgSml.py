"""
Daniel Bruce
3/2/2018
Unit 5 Assignment
LrgSml.py
Determines the largest and smallest number from a set of numbers
"""
def main():
    firstInput = 0
        #we define the first two compared values here.
        #users need to define at least two values, otherwise,
        #the program wouldn't work. That's why there isn't any 
        #terminating command for the first two inputs.
    print("Enter a number.")
    firstInput = int(input())
    print("Enter another number.")
    strInput = input()
    if firstInput > int(strInput):   #1st number is larger
        greatestNum = firstInput
        lowestNum = int(strInput)
    elif int(strInput) > firstInput: #2nd number is larger
        greatestNum = int(strInput)
        lowestNum = firstInput
    else:                            #Both are equal
        greatestNum = firstInput
        lowestNum = greatestNum
    
        #-99 is a number too, so I used the string "done" as my sentinel value.
        #That is why I used the string strInput instead of an integer variable
    while strInput != "done":  
        if int(strInput) > greatestNum:
            greatestNum = int(strInput)
        elif int(strInput) < lowestNum:
            lowestNum = int(strInput)
        print("Enter another number. When you are done, type \"done\".")
        strInput = input()
    sayTheSize(greatestNum,lowestNum)
#end main

def sayTheSize(big,small):
    print("The largest number is:", big)
    print("The smallest number is:", small)       
#end sayTheSize        
main()

"""
Enter a number.
11
Enter another number.
22
Enter another number. When you are done, type "done".
1234
Enter another number. When you are done, type "done".
-4
Enter another number. When you are done, type "done".
0
Enter another number. When you are done, type "done".
-99
Enter another number. When you are done, type "done".
done
The largest number is: 1234
The smallest number is: -99
"""
