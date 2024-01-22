public class Solution {
    public int[] FindErrorNums(int[] nums) 
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int length = nums.Length;
        int expectedSum = (length*(length + 1))/(2);
        int actualSum = nums.Sum();
        int duplicatedNumber = 0;
        for(int i = 0; i < length;i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                duplicatedNumber = nums[i];
                break;
            }
            else
            {
                dict[nums[i]] = 1;
            }
        }
        int actualNumber = expectedSum - (actualSum - duplicatedNumber);
        return [duplicatedNumber,actualNumber];
    }
}