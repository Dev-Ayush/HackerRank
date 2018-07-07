//https://www.hackerrank.com/challenges/save-the-prisoner/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrisnor
{
    class Program
    {

        static int saveThePrisoner(int n, int m, int s)
        {
            int a = s + m - 1;
            if (a > n)
            {
                if (a % n == 0)
                {
                    return n;
                }
                return a % n;
            }

            return a;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int m = Convert.ToInt32(tokens_n[1]);
                int s = Convert.ToInt32(tokens_n[2]);
                int result = saveThePrisoner(n, m, s);
                Console.WriteLine(result);
            }
        }
    }
}