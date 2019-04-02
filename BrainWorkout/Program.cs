using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = new int[3][];
            input[0] = new int[] { 1, 1};
            input[1] = new int[] { 4, 4};
            input[2] = new int[] { 2, 3};
            Console.WriteLine(Solutions.Solution.FindLongestChain(input));
        }
    }
}
