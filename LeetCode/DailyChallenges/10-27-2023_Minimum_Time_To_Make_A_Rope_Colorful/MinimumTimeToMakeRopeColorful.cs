public class Solution {
    public int MinCost(string colors, int[] neededTime) 
    {
        List<int>neededTimeList = new List<int>(neededTime);
        int time = 0;
        for(int i = 0; i < colors.Length -1;i++)
        {
            if(colors[i] == colors[i+1])
            {
                if(neededTimeList[i + 1] <= neededTimeList[i])
                {
                    time += neededTimeList[i+1];
                    neededTimeList[i+1] = neededTimeList[i];
                }
                else
                {
                    time += neededTimeList[i];
                }
            }
        }
        return time;
    }
}
