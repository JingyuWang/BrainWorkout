using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class ValidPerfectSquare367
    {
        public static bool IsPerfectSquare(int num)//808201
        {
            
            long a = num / 2;
            int upper = (int)a;
            while ( (a*a) > num)
            {
                upper = (int)a;
                Console.WriteLine("a is " + a + "    in the loop");
                a = a / 2;
                Console.WriteLine("a is " + a + "    in the loop");
                Console.WriteLine(" int the loop---" + ((a * a) > num) + "---int the loop");
            }



            Console.WriteLine("upper is " + upper + "");

            Console.WriteLine("lower is " + upper/2 + "");

            for (int i = upper/2; i <= upper; i++)
            {
                if (i * i == num)
                    return true;
            }
            return false;
        }
    }
}
