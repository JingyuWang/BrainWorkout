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
            int result = 0;
            int checkpoint = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < checkpoint)
                {
                    checkpoint = prices[i];
                }
                else if (result < prices[i] - checkpoint)
                {
                    result = prices[i] - checkpoint;
                }
            }
            return result;
        }
    }
}
