using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class CanPermutePalindrome266
    {
        public static bool CanPermutePalindrome(string s)
        {
            int n = s.Length;
            HashSet<char> map = new HashSet<char>();
            foreach (char c in s)
            {
                if (map.Contains(c))
                    map.Remove(c);
                else
                    map.Add(c);
            }
            if (n % 2 == 0)
                return (map.Count == 0);
            else
                return (map.Count == 1);
        }
    }
}
