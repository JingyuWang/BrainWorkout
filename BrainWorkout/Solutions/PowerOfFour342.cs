using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class PowerOfFour342
    {
        public static bool IsPowerOfFour(int num)
        {
            if (num <= 0)
                return false;
            string str = Convert.ToString(num, 2);
            if ((str.Length - 1) % 2 != 0)
                return false;
            for(int i = 0; i < str.Length; i++)
            {
                if (i == 0)
                {
                    if (str[0] != '1')
                        return false;
                }
                else
                {
                    if (str[i] != '0')
                        return false;
                }
            }
            return true;
        }
    }
}
