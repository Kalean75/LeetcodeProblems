The brute force solution can be achieved by sorting both the strings, and then seeing if they are equal or not.

The more optimal solution, taking O(n) time, is to fill 2 dictionaries, one with the characters in each string. 

You then check if the dictionary count is the same, if not, they can't be anagrams

Otherwise, if the same count, do a foreach loop, going through the keys of one dictionary. For every key in dictionary 1, If the other dictionary does not contain this key, or the values do not match, then return false.

Otherwise, return true