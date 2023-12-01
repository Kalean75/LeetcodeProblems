public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) 
    {
      string first = String.Join("",word1);
      string second = String.Join("", word2);

      if(first == second)
      {
        return true;
      }
      return false;
    }
}