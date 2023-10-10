The solution to this is simple. One can check if there is duplicates in an array simply by creating a hashset. If while iterating though the loop, the HashSet contains the number in the array, then there is a duplicate and return true.

Otherwise, once you get through the entire array. Return false.