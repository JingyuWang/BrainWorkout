using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class MovingAveragefromDataStream346
    {
        public class MovingAverage
        {
            int size = 0;
            int[] set;
            int index = 0;//previous index before "Next()"
            double incrementIndex = 1.0;
            int sum = 0;
            public MovingAverage(int size)
            {
                this.size = size;
                set = new int[size];
            }

            public double Next(int val)
            {
                double result;
                int pre = set[index];
                if (incrementIndex < size)//no need decrease if not reach the cap
                {
                    sum += val;
                    result = sum / incrementIndex;
                    incrementIndex++;
                }
                else
                {
                    sum = sum - pre + val;
                    result = sum / incrementIndex;
                }
                set[index] = val;
                index = (index + 1) % size;
                return result;
            }
        }
    }
}
