# 1137. N-th Tribonacci Number

## The Tribonacci sequence Tn is defined as follows: 
    T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
    Given n, return the value of Tn.

### Example 1:
    Input: n = 4
    Output: 4
    Explanation:
    T_3 = 0 + 1 + 1 = 2
    T_4 = 1 + 1 + 2 = 4

### Example 2:
    Input: n = 25
    Output: 1389537
 
### Constraints:
    0 <= n <= 37

#### The answer is guaranteed to fit within a 32-bit integer, ie. answer <= 2^31 - 1.

### solution
    Create a list. Populate the list with the provided numbers. Since there will only ever be 3 numbers used in the calculation, I simply calculate the current value, then shift listp[2] to list[1] and list[1] to list[0]. Respectively. Finally, replace list[2] with the current value.

    If n is less than 3, then it is one of the provided numbers initially. since there can't be 3 numbers added. 

#### BIG O
    Should run in O(n) time, since there is a single for loop used.