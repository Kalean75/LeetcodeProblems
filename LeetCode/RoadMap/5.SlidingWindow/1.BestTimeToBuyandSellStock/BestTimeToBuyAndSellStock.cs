public class Solution {
    public int MaxProfit(int[] prices) 
    {
        //brute force = nested for loop
        int price = prices[0];
        int maxProfit = 0;
        for(int i = 1; i < prices.Length;i++)
        {
            if(price > prices[i])
            {
                price = prices[i];
            }
            else if(price < prices[i])
            {
                maxProfit = Math.Max(maxProfit,prices[i] - price);
            }
        }
        return maxProfit;
    }
}
