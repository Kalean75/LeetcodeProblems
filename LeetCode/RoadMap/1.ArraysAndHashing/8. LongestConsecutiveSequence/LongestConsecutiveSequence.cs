public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        Dictionary<int,int> resultDict = new Dictionary<int,int>();
        //fill dictionary
        for(int i = 0; i < nums.Length;i++)
        {
            if(resultDict.ContainsKey(nums[i]))
            {
                resultDict[nums[i]] += 1;
            }
            else
            {
                resultDict[nums[i]] = 1;
            }
        }
        resultDict = resultDict.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);
        //Find subsequence
        int maxLength = 0;
        int length = 1;
        int currValue = int.MinValue;
        bool first = true;
        foreach(KeyValuePair<int,int> entry in resultDict)
        {
            if(first)
            {
                currValue = entry.Key;
                first = false;
            }
            if(entry.Key == currValue +1)
            {
                length += 1;
            }
            else
            {
                length = 1;
            }
            
            if(length > maxLength)
            {
                maxLength = length;
            }
            
            currValue = entry.Key;
        }
        return maxLength;
    }
}
