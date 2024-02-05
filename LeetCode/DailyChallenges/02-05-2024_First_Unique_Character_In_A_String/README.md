# 387. First Unique Character in a String
    Given a string s, find the first non-repeating character in it and return its index. If it does not exist, return -1.

 

## Example 1:
    Input: s = "leetcode"
    Output: 0

## Example 2:
    Input: s = "loveleetcode"
    Output: 2

## Example 3:
    Input: s = "aabb"
    Output: -1
 

## Constraints:
    1 <= s.length <= 105
    s consists of only lowercase English letters.

## Solution:

First, I initialize the "answer" to -1, so that if every character repeats, that is returned.
I decided to use a dictionary that contained the character as the key, along with a list of integers for the value
This list of integers holds each index where the character appears.
The next step is to iterate through the dictionary keys. For each key, we check if the list count is > 1 or not.
If the count is = to 1, then this character is not repeated. if answer is -1, we set it to this value(index) otherwise, we compare the value
of answer, and if answer is greater than the index, answer is now the index.

We then return answer.
