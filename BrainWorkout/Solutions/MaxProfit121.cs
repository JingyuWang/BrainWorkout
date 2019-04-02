using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class MaxProfit121
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices.Length <= 0)
                return 0;
            int result = 0;
            int checkpoint = prices[0];
            for(int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < checkpoint)
                {
                    checkpoint = prices[i];
                }
                else
                    result = Math.Max(result, prices[i] - checkpoint);
            }
            return result;
        }
    }
}
