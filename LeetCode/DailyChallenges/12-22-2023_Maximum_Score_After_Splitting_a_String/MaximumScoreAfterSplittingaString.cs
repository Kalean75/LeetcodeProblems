public class Solution {
    public int MaxScore(string s) 
    {
        int maxNum = 0;
        for(int i = 0; i < s.Length;i++)
        {
            int currentNum = 0;
            for(int j = 0; j <= i; j++)
            {
                if(j == s.Length - 1)
                {
                    break;
                }
                if(s[j] == '0')
                {
                    currentNum +=1;
                }
            }
            for(int k = i+1; k < s.Length; k++)
            {
                if(s[k] == '1')
                {
                    currentNum +=1;
                }
            }
            if(currentNum > maxNum)
            {
                maxNum = currentNum;
            }
        }
        return maxNum;
    }
}