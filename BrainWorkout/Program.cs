using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[][] a = new int[2][];
            a[0] = new int[] { 17, 2, 17 };
            a[1] = new int[] { 16, 5, 16 };

            Console.WriteLine(BrainWorkout.Solutions.Paint_House256.MinCost(a));
        }

        public IList<string> BinaryTreePaths(TreeNode root)
        {

        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}




