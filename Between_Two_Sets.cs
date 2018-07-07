//https://www.hackerrank.com/challenges/between-two-sets

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Between_Two_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int m = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);

            int a_max = a[0], b_min = b[0];

            for (int i = 1; i < n; i++)
            {
                if (a_max < a[i])
                    a_max = a[i];
            } // find a_max

            for (int i = 1; i < m; i++)
            {
                if (b_min > b[i])
                    b_min = b[i];
            } // find b_min

            bool flag;
            int counter = 0;
            for (int i = a_max; i <= b_min; i++)
            {
                flag = true;
                for (int j = 0; j < n; j++)
                {

                    if (i % a[j] != 0)
                    {
                        flag = false;
                        break;
                    }
                } // find lcm

                if (flag == true)
                {
                    for (int k = 0; k < m; k++)
                    {

                        if (b[k] % i != 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                } // find gcd
                if (flag == true)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
