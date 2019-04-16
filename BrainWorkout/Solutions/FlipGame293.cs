using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class FlipGame293
    {
        public IList<string> GeneratePossibleNextMoves(string s)
        {
            List<string> result = new List<string>();

            char[] cs = s.ToArray();
            for(int i = 0; i < s.Length-1; i++)
            {
                if( cs[i] == '+' && cs[i+1] == '+')
                {
                    cs[i] = '-';
                    cs[i + 1] = '-';
                    result.Add(new string(cs));
                    cs[i] = '+';
                    cs[i + 1] = '+';
                }
            }
            return result;
        }
    }
}
