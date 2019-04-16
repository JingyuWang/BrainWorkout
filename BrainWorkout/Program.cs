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
            string pattern = "abba", str = "dog cat cat dog";
            //Console.WriteLine(BrainWorkout.Solutions.FirstBadVersion278.IsBadVersion(2));
            bool a = BrainWorkout.Solutions.WordPattern290.WordPattern(pattern, str);
            Console.WriteLine(a);
            
        }

    }
}




