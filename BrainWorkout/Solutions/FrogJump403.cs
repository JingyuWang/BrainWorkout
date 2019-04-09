using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class FrogJump403
    {
        public static bool CanCanCross(int[] stones)
        {
            int n = stones.Length; 
            Dictionary<int, HashSet<int>> result = new Dictionary<int, HashSet<int>>();
            result.Add(0, new HashSet<int>() { 1});
            for(int i = 1; i < n; i++)
            {
                result.Add(i, new HashSet<int>());
                for (int j = 0; j < i; j++)
                {
                    int gap = stones[i] - stones[j];
                    if (gap < 0 || gap > n || !result[j].Contains(gap)) continue;

                        result[i].Add(gap);
                        result[i].Add(gap-1);
                        result[i].Add(gap+1);
                    if (i == n - 1)
                        return true;
                }
            }
            return false;
        }
    }
}
