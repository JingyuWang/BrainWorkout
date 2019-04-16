using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

Given a non-empty binary search tree and a target value, find the value in the BST that is closest to the target.

Note:

Given target value is a floating point.
You are guaranteed to have only one unique value in the BST that is closest to the target.
Example:

Input: root = [4,2,5,1,3], target = 3.714286

    4
   / \
  2   5
 / \
1   3

Output: 4
 
     
*/
namespace BrainWorkout.Solutions
{
    class ClosestValue270
    {
        public int ClosestValue(TreeNode root, double target)
        {
            int result = root.val;
            while (root != null)
            {
                if (Math.Abs(target - root.val) < Math.Abs(target - result))
                    result = root.val;
                if (target > root.val)
                {
                    root = root.right;
                }
                else
                {
                    root = root.left;
                }
            }
            return result;
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
