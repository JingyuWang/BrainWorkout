using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class ReverseVowelsofaString345
    {
        public static string ReverseVowels(string s)
        {
            int l = 0;
            int r = s.Length-1;
            char[] result = s.ToArray();
            while (l <= r)
            {
                if (CheckVowel(result[l]) && CheckVowel(result[r]))
                {
                    char temp = result[l];
                    result[l] = result[r];
                    result[r] = temp;
                    l++;
                    r--;
                }
                else
                {
                    if (!CheckVowel(result[l]))
                    {
                        l++;
                    }
                    if (!CheckVowel(result[r]))
                    {
                        r--;
                    }
                }
                
            }
            return new string(result);
        }
        public static bool CheckVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'|| c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                return true;
            else
                return false;
        }
    }
}
