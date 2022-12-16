"""
Daniel Bruce
2/12/2018
Unit 2 Assignment
TtlPurch.py
Requests the price for 5 different items, then calculates the subtotal, tax, and total price for those items.
"""
TAX_RATE = 0.06


print("Please enter the price of item #1")
item1 = float(input())
print("Please enter the price of item #2")
item2 = float(input())
print("Please enter the price of item #3")
item3 = float(input())
print("Please enter the price of item #4")
item4 = float(input())
print("Please enter the price of item #5")
item5 = float(input())

subTotal = item1 + item2 + item3 + item4 + item5
tax = float(format((subTotal * TAX_RATE), '.2f'))
#I found a neat function in the language comapnion that rounds stuff to 2 chars. however, it seems to convert it to a string, so I had to typecast it back to float
total = subTotal + tax
print("Thank you for shopping with us!")
print("Subtotal: $", subTotal)
print("Tax: $", tax)
print("Total: $",total)
print("Have a nice day!")
#I wanted it to appear like a reciept, so I had to use several print commands to have the same effect. If there's a way to do this with one print function, then I don't know yet
"""Please enter the price of item #1
6
Please enter the price of item #2
3.59
Please enter the price of item #3
3.50
Please enter the price of item #4
1.50
Please enter the price of item #5
12.49
Thank you for shopping with us!
Subtotal: $ 27.08
Tax: $ 1.62
Total: $ 28.7
Have a nice day!"""
