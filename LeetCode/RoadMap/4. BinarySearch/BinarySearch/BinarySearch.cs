public class Solution {
    public int Search(int[] nums, int target) 
    {
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;

        while(leftPointer <= rightPointer)
        {
            int midPointer = leftPointer + ((rightPointer - leftPointer) / 2);
            if(nums[midPointer] > target)
            {
                rightPointer = midPointer - 1;
            }
            else if(nums[midPointer] < target)
            {
                leftPointer = midPointer + 1;
            }
            else
            {
                return midPointer;
            }
        }
        return -1;
    }
}
