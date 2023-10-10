public class Solution 
{
    public int[] SearchRange(int[] nums, int target) 
    {
        int[] answer = new int[2];
        answer[0] = -1;
        answer[1] = -1;
        bool foundLast = false;
        bool foundFirst = false;
        if(nums.Length < 1)
        {
            return answer;
        }
        if(nums.Length == 1 && nums[0] == target)
        {
            answer[0] = 0;
            answer[1] = 0;
            return answer;
        }
        for(int i = 0; i < nums.Length;i++)
        {
            if(nums[i] == target && !foundFirst)
            {
                foundFirst = true;
                answer[0] = i;
            }
            else if(nums[i] == target)
            {
                answer[1] = i;
            }
        }
        if(answer[1] == -1 && answer[0] !=-1)
        {
            answer[1] = answer[0];
        }
        return answer;

    }
}