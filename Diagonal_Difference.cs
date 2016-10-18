//https://www.hackerrank.com/challenges/diagonal-difference

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            int first_diagonal_sum = 0;
            int second_diagonal_sum = 0;

            int j = 0;
            int k = a.Length - 1; ;
            for (int i = 0; i < n; i++)
            {
                first_diagonal_sum = first_diagonal_sum + a[i][j];
                second_diagonal_sum = second_diagonal_sum + a[i][k];
                j++;
                k--;
            }

            int difference = Math.Abs(first_diagonal_sum-second_diagonal_sum);
            Console.WriteLine(difference);

            Console.ReadLine();
        }
    }
}
