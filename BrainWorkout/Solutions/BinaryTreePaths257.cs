using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class BinaryTreePaths257
    {
        public static IList<string> BinaryTreePaths(TreeNode root)
        {
            List<string> result = new List<string>();
            if (root.left == null)
                return result;
            if(root.left==null && root.right == null)
                result.Add(root.val.ToString());
            else
            {
                foreach(string s in BinaryTreePaths(root.left))
                {
                    result.Add(root.val.ToString() + "->" + s);
                }
                foreach (string s in BinaryTreePaths(root.right))
                {
                    result.Add(root.val.ToString() + "->" + s);
                }
            }
            return result;
        }
        //Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
