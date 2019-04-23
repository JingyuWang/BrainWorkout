using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class ValidWordAbbreviation408
    {
        /*
         Test case can be 
         "word"/"w0ord"
         "ac"/"ab01c",
         so need to elimiate 0
             */
        public static bool ValidWordAbbreviation(string word, string abbr)
        {
            string tempNum = "";

            int j = 0;

            for (int i = 0; i < abbr.Length; i++)
            {
                if (abbr[i] >= 48 && abbr[i] <= 57)
                    tempNum += abbr[i];
                else
                {
                    if (!string.IsNullOrEmpty(tempNum))
                    {
                        if (Int32.Parse(tempNum).ToString() != tempNum || tempNum == "0")
                            return false;
                        j += Int32.Parse(tempNum);
                    }
                    tempNum = "";
                    if (j >= word.Length || abbr[i] != word[j])
                        return false;
                    else
                    {
                        j++;
                    }
                }
            }
            if (!string.IsNullOrEmpty(tempNum))
            {
                if (Int32.Parse(tempNum).ToString() != tempNum || tempNum == "0")
                    return false;
                j += Int32.Parse(tempNum);
                if (j != word.Length)
                {
                    Console.WriteLine("final J   " + j);
                    return false;
                }

                Console.WriteLine("final J   " + j);
            }

            return true;
        }
        //inter natio naliz ation
    }
    //i5a11o1
}
