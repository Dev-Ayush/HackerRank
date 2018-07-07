//https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Days_At_The_Movies
{
    class Program
    {

        static int beautifulDays(int i, int j, int k)
        {
            int counter = 0;
                IEnumerable<int> range = Enumerable.Range(i, j - i);
            
                foreach (int n in range)
                {
                    int savedData = n;
                    int initialData = n;
                    int reverse = 0;
                    while (initialData > 0)
                    {
                        int remainder = initialData % 10;
                        reverse = (reverse * 10) + remainder;
                        initialData = initialData / 10;
                    }
                    if (Math.Abs(savedData - reverse) % k == 0)
                    {
                        counter++;
                    }
                }
                return counter;
        }

        static void Main(string[] args)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            int k = Convert.ToInt32(tokens_i[2]);
            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);
        }
    }
}
