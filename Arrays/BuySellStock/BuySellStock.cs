using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Arrays.BuySellStock
{
    class BuySellStock
    {
        public static int maxProfit(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                    minprice = prices[i];
                else if (prices[i] - minprice > maxprofit)
                    maxprofit = prices[i] - minprice;
            }
            return maxprofit;
        }

    }
}
