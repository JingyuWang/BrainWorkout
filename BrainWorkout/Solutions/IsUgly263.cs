using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class IsUgly263
    {
        public bool IsUgly(int a)
        {
            if (a == 0)
                return false;
            else if (a == 1)
                return true;
            if (a % 2 == 0)
            {
                return IsUgly( a / 2);
            }
            else if (a % 3 == 0)
            {
                return IsUgly(a / 3);
            }
            else if (a % 5 == 0)
            {
                return IsUgly(a / 5);
            }
            return false;
        }
    }
}
