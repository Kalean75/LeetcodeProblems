public class Solution {
    public int FirstUniqChar(string s) 
    {
        Dictionary<char,List<int>> answer = new Dictionary<char,List<int>>();
        int answerIndex = -1;
        for(int i = 0; i < s.Length;i++)
        {
            if(answer.ContainsKey(s[i]))
            {
                answer[s[i]].Add(i);
            }
            else
            {
                answer[s[i]] = new List<int>();
                answer[s[i]].Add(i);
            }
        }
        foreach(char key in answer.Keys)
        {
            if(answer[key].Count == 1)
            {
                if(answerIndex < 0 || answer[key][0] < answerIndex)
                {
                    answerIndex = answer[key][0];
                }
            }
        }
        return answerIndex;
    }
}