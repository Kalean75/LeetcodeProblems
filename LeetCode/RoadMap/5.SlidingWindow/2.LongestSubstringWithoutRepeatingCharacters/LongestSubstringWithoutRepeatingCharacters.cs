public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> charDict = new Dictionary<char, int>();
        int length = 0;
        int maxLength = 0;
        
        for (int rightPointer = 0; rightPointer < s.Length; rightPointer++) 
        {
            if (charDict.ContainsKey(s[rightPointer])) 
            {
                length = Math.Max(charDict[s[rightPointer]] + 1, length);
            }
            charDict[s[rightPointer]] = rightPointer;
            maxLength = Math.Max(maxLength, rightPointer - length + 1);
        }
        return maxLength;
    }
}