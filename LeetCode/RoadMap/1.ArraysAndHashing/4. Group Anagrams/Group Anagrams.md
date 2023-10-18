The brute Force solution was achieved as follows:
Take a List of Lists, which is our final answer, and a dictionary of lists to sort anagrams.

Using a for loop, sort each string alphabetically, use this as the Key in the dictionary, and add each of the unsorted words to the list of values for each sorted key.

Using a foreach loop, loop through the values in the dictionary(as the values are lists), and add these lists to our answer list. Then return this list and we have our solution!