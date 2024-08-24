public class Solution 
{
    Dictionary<string,List<int>> answer = new Dictionary<string,List<int>>();
    public string Encode(IList<string> strs) 
    {
        string returnedString = "";
        for(int i = 0; i < strs.Count;i++)
        {
            if(answer.ContainsKey(strs[i]))
            {
                answer[strs[i]].Add(i);
            }
            else
            {
                answer[strs[i]] = new List<int>{i};
            }
           returnedString += strs[i];
           returnedString += " ";
        }
        return returnedString;
    }

    public List<string> Decode(string s) 
    {
        List<string> returnedList = new List<string>();
        string currString = "";
        int count = 0;
        for(int i = 0; i < s.Length;i++)
        {
            if(answer.ContainsKey(currString))
            {
                if(answer[currString].Contains(count))
                {
                    returnedList.Add(currString);
                    currString = "";
                    count++;
                }
                else
                {
                   currString += s[i]; 
                }
            }
            else
            {
                currString += s[i];
            }

        }
        return returnedList;
    }
}
