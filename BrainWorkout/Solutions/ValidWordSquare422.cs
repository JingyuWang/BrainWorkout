using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class ValidWordSquare422
    {
        //Method 1
        public static bool ValidWordSquare(IList<string> words)
        {
            for(int i = 0; i < words.Count; i++)
            {
                string temp = "";
                foreach(string s in words)
                {
                    if (i < s.Length)
                        temp += s[i];
                }
                if(temp!=words[i])
                    return false;
            }
            return true;
        }
        //Method 2
        public static bool ValidWordSquare2(IList<string> words)
        {
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j >= words.Count || i >= words[j].Length || words[i][j] != words[j][i])
                        return false;
                }
            }
            return true;
        }
    }
}
