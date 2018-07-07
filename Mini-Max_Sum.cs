//https://www.hackerrank.com/challenges/mini-max-sum/problem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Max_Sum
{
    class Program
    {

        static void miniMaxSum(int[] arr)
        {
            long sum = 0;
            List<long> addition = new List<long>();
            foreach (int a in arr)
            {
                sum += a;
            }
            for (int j = 0; j < arr.Length; j++)
            {
                addition.Add(sum-arr[j]);
            }
            Console.WriteLine(addition.Min() +" "+addition.Max());
        }

        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
