"""
Daniel Bruce
2/26/2018
Unit 4 Assignment
ShipChg.py
Determines a customer's shipping charge based on (input) package weight.
"""
def main():
    print("Enter package weight(lbs):")
    weight = float(input())
    ProvideShipping(weight)
#end main
    
def ProvideShipping(wght):
    UNDER_TWO = 1.1 
    TWO_TO_SIX = 2.2
    SIX_TO_TEN = 3.7
    OVER_TEN = 3.8
    #These names refer to weight, with the values being their respective multipliers
    shipping = 1
    #just to be safe
    
    if wght > 10:
        shipping = wght * OVER_TEN
    elif wght > 6 and wght <= 10:
        shipping = wght * SIX_TO_TEN
    elif wght > 2 and wght <= 6:
        shipping = wght * TWO_TO_SIX
    else:
        shipping = wght * UNDER_TWO
    print("Your shipping charge is: $", float(format((shipping), '.2f')))
    
#end ProvideShipping

main()

"""
(Input 3.25)
Enter package weight(lbs):
3.25
Your shipping charge is: $ 7.15

(Input 1)
Enter package weight(lbs):
1
Your shipping charge is: $ 1.1

(Input 7)
Enter package weight(lbs):
7
Your shipping charge is: $ 25.9

(Input 15)
Enter package weight(lbs):
15
Your shipping charge is: $ 57.0
"""
