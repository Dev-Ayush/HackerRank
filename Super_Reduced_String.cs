//https://www.hackerrank.com/challenges/reduced-string

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Reduced_String
{
    
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            for (int i = 0; i < (s.Length) - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    s = s.Remove(i, 2);
                    i = -1;
                }
            }
            if (s == "")
            {
                Console.WriteLine("Empty String");
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
}
