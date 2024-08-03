public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        int[] answer = new int[nums.Length];
        int preProduct = 1;
        int postProduct = 1;
        for(int i = 0; i < nums.Length;i++)
        {
            answer[i] = preProduct;
            preProduct *= nums[i];
        }
        for(int i = nums.Length -1; i >= 0;i--)
        {
            answer[i] *= postProduct;
            postProduct *= nums[i];
        }
        return answer;
    }
}
