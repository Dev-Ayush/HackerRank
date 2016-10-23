//https://www.hackerrank.com/challenges/linkedin-practice-binary-numbers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecutive_1s_In_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);

            string[] s = binary.Split('0');
            int length = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > length)
                {
                    length = s[i].Length;
                }
            }
            Console.WriteLine(length);
        }
    }
}
