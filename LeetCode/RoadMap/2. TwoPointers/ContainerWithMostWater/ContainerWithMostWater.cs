public class Solution {
    public int MaxArea(int[] heights) 
    {
        int leftPointer = 0;
        int rightPointer = heights.Length - 1;
        // count amount between pointers
        // multiply by lower number
        int totalWater = 0;
        while(leftPointer < rightPointer)
        {
            int currentWater = 0;
            if(heights[rightPointer] > heights[leftPointer])
            {
                currentWater = (rightPointer - leftPointer) * heights[leftPointer] ;
                leftPointer++;
            }
            else if (heights[rightPointer] < heights[leftPointer])
            {
                currentWater = (rightPointer - leftPointer) * heights[rightPointer] ;
                rightPointer--;
            }
            else
            {
                 currentWater = (rightPointer - leftPointer) * heights[rightPointer] ;
                 rightPointer--;
                 leftPointer++;
            }

            if(currentWater > totalWater)
            {
                totalWater = currentWater;
            }
        }

        return totalWater;
    }
}
