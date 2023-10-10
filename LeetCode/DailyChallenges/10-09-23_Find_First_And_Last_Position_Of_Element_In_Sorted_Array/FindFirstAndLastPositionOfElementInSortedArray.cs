public class Solution 
{
    public int[] SearchRange(int[] nums, int target) 
    {
        int left = FirstOccurrence(nums,target);
        int right = LastOccurrence(nums,target);

        return new int[]{left,right};
    }

    private int FirstOccurrence(int[] nums, int target)
    {
        // set left to index 0 of nums
        int left = 0;
        //set right to length of nums
        int right = nums.Length-1;

        //first occurrence is default return specified
        int firstOccurrence = -1;

        while(left <= right)
        {
            int mid = left + (right /2);
            //if middle is greater than or equal to target, move right end towards 0 index
            if(nums[mid] >= target)
            {
                if(nums[mid] == target)
                {
                    firstOccurrence = mid;
                }
                right = mid-1;
            }
            //otherwise move left towards end of array.
            else
            {
                left = mid+1;
            }
        }
        return firstOccurrence;
    }

    private int LastOccurrence(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length-1;
        int LastOccurrence = -1;

        while(left <= right)
        {
            int mid = left + (right /2);
            //if middle is greater than or equal to target, move left end towards length of index
            if(nums[mid] <= target)
            {
                if(nums[mid] == target)
                {
                    LastOccurrence = mid;
                }
                left = mid+1;
            }
            //otherwise move right towards 0 index;
            else
            {
                right = mid-1;
            }
        }
        return LastOccurrence;
    }
}