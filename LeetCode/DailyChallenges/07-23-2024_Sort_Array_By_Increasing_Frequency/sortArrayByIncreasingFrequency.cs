public class Solution {
    public int[] FrequencySort(int[] nums) 
    {
        Dictionary<int,int> sortArray = new Dictionary<int,int>();
        for(int i = 0; i < nums.Length;i++)
        {
            if(sortArray.ContainsKey(nums[i]))
            {
                sortArray[nums[i]] +=1;
            }
            else
            {
                sortArray[nums[i]] =1;
            }
        }
        var sortedDict = from entry in sortArray orderby entry.Key descending orderby entry.Value ascending  select entry;
        List<int> answer = new List<int>();
        foreach(KeyValuePair<int, int> entry in sortedDict)
        {
            for(int i = 0; i < entry.Value;i++)
            {
                answer.Add(entry.Key);
            }
            // do something with entry.Value or entry.Key
        }
        int[] finalAnswer = answer.ToArray();
        return finalAnswer;
    }
}