//https://www.hackerrank.com/challenges/30-2d-arrays

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_2D_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[][] arr = new int[6][];
            //for (int arr_i = 0; arr_i < 6; arr_i++)
            //{
            //  string[] arr_temp = Console.ReadLine().Split(' ');
            //arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            //}

            int[][] arr = new int[6][];
            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);
            }
            int[] sum = new int[6];
            List<int> n = new List<int>();
            for (int i = 0; i + 2 < arr.Length; i++)
            {


                for (int j = 0; j + 2 < arr.GetLength(0); j++)
                {

                    sum[j] = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +
                                     arr[i + 1][j + 1] +
                        arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    n.Add(sum[j]);

                }

            }

            Console.WriteLine(n.Max());
        }
    }
}
