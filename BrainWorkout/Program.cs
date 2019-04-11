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
            int[] input = { 0, 1, 2, 3, 4, 8, 9, 11 };
            BrainWorkout.Solutions.TwoSum t = new BrainWorkout.Solutions.TwoSum();
            t.Add(3);
            Console.WriteLine(t.getTwoSum()[3]);
            t.Add(1);
            Console.WriteLine(t.getTwoSum()[1]);
            t.Add(2);
            Console.WriteLine(t.getTwoSum()[2]);
            t.Add(3);
            Console.WriteLine(t.getTwoSum()[3]);


            Console.WriteLine(t.Find(6));




            //Dictionary<int, int> twosum = new Dictionary<int, int>();
            //twosum.Add(1, 2);
            //twosum[1]++;
            //Console.WriteLine(twosum[1]);

        }
    }
}
