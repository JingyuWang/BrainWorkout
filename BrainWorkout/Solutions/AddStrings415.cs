using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainWorkout.Solutions
{
    class AddStrings415
    {
        public static string AddStrings(string a, string b)
        {
            var stringBuilder = new StringBuilder();
            int left = a.Length - 1;
            int right = b.Length - 1;
            int carry = 0;
            int remain = 0;
            Stack<int> store = new Stack<int>();
            while (left >= 0 && right >= 0)
            {
                int temp = a[left] + b[right] - 96 + carry;
                //Console.WriteLine("ac is " + a[left]);
                //Console.WriteLine("bc is " + b[right]);
                if (temp >= 10)
                {
                    carry = 1;
                    store.Push(temp - 10);
                }
                else
                {
                    carry = 0;
                    store.Push(temp);
                }
                left --;
                right --;
                //Console.WriteLine("---------------------------------------");
            }
            while (left >= 0 )
            {
                int temp = a[left] - 48 + carry;
                //Console.WriteLine("ac is " + a[left]);
                if (temp >= 10)
                {
                    carry = 1;
                    store.Push(temp - 10);
                }
                else
                {
                    carry = 0;
                    store.Push(temp);
                }

                left--;
                //Console.WriteLine("---------------------------------------");
            }
            while (right >= 0)
            {
                int temp = b[right] - 48 + carry;
                //Console.WriteLine("bc is " + b[right]);
                if (temp >= 10)
                {
                    carry = 1;
                    store.Push(temp - 10);
                }
                else
                {
                    carry = 0;
                    store.Push(temp);
                }
                right--;
                //Console.WriteLine("---------------------------------------");
            }
            if (carry == 1)
            {
                store.Push(1);
            }
            while (store.Count > 0)
            {
                stringBuilder.Append(store.Pop());
            }
            return stringBuilder.ToString();
        }
    }
}
