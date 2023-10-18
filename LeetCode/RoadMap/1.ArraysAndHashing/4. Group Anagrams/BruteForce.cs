public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        IList<IList<string>> answer = new List<IList<string>>();
        Dictionary<string,List<string>> answerDict = new Dictionary<string,List<string>>();
        if(strs.Length == 0)
        {
        answer.Add(new List<string>());
            answer[0].Add("");
        }
        else if(strs.Length == 1)
        {
            answer.Add(new List<string>());
            answer[0].Add(strs[0]);
        }
        else
        {
            for(int i = 0; i < strs.Length;i++)
            {
                string str = String.Concat(strs[i].OrderBy(c => c));
                if(!answerDict.ContainsKey(str))
                {
                    answerDict[str] = new List<string>();
                }
                answerDict[str].Add(strs[i]);
            }
            foreach(List<string> value in answerDict.Values)
            {
                answer.Add(value);
            }
        }
        return answer;
    }
}