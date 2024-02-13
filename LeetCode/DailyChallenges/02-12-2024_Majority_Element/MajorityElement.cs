public class Solution {
    public int MajorityElement(int[] nums) 
    {
        Dictionary<int,int> answer = new Dictionary<int,int>();
        int n = nums.Length;
        for(int i = 0; i < n; i++)
        {
            if(answer.ContainsKey(nums[i]))
            {
                answer[nums[i]] += 1;
                if(answer[nums[i]] > n/2)
                {
                    return nums[i];
                }        
            }
            else
            {
                answer[nums[i]] = 1;
                if(answer[nums[i]] > n/2)
                {
                    return nums[i];
                }   
            }
        }
        return 1;
    }
}