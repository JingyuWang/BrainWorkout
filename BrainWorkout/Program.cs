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
            //int[] input = { 0, 1, 2, 3, 4, 8, 9, 11 };
            int[] input = {0,1,3,5,6,8,12, 17 };
            Console.WriteLine(Solutions.FrogJump403.CanCanCross(input));
        }
    }
}
