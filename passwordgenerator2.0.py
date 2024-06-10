# Version 2.0 - Password Generator
# Programmer: Sidney Andreano
# Last modified: 6/6/2024 10:53AM EST
# --------------------------------------------------------------------------------------------------------------------------------

# incorporates the random and string modules

import random 
import string

# initialized variables to be used for an array
SetList = ""

# Input from user 
passwordQuestion = int(input("Enter password length:"))

print('''Choose the character sets you want to include: 
    1. Digits (1-9)
    2. Letters (A-Z)
    3. Special Characters (Punctuation Marks)
    4. Exit''')

while(True):
    choice = int(input("Pick a number to choose what set to include: "))
    if (choice == 1):
        SetList += string.digits
    elif(choice == 2):
        SetList += string.ascii_letters
    elif(choice == 3):
        SetList += string.punctuation
    elif(choice == 4):
        break
    else:
        print("Enter a valid number: ")
# The array that will store all possible characters 
s = []

for i in range(passwordQuestion):
    randomchar = random.choice(SetList)
    s.append(randomchar)

# Output
print("Your password:","".join(random.sample(s, passwordQuestion))) # generates a random sample of a specified length from the provided s list

# END PROGRAM