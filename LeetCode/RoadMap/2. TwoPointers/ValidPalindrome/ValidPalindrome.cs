public class Solution {
    public bool IsPalindrome(string s) 
    {
        int firstPointer = 0;
        int secondPointer = s.Length -1;
        bool answer = true;
        while(firstPointer < secondPointer)
        {
            while(s[firstPointer] == ' ' || !char.IsLetterOrDigit(s[firstPointer]))
            {
                firstPointer++;
                if(firstPointer > secondPointer)
                {
                   return answer;
                }
            }
            while(s[secondPointer] == ' '|| !char.IsLetterOrDigit(s[secondPointer]))
            {
                secondPointer--;
                if(firstPointer > secondPointer)
                {
                    return answer;
                }
            }
            if(char.ToUpper(s[firstPointer]) != char.ToUpper(s[secondPointer]))
            {
                return false;
            }
            else
            {
                firstPointer++;
                secondPointer--;
            }
        }
        return answer;
    }
}
