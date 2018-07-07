// https://www.hackerrank.com/challenges/the-birthday-bar

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChoclate
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);

            int[] gift = new int[m];
            int x = 0;

            for (int a = 0; a < n - m + 1; a++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (i <= n)
                    {
                        gift[i] = s[i + a];
                        if (i == m - 1)
                        {
                            if (gift.Sum() == d) x += 1;
                        }
                    }
                }
            }

            Console.WriteLine(x);
        }
    }
}
