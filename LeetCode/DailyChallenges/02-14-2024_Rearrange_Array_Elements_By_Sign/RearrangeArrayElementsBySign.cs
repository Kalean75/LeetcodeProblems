public class Solution {
    public int[] RearrangeArray(int[] nums) 
    {
        List<int> negativeNums = new List<int>();
        List<int> positiveNums = new List<int>();
        List<int> answer = new List<int>();
        for(int i = 0; i < nums.Length;i++)
        {
            if(nums[i] > 0)
            {
                positiveNums.Add(nums[i]);
            }
            else
            {
                negativeNums.Add(nums[i]);
            }
        }
        for(int j = 0; j < nums.Length / 2;j++)
        {
            answer.Add(positiveNums[j]);
            answer.Add(negativeNums[j]);
        }
        return answer.ToArray();
    }
}