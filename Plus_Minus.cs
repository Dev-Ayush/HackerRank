//https://www.hackerrank.com/challenges/plus-minus

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            double positiveCounter = 0.0, negativeCounter = 0.0, zeroCounter = 0.0;
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];

                if (num < 0)
                {
                    negativeCounter++;
                }
                else if (num > 0)
                {
                    positiveCounter++;
                }
                else
                {
                    zeroCounter++;
                }
            }
            double p = positiveCounter / n;
            double neg = negativeCounter / n;
            double zero = zeroCounter / n;

            Console.WriteLine(p);
            Console.WriteLine(neg);
            Console.WriteLine(zero);

            Console.ReadLine();
        }
    }
}
