public class Solution {
    public int BuyChoco(int[] prices, int money) 
    {
        if(prices.Length < 2)
        {
            return money;
        }
        Array.Sort(prices);
        int newMoney = money;
        for(int i = 0; i < 2;i++)
        {
            newMoney -= prices[i];
        }
        if(newMoney < 0)
        {
            return money;
        }
        return newMoney;
    }
}