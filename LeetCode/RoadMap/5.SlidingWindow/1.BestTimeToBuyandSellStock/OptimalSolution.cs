public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int maxProfit = 0;
        int leftPointer = 0;
        int rightPointer = 1;
        while(rightPointer < prices.Length)
        {
            if( prices[leftPointer] < prices[rightPointer])
            {
                int currPrice = prices[rightPointer] - prices[leftPointer];
                maxProfit = Math.Max(maxProfit, currPrice);
            }
            else
            {
                leftPointer = rightPointer;
            }
            rightPointer++;

        }
        return maxProfit;
    }
}
