using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class WordPattern290
    {
        public static bool WordPattern(string pattern, string str)
        {

            Dictionary<char, string> map = new Dictionary<char, string>();
            HashSet<string> strset = new HashSet<string>();

            string[] ss = str.Split(' ');
            if (ss.Length != pattern.Length)
                return false;
            for(int i = 0; i < pattern.Length; i++)
            {
                char key = pattern[i];
                string value = ss[i];
                if (map.ContainsKey(key))
                {
                    if (map[key] != value)
                        return false;
                }
                else
                {
                    if (strset.Contains(value))
                        return false;
                    strset.Add(value);
                    map[key] = value;
                }
                
            }
            return true;
        }
    }
}
