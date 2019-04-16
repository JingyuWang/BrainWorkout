using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
n是有几个标杆，k是有几种颜色

1. n == 0，当没有标杆的时候，就没有任何粉刷的可能。

2. n == 1，当只有一根标杆的时候，那就是有几种颜料就又几种粉刷的可能性。

3. 当n = 2的时候。因为题目条件是最多两个相邻的标杆能够颜色相同，可能性就只有两种，
    
    一种是两根标杆的颜色 不同。      unsame2 = K * (k-1)
    一种是两根标杆的颜色 相同，        same2 = K

    所以和为 total2 = K + K * (k-1)

4. 当n = 3的时候，同上， 但相当于2根的基础上加一根

    第三根与第二根颜色不同。          unsame3 = total2 * (K-1)
    第三根与第二根颜色相同，          same3 = unsame2            (注意有2根相邻限制)
    
    所以和为 total3 = total2 + total2 * (K-1)

*/
namespace BrainWorkout.Solutions
{
    class PaintFence276
    {
        public int NumWays(int n, int k)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return k;
            else
            {
                int same = k;
                int unsame = k * (k-1);
                for (int i=3; i<=n; i++)
                {
                    int preUnsame = unsame;
                    unsame = (same + unsame) * (k - 1);
                    same = preUnsame;
                    
                }

                int total = same + unsame;
                return total;
            }
        }
    }
}
