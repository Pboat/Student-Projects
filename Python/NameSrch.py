"""
Daniel Bruce
4/13/18
Assignment #9
Searches through a sorted list of names using a binary search algorithm
"""
def main():
    restart = "y" 
    while str.lower(restart) == "y":
      restart = "n" 
      names = ['Ava Fischer', 'Bob White', 'Chris Rich', 'Danielle Porter', 'Gordon Pike', 'Hannah Beauregard', 'Matt Hoyle', 'Ross Harrison', 'Sasha Ricci', 'Xavier Adams']
      print ("Enter the first and last name of the person you are looking for:")
      searchedName = input()
      foundPosition = binarySearch(names,searchedName)
      if foundPosition == -1:
          print("Name not found. Please try a different name.")
      else:
          print(names[foundPosition]+" is in the database.")
      print("If you would like to search again, please enter \"y\".")
      restart = input()
#end main

def binarySearch(names,searchedName):
    size = len(names) 
    start = 0
    end = size-1
    found = False
    pos = -1
    
    while not found and start <= end:
        middle = int((start + end)/2)
        
        if str.upper(names[middle]) == str.upper(searchedName): #str.upper on both variables makes the comparison case insensitive
            pos = middle
            found = True
        elif str.upper(names[middle]) > str.upper(searchedName):
            end = middle-1
        else:
            start = middle+1
    
    return pos
        

#end binarySearch
main()


"""
Enter the first and last name of the person you are looking for:
bob
Name not found. Please try a different name.
If you would like to search again, please enter "y".
Y
Enter the first and last name of the person you are looking for:
Bob White
Bob White is in the database.
If you would like to search again, please enter "y".
y
Enter the first and last name of the person you are looking for:
aVA fISCHER
Ava Fischer is in the database.
If you would like to search again, please enter "y".
n
>>>
"""
