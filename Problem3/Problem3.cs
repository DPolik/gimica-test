using System;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        // Assert we are inside the constraints
        if(prices == null || prices.Length < 2 || prices.Length > 105) return 0;

        var maxProfit = 0;
        var minPrice = prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            if(prices[i] < 0 || prices[i] > 104) return 0; // assert the remaining constraint

            var newProfit = Math.Max(maxProfit, prices[i] - minPrice);
            if(newProfit > maxProfit) maxProfit = newProfit; // update max profit if needed
            
            if (prices[i] < minPrice) // update min price found if needed
            {
                minPrice = prices[i];
            }
        }
        
        return maxProfit;
    }
}
