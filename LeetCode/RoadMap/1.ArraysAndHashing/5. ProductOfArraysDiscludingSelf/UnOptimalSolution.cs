public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] answer = new int[nums.Length];
        for(int i = 0; i < nums.Length;i++)
        {
            int product = 1;
            for(int j = 0; j < nums.Length;j++)
            {
                if(j == i)
                {
                    continue;
                }
                else
                {
                    product *= nums[j];
                }
            }
            answer[i] = product;
        }
        return answer;
    }
}