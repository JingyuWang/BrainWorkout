using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class Paint_House256
    {
        public static int MinCost(int[][] costs)
        {
            int n = costs.Length;
            int[][] dp = new int[n][];

            dp[0] = new int[] { costs[0][0], costs[0][1], costs[0][2]};

            for (int i = 1; i < n; i++)
            {
                int a = costs[i][0] + Math.Min(dp[i - 1][1], dp[i - 1][2]);
                int b = costs[i][1] + Math.Min(dp[i - 1][0], dp[i - 1][2]);
                int c = costs[i][2] + Math.Min(dp[i - 1][0], dp[i - 1][1]);

                dp[i] = new int[] { a, b, c };
                Console.Write(a);
                Console.Write("--");
                Console.Write(b);
                Console.Write("--");
                Console.Write(c);
                Console.WriteLine();
            }
            //Console.WriteLine(dp[n-1][0]);
            //Console.WriteLine(dp[n-1][1]);
            //Console.WriteLine(dp[n-1][2]);


            return Math.Min(Math.Min(dp[n-1][0], dp[n-1][1]), dp[n-1][2]);
        }
    }
}
