using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using solu = BrainWorkout.Solutions;
using Node = BrainWorkout.Solutions.N_aryTreeBFS.Node;
namespace BrainWorkout
{
    class Program
    {
        public static void Main(string[] args)
        {
            Node node5 = new Node(5,null);
            Node node6 = new Node(6,null);

            Node node25 = new Node(25, null);
            Node node26 = new Node(26, null);

            //Node node3 = new Node(3, new List<Node>() { node5, node6 });
            Node node3 = new Node(3, null);
            Node node2 = new Node(2, new List<Node>() { node25, node26 });
            Node node4 = new Node(4, null);

            Node root = new Node(1, new List<Node>() { node3, node2, node4 });

            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(root);
            while (Q.Count > 0)
            {
                int size = Q.Count;
                Node n = Q.Dequeue();
                if (n.children != null)
                {
                    foreach (Node nn in n.children)
                    {
                        Q.Enqueue(nn);
                        Console.WriteLine("CHILDREN is " + nn.val);
                    }
                }
                
                Console.WriteLine(n.val);
            }


        }
    }
}



