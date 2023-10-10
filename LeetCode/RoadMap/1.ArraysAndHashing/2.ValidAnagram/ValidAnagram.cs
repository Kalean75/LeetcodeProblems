public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        Dictionary<char,int> dict1 = new Dictionary<char,int>();
        Dictionary<char,int> dict2 = new Dictionary<char,int>();
        if(s.Length != t.Length)
        {
            return false;
        }
        //fill up dictionary with occurrences
        for(int i = 0; i < s.Length; i++)
        {
            if(dict1.ContainsKey(s[i]))
            {
                dict1[s[i]] +=1;
            }
            else
            {
                dict1[s[i]] = 1;
            }
            if(dict2.ContainsKey(t[i]))
            {
                dict2[t[i]] +=1;
            }
            else
            {
                dict2[t[i]] = 1;
            }          
        }
        if(dict1.Count != dict2.Count)
        {
            return false;
        }
        foreach(char key in dict1.Keys)
        {
            if(!dict2.ContainsKey(key))
            {
                return false;
            }
            if(dict1[key] != dict2[key])
            {
                return false;
            }
        }
        return true;
    }
}