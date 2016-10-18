//https://www.hackerrank.com/contests/w22/challenges/cookie-party

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cookie_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);

            int rem = m % n;
            if(rem>0)
            {
                int diff = n - rem;
                Console.WriteLine(diff);
            }
            else
            {
                Console.WriteLine(0);
            }
            Console.ReadLine();
        }
    }
}
