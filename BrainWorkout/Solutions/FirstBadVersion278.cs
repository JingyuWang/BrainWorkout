using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class FirstBadVersion278
    {
        public static int FirstBadVersion(int n)
        {
            int left = 1;
            int right = n;
            while( left != right -1)
            {
                int mid = (right - left) / 2 + left;
                if (IsBadVersion(mid))
                {
                    right = mid;
                }
                else
                {
                    left = mid;
                }

                Console.Write("L = " + left);
                Console.Write("  M = " + mid);
                Console.WriteLine("  R = " + right);
            }

            return right;
        }


        //The isBadVersion API is defined in the parent class VersionControl.
        public static bool IsBadVersion(int version)
        {
            if (version >= 1702766719)
                return true;
            else
                return false;
        }
    }
}
