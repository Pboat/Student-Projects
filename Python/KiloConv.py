"""
Daniel Bruce
2/16/2018
Unit 3 Assignment
KiloConv.py
Converts distance in miles to kilometers.
"""
CONVERSION_FACTOR = 0.6214

def main():
    print("Convert miles to kilometers!")
    print("What's your distance in miles?")
    distanceMiles = float(input())
    #input converted to float, as the conversion factor is a float
    print("You said your distance in miles is", distanceMiles)
    distanceConversion(distanceMiles)
    #calls distanceConversion with arguement distanceMiles
  

def distanceConversion(distance):
    distanceKilo = float(format((distance * CONVERSION_FACTOR), '.4f'))
    #multiplies distance by conversion factor, rounds to 4 decimal places, then converts back to float from string
    print("That same distance in kilometers is", distanceKilo)

    
main()

"""
Convert miles to kilometers!
What's your distance in miles?
15.7
Your distance in miles is 15.7
That same distance in kilometers is 9.756
"""
#The answer is actually 9.75598, so the rounding does take effect properly
