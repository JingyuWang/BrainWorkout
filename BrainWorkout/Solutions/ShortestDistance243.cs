using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class ShortestDistance243
    {
        public int ShortestDistance(string[] words, string word1, string word2)
        {
            HashSet<string> sub = new HashSet<string>();
            Dictionary<string, HashSet<int>> map = new Dictionary<string, HashSet<int>>();
            for(int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                if (map.ContainsKey(temp))
                {
                    map[temp].Add(i);
                } else
                    map[temp] = new HashSet<int>() { i };
                
            }
            return 0;
        }
    }
}
