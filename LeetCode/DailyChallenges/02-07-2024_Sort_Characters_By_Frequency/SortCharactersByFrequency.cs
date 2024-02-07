public class Solution {
    public string FrequencySort(string s) 
    {
        Dictionary<char,int> answerDict = new Dictionary<char,int>();
        for(int i = 0; i < s.Length;i++)
        {
            if(answerDict.ContainsKey(s[i]))
            {
                answerDict[s[i]] += 1;
            }
            else
            {
                answerDict[s[i]] = 1;
            }
        }
        string answerString = "";
        //Linq to order by descending
        foreach(var pair in answerDict.OrderByDescending(p => p.Value)) 
        {
            char curChar = pair.Key;
            int loops = pair.Value;
            for(int j = 0; j < loops;j++)
            {
                answerString += curChar;
            }
        }
        return answerString;
    }
}