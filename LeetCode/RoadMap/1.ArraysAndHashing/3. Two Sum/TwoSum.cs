public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        int[] answer = new int[2];
        Dictionary<int,int> hash = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int x = target - nums[i];
            if(hash.ContainsKey(x))
            {
                answer[0] = hash[x];
                answer[1] = i;
                return answer;
            }
            hash[nums[i]] = i;
        }
        return null;
    }
}