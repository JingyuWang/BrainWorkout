using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    //170. Two Sum III - Data structure design
    class TwoSum
    {
        Dictionary<int,int> twosum;
        /** Initialize your data structure here. */
        public TwoSum()
        {
            twosum = new Dictionary<int, int>();

        }
        public Dictionary<int,int> getTwoSum()
        {
            return twosum;
        }

        /** Add the number to an internal data structure.. */
        public void Add(int number)
        {
            if (!twosum.ContainsKey(number))
                twosum.Add(number, 1);
            else
                twosum[number]++;
        }

        /** Find if there exists any pair of numbers which sum is equal to the value. */
        public bool Find(int value)
        {
            foreach(int key in twosum.Keys)
            {
                int temp = key;
                if (value -key != key)
                {
                    if (twosum.ContainsKey(value - key))
                        return true;
                }
                else
                {
                    if (twosum[key] >= 2)
                        return true;
                }
            }
            return false;
        }
    }
}
