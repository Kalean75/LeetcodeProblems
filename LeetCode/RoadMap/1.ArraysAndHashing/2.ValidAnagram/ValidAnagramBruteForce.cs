public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length != t.Length)
        {
            return false;
        }
        s = new string(s.OrderBy(c => c).ToArray());
        t = new string(t.OrderBy(c => c).ToArray());

        if(s.Equals(t))
        {
            return true;
        }
        return false;
    }
}