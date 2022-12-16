"""
Daniel Bruce
3/30/2018
Assignment #7
ValidAcct.py
Determines whether an account number input by a user is valid
"""

def Main():
    validNums=[5658845,8080152,1005231,4520125,4562555,
               6545231,7895122,5552012,3852085,8777541,
               5050552,7576651,8451277,7825877,7881200,
               1302850,1250255,4581002]
    print("Please enter your account number:")
    userNum= input()
    #It checks if it's numeric first to prevent errors when converting in the 2nd check
    if str.isdigit(userNum) == True and validateAccNum(int(userNum),validNums) == True:
        print (userNum, "is a valid account number")
    else:
        print ("Error! Invalid account number")
    
#end main

def validateAccNum(inpNum,valAccts):
    valid = False
    for count in range(0,len(valAccts)):
        if inpNum == valAccts[count]:
            valid = True
    return valid

#end validateAccNum
Main()

"""
Please enter your account number:
boo spooky ghoost
Error! Invalid account number
>>> 
Please enter your account number:

Error! Invalid account number
>>> 
Please enter your account number:
1234567
Error! Invalid account number
>>> 
Please enter your account number:
8451277
8451277 is a valid account number
>>>
"""
