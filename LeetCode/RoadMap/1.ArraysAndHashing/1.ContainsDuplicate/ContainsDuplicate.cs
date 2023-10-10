public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        HashSet<int> answerDict = new HashSet<int>();

        for(int i = 0; i < nums.Length;i++)
        {
            if(answerDict.Contains(nums[i]))
            {
                return true;
            }
            else
            {
                answerDict.Add(nums[i]);
            }
        }
        return false;
    }