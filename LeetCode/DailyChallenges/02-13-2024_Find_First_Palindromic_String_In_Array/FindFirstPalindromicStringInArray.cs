public class Solution {
    public string FirstPalindrome(string[] words) 
    {
        string answer = "";
        for(int i = 0; i < words.Length; i++)
        {
            int index1 = 0;
            int index2 = words[i].Length - 1;
            answer = "";
            if(words[i].Length == 1)
            {
                return words[i];
            }
            else
            {
                while(index1 < index2)
                {
                    if(words[i][index1] != words[i][index2])
                    {
                        break;
                    }
                    else
                    {
                        index2--;
                        index1++;
                        if(index2 <= index1)
                        {
                            answer = words[i];
                            return answer;
                        }
                    }
                }
            }
        }
        return answer;
    }
}