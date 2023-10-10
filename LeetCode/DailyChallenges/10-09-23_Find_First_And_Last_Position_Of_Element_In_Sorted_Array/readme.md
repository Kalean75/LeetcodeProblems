There are a couple of approaches:
First is what I implemented originally, which is just  simple for loop, which takes O(n)
The other alternative is to use Binary search, which in the best case is O(log n) and worst is O(n).

My original solution is in BruteForce.Cs, and simply utilizes a single for loop and accounts for some edge cases.
The "Optimal" solution implemented later is named after the problem, however in many cases the brute force solution does just as well.

The reason the brute force solutuion works just as well in many cases is because binary search performs at O(n) in worst case, and the brute force is always O(n). But in a best case, Binary search will be quicker at O(log n)

binary search pseudocode:

left()
while left less than or equal to right
    left = 0;
    right = array.Legth -1;
    mid = left + (right/2);

    if array[mid] >= target
        move right towards 0 (mid - 1)

    otherwise
        move left towards end of the array(mid + 1)

right() 
while left less than or equal to right
    left = 0;
    right = array.Legth -1;
    mid = left + (right/2);

    if array[mid] <= target>
        move left towards end of the array(mid + 1)
    
    otherwise 
        move right towards 0 (mid - 1)
