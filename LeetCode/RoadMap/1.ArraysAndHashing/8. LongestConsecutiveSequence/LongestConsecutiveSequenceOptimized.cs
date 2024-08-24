public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        Dictionary<int,int> answer = new Dictionary<int,int>();
        //populate dictionary
        for(int i = 0; i < nums.Length;i++)
        {
            int key = nums[i];
            if(answer.ContainsKey(key))
            {
                answer[key] += 1;
            }
            else
            {
                answer[key] = 1;
            }
        }
        int length = 0;
        foreach(KeyValuePair<int, int> entry in answer)
{
            if(!answer.ContainsKey(entry.Key - 1))
            {
                int currLength = 1;
                while(answer.ContainsKey(entry.Key + currLength))
                {
                    currLength +=1;
                }
                if(currLength >= length)
                {
                    length = currLength;
                }
            }
        }
        return length;
    }
}
