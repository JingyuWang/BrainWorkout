using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    //646. Maximum Length of Pair Chain
    public class FindLongestChain646
    {
        public static int FindLongestChain(int[][] pairs)
        {
            int res = 1;
            Array.Sort(pairs, new Sort2DArray());
            int head = pairs[0][0];
            int tail = pairs[0][1];
            for(int i = 0; i < pairs.Length; i++)
            {
                if (pairs[i][0] > tail)
                {
                    tail = pairs[i][1];
                    res++;
                }
            }

            return res;
        }
    }
    public class Sort2DArray: IComparer
    {
        int IComparer.Compare(object x, object y)
        {
            int[] x1 = (int[])x;
            int[] y1 = (int[])y;
            if (x1[1] > y1[1])
                return 1;
            if (x1[1] < y1[1])
                return -1;
            else
                return 0;
        }
    }
}

/*
You are given n pairs of numbers. In every pair, the first number is always smaller than the second number.

Now, we define a pair (c, d) can follow another pair (a, b) if and only if b < c. Chain of pairs can be formed in this fashion.

Given a set of pairs, find the length longest chain which can be formed. You needn't use up all the given pairs. You can select pairs in any order.

Example 1:
Input: [[1,2], [2,3], [3,4]]
Output: 2
Explanation: The longest chain is [1,2] -> [3,4]
Note:
The number of given pairs will be in the range [1, 1000]. 

*/

