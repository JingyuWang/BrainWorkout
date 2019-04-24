using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class N_aryTreeBFS
    {
        public static IList<IList<int>> LevelOrder(Node root)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (root == null)
                return result;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                List<int> curLevel = new List<int>();
                int size = q.Count();
                for(int i = 0; i < size; i++)
                {
                    Node tempNode = q.Dequeue();
                    curLevel.Add(tempNode.val);
                    foreach(Node n in tempNode.children)
                    {
                        q.Enqueue(n);
                    }
                }
                result.Add(curLevel);
            }
            return result;
        }
        public class Node
        {
            public int val { get; set; }
            public IList<Node> children { get; set; }
            public Node()
            {
                val = 0;
                children = null;
            }
            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }
    }
}
